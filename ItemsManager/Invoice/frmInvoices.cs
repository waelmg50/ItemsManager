using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Utilities;
using Entities;
using Managers;
using ItemsManager.DevExpressReports;
using ItemsManager.Items;

namespace ItemsManager.Invoice
{
    public partial class frmInvoices : BaseForms.frmMasterDetailsBase
    {

        #region Constructor

        public frmInvoices()
        {
            strTableName = "InvoiceHead";
            InitializeComponent();
        }

        #endregion

        #region Memebers

        entInvoiceHead Crrnt = new entInvoiceHead();
        bool bGridValueChange = false;
        bool bBarCodeKeyDwon = false;
        bool bItemsCategoryChange = false;
        decimal dExistingQuantity = 0m;
        List<string> strlstItemNames = new List<string>();
        
        #endregion

        #region Overrided Methods

        protected override void LoadData()
        {
            try
            {
                base.LoadData();
                tvcmbCategory.DataSources = new DataTable[] { mngrItemsCategories.GetItemsCategoriesHaveItems() };
                tvcmbCategory.DisplayMembers = new string[] { "Name" };
                tvcmbCategory.PrimaryKeyMemebers = new string[] { "ID" };
                tvcmbCategory.RelationMembers = new string[] { "ParentID" };
                cbxCustomer.DataSource = null;
                cbxCustomer.DisplayMember = "Name";
                cbxCustomer.ValueMember = "ID";
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }
        protected override void LoadGrid()
        {
            try
            {
                base.LoadGrid();
                tblDetails = mngrInvoiceDetails.GetInvoiceDetails(iRecordID);
                dgvInvoice.DataSource = tblDetails;
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }
        protected override int InsertData()
        {
            try
            {
                base.InsertData();
                return mngrInvoiceHead.Insert(Crrnt, sqltrnSave);
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
                return 0;
            }
        }
        protected override int UpdateData()
        {
            try
            {
                base.UpdateData();
                return mngrInvoiceHead.Update(Crrnt, sqltrnSave);
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
                return 0;
            }
        }
        protected override int Delete()
        {
            try
            {
                base.Delete();
                if (mngrInvoiceHead.IsInvoiceValidToDelete(iRecordID))
                    return mngrInvoiceHead.Delete(iRecordID);
                else
                    Helper.ShowMessage(Resources.ProgramMessages.MesCantDeleteInvoiceAfterStocktaking);
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
            return 0;
        }
        protected override int DeleteDetails(int iDetailID)
        {
            try
            {
                base.DeleteDetails(iDetailID);
                return mngrInvoiceDetails.Delete(iDetailID, sqltrnSave);
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
                return 0;
            }
        }
        protected override int SaveDetails(DataRow dRowDetial)
        {
            try
            {
                base.SaveDetails(dRowDetial);
                int iSaveRes = 0;
                entInvoiceDetails entInvDtls = new entInvoiceDetails();
                if (Helper.CheckNumberInt(dRowDetial["ID"]))
                    entInvDtls.ID = Convert.ToInt32(dRowDetial["ID"]);
                entInvDtls.ItemID = Convert.ToInt32(dRowDetial["ItemID"]);
                entInvDtls.UnitID = Convert.ToInt32(dRowDetial["UnitID"]);
                entInvDtls.Quantity = Convert.ToDecimal(dRowDetial["Quantity"]);
                entInvDtls.UnitPrice = Convert.ToDecimal(dRowDetial["UnitPrice"]);
                entInvDtls.InvoiceHeadID = iRecordID;
                if (entInvDtls.ID <= 0)
                    iSaveRes = mngrInvoiceDetails.Insert(entInvDtls, sqltrnSave);
                else
                {
                    iSaveRes = mngrInvoiceDetails.Update(entInvDtls, sqltrnSave);
                    if (iSaveRes <= 0)
                        return iSaveRes;
                    iSaveRes = entInvDtls.ID;
                }
                if (RelateWithItemsIn(iSaveRes, entInvDtls.Quantity, true))
                    return iSaveRes;
                else
                    return 0;
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
                return 0;
            }
        }
        protected override void DisplayObject()
        {
            try
            {
                base.DisplayObject();
                Crrnt = new entInvoiceHead(iRecordID);
                cbxCustomer.SelectedValue = Crrnt.CustomerID;
                txtTotalCash.Text = Crrnt.TotalCash.ToString("0.00");
                LoadGrid();
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }
        protected override void GetObject()
        {
            try
            {
                base.GetObject();
                if (iRecordID > 0)
                    Crrnt.ID = iRecordID;
                Crrnt.InvDate = DateTime.Now;
                Crrnt.SellUserID = UserLogin.LoggedUserID;
                Crrnt.ShiftID = UserLogin.CurrentShiftID;
                Crrnt.CustomerID = Convert.ToInt32(cbxCustomer.SelectedValue);
                if (Helper.CheckNumberDouble(txtnQuantity.Text))
                    Crrnt.TotalCash = Convert.ToDecimal(txtnQuantity.Text);
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }
        protected override bool ValidateForm()
        {
            try
            {
                bool Res = base.ValidateForm();
                if (dgvInvoice.Rows.Count == 0)
                {
                    Helper.ShowMessage(Resources.ProgramMessages.ErrMesEnterItmes);
                    txtBarCode.Focus();
                    Res = false;
                }
                if (iRecordID > 0 && !mngrInvoiceHead.IsInvoiceValidToDelete(iRecordID))
                {
                    Helper.ShowMessage(Resources.ProgramMessages.MesCantDeleteInvoiceAfterStocktaking);
                    Res = false;
                }
                return Res;
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
                return false;
            }
        }
        protected override bool IsFormModified()
        {
            bool bRes = base.IsFormModified();
            if (frmstsStatus == SystemClasses.Enumerations.FormStatus.New)
                bRes = txtBarCode.Text.Length > 0 || Helper.CheckNumberInt(tvcmbCategory.SelectedValue) || cmbItemID.SelectedIndex >= 0
                    || txtnQuantity.Text.Length > 0 || cmbUnitID.SelectedIndex >= 0 || dgvInvoice.Rows.Count > 0;
            else
                bRes = bChangesOccured;
            return bRes;
        }
        protected override bool CheckBeforeSave()
        {
            try
            {
                if (CheckExistingQuantity())
                    return true;
                else
                {
                    if (sqltrnSave.Connection != null)
                        sqltrnSave.Rollback();
                    Helper.ShowMessage(Resources.ProgramMessages.MesNoExistingItemQuantity);
                    return false;
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
            return false;
        }
        protected override void Print()
        {
            base.Print();
            DevExpress.XtraReports.UI.XtraReport rptShiftReport = new DevExpress.XtraReports.UI.XtraReport();
            string strReportPath = $@"{Application.StartupPath}\Report\Invoices.repx";
            rptShiftReport.LoadLayout(strReportPath);
            rptShiftReport.DataSource = SqlAdoWrapper.ExecuteQueryCommand("Invoice_SelectReportByID", new System.Data.SqlClient.SqlParameter[] { new System.Data.SqlClient.SqlParameter("@InvoiceID", iRecordID) }, false);
            frmDisplayReport frmDspRprt = new frmDisplayReport() { ReportDocumnet = rptShiftReport };
            frmDspRprt.ShowDialog(this);
        }

        #endregion

        #region Methods

        bool ValidateDetails()
        {
            try
            {
                errprvForm.Clear();
                bool bRes = true;
                if (!Helper.CheckNumberInt(cmbItemID.SelectedValue))
                {
                    errprvForm.SetError(cmbItemID, Resources.ProgramMessages.MesEnterField);
                    bRes = false;
                }
                if (!Helper.CheckNumberInt(cmbUnitID.SelectedValue))
                {
                    errprvForm.SetError(cmbUnitID, Resources.ProgramMessages.MesEnterField);
                    bRes = false;
                }
                if (txtnQuantity.Text.Length == 0)
                {
                    errprvForm.SetError(txtnQuantity, Resources.ProgramMessages.MesEnterField);
                    bRes = false;
                }
                if (IsItemExist(cmbItemID.SelectedValue))
                {
                    errprvForm.SetError(cmbItemID, Resources.ProgramMessages.ErrMesItemEntered);
                    bRes = false;
                }
                return bRes;
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
                return false;
            }
        }
        bool IsItemExist(object objItemID)
        {
            try
            {
                if (objItemID == null)
                    return false;
                foreach (DataRow dRowItemInDetials in tblDetails.Rows)
                {
                    if (dRowItemInDetials["ItemID"].ToString() == objItemID.ToString())
                        return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
                return true;
            }
        }
        void DisplayTotals()
        {
            try
            {
                decimal dItemsTotals = 0;
                foreach (DataRow drowItem in tblDetails.Rows)
                {
                    if (Helper.CheckNumberDouble(drowItem["TotalPrice"]))
                        dItemsTotals += Convert.ToDecimal(drowItem["TotalPrice"]);
                }
                txtTotalCash.Text = dItemsTotals.ToString("0.00");
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }
        void DisplayCurrentTotal()
        {
            try
            {
                if (Helper.CheckNumberDouble(txtnQuantity.Text) && Helper.CheckNumberDouble(txtnUnitPrice.Text))
                    txtnTotalPrice.Text = (Convert.ToDecimal(txtnUnitPrice.Text) * Convert.ToDecimal(txtnQuantity.Text)).ToString("0.00");
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }
        bool RelateWithItemsIn(int iDetails, decimal dQuantity, bool bFirstCall)
        {
            try
            {
                if (bFirstCall)
                    mngrItemsInDetails_InvoiceDetails.DeleteAllInvoiceDtailse(iDetails, sqltrnSave);
                entInvoiceDetails entInvDtls = new entInvoiceDetails(iDetails, sqltrnSave);
                int iItemID = entInvDtls.ItemID;
                DataTable tblItemInDetail = mngrItemsInDetails.GetItemsInOldestUnfinished(iItemID, sqltrnSave);
                if (tblItemInDetail.Rows.Count > 0)
                {
                    int iItemInDetailID = Convert.ToInt32(tblItemInDetail.Rows[0]["ID"]);
                    int iItemInUnitID = Convert.ToInt32(tblItemInDetail.Rows[0]["UnitID"]);
                    decimal dItemInQuantity = Convert.ToDecimal(tblItemInDetail.Rows[0]["CurrentQuantity"]);
                    int iInvoiceDetailUnitID = entInvDtls.UnitID;
                    decimal dInvoiceDetailQuantity = dQuantity;
                    decimal dUnitRelation = mngrItemsUnitsConversions.GetUnitsRelation(iInvoiceDetailUnitID, iItemInUnitID, iItemID, sqltrnSave);
                    dInvoiceDetailQuantity *= dUnitRelation;
                    entItemsInDetails_InvoiceDetails entItemsInInvDtls = new entItemsInDetails_InvoiceDetails();
                    entItemsInInvDtls.InvoiceDetailsID = iDetails;
                    entItemsInInvDtls.ItemInID = iItemInDetailID;
                    bool bIsSmallInvoice = dItemInQuantity >= dInvoiceDetailQuantity;
                    if (bIsSmallInvoice)
                        entItemsInInvDtls.Quantity = dInvoiceDetailQuantity;
                    else
                        entItemsInInvDtls.Quantity = dItemInQuantity;
                    mngrItemsInDetails_InvoiceDetails.Insert(entItemsInInvDtls, sqltrnSave);
                    if (!bIsSmallInvoice)
                        return RelateWithItemsIn(iDetails, dInvoiceDetailQuantity - dItemInQuantity, false);
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
                return false;
            }
        }
        bool CheckExistingQuantity()
        {
            try
            {
                for (int iInvoiceDetailsIndex = 0; iInvoiceDetailsIndex < tblDetails.Rows.Count; iInvoiceDetailsIndex++)
                {
                    DataRow drowInvoiceDetail = tblDetails.Rows[iInvoiceDetailsIndex];
                    decimal dNewQuantity = Helper.CheckNumberDouble(drowInvoiceDetail["Quantity"]) ? Convert.ToDecimal(drowInvoiceDetail["Quantity"]) : 0;
                    int iInvoiceDetailID = Helper.CheckNumberInt(drowInvoiceDetail["ID"]) ? Convert.ToInt32(drowInvoiceDetail["ID"]) : 0;
                    decimal dExistQuantity = mngrItems.GetItemCurrentQuantity(Convert.ToInt32(drowInvoiceDetail["ItemID"]),
                        Convert.ToInt32(drowInvoiceDetail["UnitID"]),sqltrnSave);
                    if (iInvoiceDetailID > 0)
                    {
                        entInvoiceDetails entInvDtls = new entInvoiceDetails(iInvoiceDetailID, sqltrnSave);
                        if (dExistingQuantity < dNewQuantity - entInvDtls.Quantity)
                            return false;
                        else
                            continue;
                    }
                    else
                    {
                        if (dNewQuantity > dExistingQuantity)
                            return false;
                        else
                            continue;
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
            return false;
        }

        #endregion

        #region Event Handlers

        private void txtBarCode_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            try
            {
                bBarCodeKeyDwon = true;
                if (txtBarCode.Text.Length > 0 && e != null && (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab))
                {
                    int iItemID = RecordsFunctions.GetIDUsingName("Items", "BarCode", txtBarCode.Text);
                    //Test if item exists.
                    if (iItemID > 0 && (cmbItemID.SelectedValue == null || cmbItemID.SelectedValue.ToString() != iItemID.ToString()))
                    {
                        //Check if the item have units.
                        if (!RecordsFunctions.IsDataExists("ItemsUnits", "ItemID", iItemID.ToString(), 0))
                        {
                            Helper.ShowMessage(Resources.ProgramMessages.MesNoExistingItemUnit);
                            btnClean_Click(sender, e);
                            txtBarCode.Focus();
                            return;
                        }
                        ////Check if the item have existing quantity.
                        //if (!RecordsFunctions.IsDataExists("ItemsInDetails", "ItemID", iItemID.ToString(), 0, "CurrentQuantity > 0"))
                        //{
                        //    Helper.ShowMessage(Resources.ProgramMessages.MesNoExistingItemQuantity);
                        //    btnClean_Click(null, null);
                        //    return;
                        //}
                        tvcmbCategory.SelectedValue = RecordsFunctions.GetNameUsingID("Items", "CategoryID", iItemID);
                        bool bItemNotChanged = Helper.CheckNumberInt(cmbItemID.SelectedValue) && Convert.ToInt32(cmbItemID.SelectedValue) == iItemID;
                        cmbItemID.SelectedValue = iItemID;
                        if (bItemNotChanged)
                            cmbItemID_SelectedIndexChanged(null, null);
                        if (cmbUnitID.Items.Count > 0)
                        {
                            decimal dExistingQuantity = mngrItems.GetItemCurrentQuantity(Convert.ToInt32(cmbItemID.SelectedValue),
                            Convert.ToInt32(cmbUnitID.SelectedValue));
                            if (dExistingQuantity > 0m)
                            {
                                txtnQuantity.Text = "1";
                                txtnQuantity.Focus();
                            }
                        }
                    }
                    else
                    {
                        if (iItemID <= 0)
                        {
                            Helper.ShowMessage(Resources.ProgramMessages.MesEnterNewItem);
                            txtBarCode.Focus();
                        }
                    }
                }
                bBarCodeKeyDwon = false;
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }
        private void tvcmbCategory_AfterSelect(object sender, EventArgs e)
        {
            try
            {
                if (Helper.CheckNumberInt(tvcmbCategory.SelectedValue))
                {
                    bItemsCategoryChange = true;
                    cmbItemID.DataSource = mngrItems.GetItemsByCategoryID(Convert.ToInt32(tvcmbCategory.SelectedValue));
                    cmbItemID.DisplayMember = "Name";
                    cmbItemID.ValueMember = "ID";
                    if (cmbItemID.Items.Count > 0 && !bBarCodeKeyDwon)
                    {
                            cmbItemID.SelectedIndex = 0;
                            cmbItemID_SelectedIndexChanged(null, null);
                            cmbItemID.Focus();
                    }
                    bItemsCategoryChange = false;
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }
        private void cmbItemID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (Helper.CheckNumberInt(cmbItemID.SelectedValue))
                {
                    int iItemID = Convert.ToInt32(cmbItemID.SelectedValue);
                    cmbUnitID.DataSource = mngrUnits.GetItemUnits(iItemID);
                    cmbUnitID.DisplayMember = "Name";
                    cmbUnitID.ValueMember = "ID";
                    if (!bItemsCategoryChange)
                    {
                        if (cmbUnitID.Items.Count <= 0 && !bBarCodeKeyDwon)
                        {
                            Helper.ShowMessage(Resources.ProgramMessages.MesNoExistingItemUnit);
                            btnClean_Click(sender, e);
                            return;
                        }
                        if (!bBarCodeKeyDwon)
                        {
                            decimal dExistingQuantity = mngrItems.GetItemCurrentQuantity(Convert.ToInt32(cmbItemID.SelectedValue),
                                Convert.ToInt32(cmbUnitID.SelectedValue));
                            if (dExistingQuantity <= 0m)
                            {
                                Helper.ShowMessage(Resources.ProgramMessages.MesNoExistingItemQuantity);
                                btnClean_Click(sender, e);
                                return;
                            }
                        }
                        txtnQuantity.Text = "1";
                        cmbUnitID_SelectedIndexChanged(null, null);
                        txtnQuantity.Focus();
                    }
                    if (!bBarCodeKeyDwon)
                    {
                        string strBarCode = RecordsFunctions.GetNameUsingID("Items", "BarCode", iItemID);
                        if (strBarCode != txtBarCode.Text)
                            txtBarCode.Text = strBarCode;
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateDetails())
                {
                    DataRow dRow = tblDetails.NewRow();
                    dRow["ID"] = iDetailsID;
                    dRow["ItemID"] = cmbItemID.SelectedValue;
                    dRow["ItemName"] = cmbItemID.Text;
                    dRow["Quantity"] = txtnQuantity.Text;
                    dRow["UnitID"] = cmbUnitID.SelectedValue;
                    dRow["UnitName"] = cmbUnitID.Text;
                    dRow["UnitPrice"] = txtnUnitPrice.Text;
                    dRow["TotalPrice"] = txtnTotalPrice.Text;
                    tblDetails.Rows.Add(dRow);
                    btnClean_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }
        private void btnClean_Click(object sender, EventArgs e)
        {
            try
            {
                if (sender is Button && ((Button)sender).Name == "btnClean" && iDetailsID > 0 && !ilstRemovedDetailsID.Contains(iDetailsID))
                    ilstRemovedDetailsID.Add(iDetailsID);
                cmbUnitID.SelectedIndex = cmbItemID.SelectedIndex = -1;
                cmbUnitID.Text = cmbItemID.Text = txtBarCode.Text = txtnTotalPrice.Text = txtnUnitPrice.Text = txtnQuantity.Text = string.Empty;
                tvcmbCategory.SelectedValue = null;
                iDetailsID = 0;
                DisplayTotals();
                txtBarCode.Focus();
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }
        private void txtnQuantity_Leave(object sender, EventArgs e)
        {
            try
            {
                if (Helper.CheckNumberDouble(txtnQuantity.Text) && Helper.CheckNumberInt(cmbItemID.SelectedValue)
                    && Helper.CheckNumberInt(cmbUnitID.SelectedValue))
                {
                    dExistingQuantity = mngrItems.GetItemCurrentQuantity(Convert.ToInt32(cmbItemID.SelectedValue), Convert.ToInt32(cmbUnitID.SelectedValue));
                    if (dExistingQuantity <= 0m)
                    {
                        Helper.ShowMessage(Resources.ProgramMessages.MesNoExistingItemQuantity);
                        btnClean_Click(sender, e);
                        return;
                    }
                    if (dExistingQuantity < Convert.ToDecimal(txtnQuantity.Text))
                    {
                        DialogResult dlgRes = Helper.ShowMessage(Resources.ProgramMessages.MesVeryBigItemQuantity + dExistingQuantity.ToString()
                            + " " + Resources.ProgramMessages.MesDoYouWantToExchangeQuantities, MessageBoxButtons.YesNo);
                        if (dlgRes == DialogResult.Yes)
                            txtnQuantity.Text = dExistingQuantity.ToString();
                        else
                        {
                            btnClean_Click(sender, e);
                            return;
                        }
                    }
                }
                if (txtnQuantity.Text.Length > 0)
                    btnAdd.Focus();
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }
        private void dgvInvoice_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dgvInvoice.SelectedRows.Count > 0)
                {
                    if (dgvInvoice.SelectedRows[0].Index < tblDetails.Rows.Count)
                    {
                        DataRow drowItemIn = tblDetails.Rows[dgvInvoice.SelectedRows[0].Index];
                        iDetailsID = Convert.ToInt32(drowItemIn["ID"]);
                        tvcmbCategory.SelectedValue = RecordsFunctions.GetNameUsingID("Items", "CategoryID",
                            Convert.ToInt32(drowItemIn["ItemID"]));
                        cmbItemID.SelectedValue = drowItemIn["ItemID"];
                        cmbUnitID.SelectedValue = drowItemIn["UnitID"];
                        txtnQuantity.Text = drowItemIn["Quantity"].ToString();
                        tblDetails.Rows.Remove(drowItemIn);
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }
        private void txtnQuantity_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DisplayCurrentTotal();
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }
        private void cmbUnitID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (Helper.CheckNumberInt(cmbItemID.SelectedValue) && Helper.CheckNumberInt(cmbUnitID.SelectedValue))
                {
                    decimal dUnitPrice = mngrItems.GetItemUnitPrice(Convert.ToInt32(cmbItemID.SelectedValue),
                        Convert.ToInt32(cmbUnitID.SelectedValue));
                    txtnUnitPrice.Text = dUnitPrice.ToString("0.00");
                    DisplayCurrentTotal();
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }
        private void dgvInvoice_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (bGridValueChange)
                {
                    bGridValueChange = false;
                    return;
                }
                if (dgvInvoice.RowCount > 0 && e.ColumnIndex == dgvInvoice.Columns["Quantity"].Index)
                {
                    bChangesOccured = true;
                    decimal dRequiredQuntity = Helper.CheckNumberDouble(dgvInvoice.CurrentCell.EditedFormattedValue) ?
                        Convert.ToDecimal(dgvInvoice.CurrentCell.EditedFormattedValue) : 0m;
                    decimal dExistingQuantity = mngrItems.GetItemCurrentQuantity(Convert.ToInt32(dgvInvoice.CurrentRow.Cells["ItemID"].Value),
                        Convert.ToInt32(dgvInvoice.CurrentRow.Cells["UnitID"].Value));
                    if (dExistingQuantity < dRequiredQuntity)
                    {
                        DialogResult dlgRes = Helper.ShowMessage(Resources.ProgramMessages.MesVeryBigItemQuantity + dExistingQuantity.ToString()
                            + " " + Resources.ProgramMessages.MesDoYouWantToExchangeQuantities, MessageBoxButtons.YesNo);
                        if (dlgRes == DialogResult.Yes)
                        {
                            bGridValueChange = true;
                            dgvInvoice.CurrentCell.Value = dExistingQuantity;
                            if (Helper.CheckNumberDouble(dgvInvoice.CurrentRow.Cells["UnitPrice"].Value))
                            {
                                dgvInvoice.CurrentRow.Cells["TotalPrice"].Value
                                    = dExistingQuantity * Convert.ToDecimal(dgvInvoice.CurrentRow.Cells["UnitPrice"].Value);
                            }
                        }
                        else
                            dgvInvoice.Rows.Remove(dgvInvoice.CurrentRow);
                    }
                    else if (Helper.CheckNumberDouble(dgvInvoice.CurrentRow.Cells["UnitPrice"].Value))
                        dgvInvoice.CurrentRow.Cells["TotalPrice"].Value
                            = dRequiredQuntity * Convert.ToDecimal(dgvInvoice.CurrentRow.Cells["UnitPrice"].Value);
                    else
                        dgvInvoice.CurrentRow.Cells["TotalPrice"].Value = 0;
                    DisplayTotals();
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }
        private void frmInvoices_Load(object sender, EventArgs e)
        {
            try
            {
                RecordsFunctions.AutoComplete("Items", "BarCode", txtBarCode);
                cbxCustomer.DataSource = mngrSuppliers.GetSuppliersByIsSupplier(false);
                cbxCustomer.DisplayMember = "Name";
                cbxCustomer.ValueMember = "ID";
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }
        private void txtnQuantity_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e != null && e.KeyCode == Keys.Enter)
                    btnAdd_Click(null, null);
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }
        private void dgvInvoice_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            try
            {
                if (dgvInvoice.RowCount > 0 && e.ColumnIndex == dgvInvoice.Columns["Quantity"].Index
                    && !Helper.CheckNumberDouble(dgvInvoice.CurrentCell.Value))
                {
                    Helper.ShowMessage(Resources.ProgramMessages.ErrMesEnterValidQuantity);
                    e.Cancel = true;
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }
        private void dgvInvoice_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            try
            {
                if (e != null)
                {
                    if (e.Exception.Message.Contains("Input string was not in a correct format") && e.ColumnIndex == dgvInvoice.Columns["Quantity"].Index)
                        Helper.ShowMessage(Resources.ProgramMessages.ErrMesEnterValidQuantity);
                    else
                        ErrorHandler.LogError(e.Exception);
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }
        private void pnlSearchItems_Click(object sender, EventArgs e)
        {
            try
            {
                frmSearchItems frmSrchItms = new frmSearchItems();
                frmSrchItms.ShowDialog(this);
                if (frmSrchItms.ItemID > 0 && frmSrchItms.CategoryID > 0)
                {
                    tvcmbCategory.SelectedValue = frmSrchItms.CategoryID;
                    tvcmbCategory_AfterSelect(null, null);
                    cmbItemID.SelectedValue = frmSrchItms.ItemID;
                    cmbItemID_SelectedIndexChanged(null, null);
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }

        #endregion

    }
}