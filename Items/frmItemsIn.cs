using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Utilities;
using Entities;
using Managers;

namespace ItemsManager.Items
{
    public partial class frmItemsIn : BaseForms.frmMasterDetailsBase
    {

        #region Constructor

        public frmItemsIn()
        {
            strTableName = "ItemsInHead";
            InitializeComponent();
        }

        #endregion

        #region Memebers

        entItemsInHead Currnt = new entItemsInHead();

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
                cbxSupplier.DataSource = mngrSuppliers.GetSuppliersByIsSupplier(true);
                cbxSupplier.DisplayMember = "Name";
                cbxSupplier.ValueMember = "ID";
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
                tblDetails = mngrItemsInDetails.GetItemsInDetails(iRecordID);
                dgvItemsIn.DataSource = tblDetails;
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
                return mngrItemsInHead.Insert(Currnt, sqltrnSave);
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
                return mngrItemsInHead.Update(Currnt, sqltrnSave);
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
                if (mngrItemsInHead.IsItemInValidToDelete(iRecordID))
                    return mngrItemsInHead.Delete(iRecordID);
                else
                    Helper.ShowMessage(Resources.ProgramMessages.MesCantDeleteItemsInAfterStocktaking);
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
                return mngrItemsInDetails.Delete(iDetailsID, sqltrnSave);
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
                entItemsInDetails entItmInDtls = new entItemsInDetails();
                if (Helper.CheckNumberInt(dRowDetial["ID"]))
                    entItmInDtls.ID = Convert.ToInt32(dRowDetial["ID"]);
                entItmInDtls.ItemID = Convert.ToInt32(dRowDetial["ItemID"]);
                entItmInDtls.UnitID = Convert.ToInt32(dRowDetial["UnitID"]);
                entItmInDtls.Quantity = Convert.ToDecimal(dRowDetial["Quantity"]);
                entItmInDtls.PurchasePrice = Convert.ToDecimal(dRowDetial["PurchasePrice"]);
                entItmInDtls.ItemsInHeadID = iRecordID;
                if (entItmInDtls.ID <= 0)
                    iSaveRes = mngrItemsInDetails.Insert(entItmInDtls, sqltrnSave);
                else
                    iSaveRes = mngrItemsInDetails.Update(entItmInDtls, sqltrnSave);
                return iSaveRes;
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
                    Currnt.ID = iRecordID;
                Currnt.InDate = DateTime.Now;
                Currnt.InsertUserID = UserLogin.LoggedUserID;
                Currnt.ShiftID = UserLogin.CurrentShiftID;
                Currnt.SupplierID = Convert.ToInt32(cbxSupplier.SelectedValue);
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
                bool bResult = base.ValidateForm();
                string strErrorMessage = Resources.ProgramMessages.MesThereIsTheFollowingErrors;
                if (dgvItemsIn.Rows.Count == 0)
                {
                    strErrorMessage += "\n" + Resources.ProgramMessages.ErrMesEnterItmes;
                    txtBarCode.Focus();
                    bResult = false;
                }
                if (iRecordID > 0 && !mngrItemsInHead.IsItemInValidToDelete(iRecordID))
                {
                    strErrorMessage += "\n" + Resources.ProgramMessages.MesCantDeleteItemsInAfterStocktaking;
                    bResult = false;
                }
                if (!bResult)
                    Helper.ShowMessage(strErrorMessage);
                return bResult;
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
                bRes = txtBarCode.Text.Length > 0 || Helper.CheckNumberInt(tvcmbCategory.SelectedValue)|| cmbItemID.SelectedIndex >= 0
                    || txtnQuantity.Text.Length > 0 || cmbUnitID.SelectedIndex >= 0 || dgvItemsIn.Rows.Count > 0;
            else
                bRes = bChangesOccured;
            return bRes;
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
                if (txtnPurchasePrice.Text.Length == 0)
                {
                    errprvForm.SetError(txtnPurchasePrice, Resources.ProgramMessages.MesEnterField);
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

        #endregion

        #region Event Handlers

        private void tvcmbCategory_AfterSelect(object sender, EventArgs e)
        {
            try
            {
                if (Helper.CheckNumberInt(tvcmbCategory.SelectedValue))
                {
                    cmbItemID.DataSource = mngrItems.GetItemsByCategoryID(Convert.ToInt32(tvcmbCategory.SelectedValue));
                    cmbItemID.DisplayMember = "Name";
                    cmbItemID.ValueMember = "ID";
                    if (cmbItemID.Items.Count > 0)
                    {
                        cmbItemID.SelectedIndex = 0;
                        cmbItemID_SelectedIndexChanged(null, null);
                        cmbItemID.Focus();
                    }
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
                    txtnQuantity.Text = "1";
                    string strBarCode = RecordsFunctions.GetNameUsingID("Items", "BarCode", iItemID);
                    if (strBarCode != txtBarCode.Text)
                        txtBarCode.Text = strBarCode;
                }
                //else
                //{
                //    btnClean_Click(null, null);
                //    cmbItemID.Focus();
                //}
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
                    //object objDetailID = null;
                    //if (iDetailsID > 0)
                    //    objDetailID = iDetailsID;
                    DataRow dRow = tblDetails.NewRow();
                    dRow["ID"] = iDetailsID;
                    dRow["ItemID"] = cmbItemID.SelectedValue;
                    dRow["ItemName"] = cmbItemID.Text;
                    dRow["Quantity"] = txtnQuantity.Text;
                    dRow["UnitID"] = cmbUnitID.SelectedValue;
                    dRow["UnitName"] = cmbUnitID.Text;
                    dRow["PurchasePrice"] = txtnPurchasePrice.Text;
                    tblDetails.Rows.Add(dRow);
                    btnClean_Click(null, null);
                    bChangesOccured = true;
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
                if (iDetailsID > 0 && !ilstRemovedDetailsID.Contains(iDetailsID))
                    ilstRemovedDetailsID.Add(iDetailsID);
                cmbUnitID.SelectedIndex = cmbItemID.SelectedIndex = -1;
                txtnPurchasePrice.Text = cmbUnitID.Text = cmbItemID.Text = txtBarCode.Text = txtnQuantity.Text = string.Empty;
                tvcmbCategory.SelectedValue = null;
                iDetailsID = 0;
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
                if (txtnQuantity.Text.Length > 0)
                    txtnPurchasePrice.Focus();
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }
        private void dgvItemsIn_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dgvItemsIn.SelectedRows.Count > 0)
                {
                    if (dgvItemsIn.SelectedRows[0].Index < tblDetails.Rows.Count)
                    {
                        if (iDetailsID > 0)
                        {
                            DataRow dRow = tblDetails.NewRow();
                            dRow["ID"] = iDetailsID;
                            dRow["ItemID"] = cmbItemID.SelectedValue;
                            dRow["ItemName"] = cmbItemID.Text;
                            dRow["Quantity"] = txtnQuantity.Text;
                            dRow["UnitID"] = cmbUnitID.SelectedValue;
                            dRow["UnitName"] = cmbUnitID.Text;
                            dRow["PurchasePrice"] = txtnPurchasePrice.Text;
                            tblDetails.Rows.Add(dRow);
                        }
                        DataRow drowItemIn = tblDetails.Rows[dgvItemsIn.SelectedRows[0].Index];
                        iDetailsID = Convert.ToInt32(drowItemIn["ID"]);
                        tvcmbCategory.SelectedValue = RecordsFunctions.GetNameUsingID("Items", "CategoryID",
                            Convert.ToInt32(drowItemIn["ItemID"]));
                        cmbItemID.SelectedValue = drowItemIn["ItemID"];
                        cmbUnitID.SelectedValue = drowItemIn["UnitID"];
                        txtnPurchasePrice.Text = Convert.ToDecimal(drowItemIn["PurchasePrice"]).ToString("0.00");
                        txtnQuantity.Text = Convert.ToDecimal(drowItemIn["Quantity"]).ToString("0.00");
                        tblDetails.Rows.Remove(drowItemIn);
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }
        private void dgvItemsIn_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvItemsIn.RowCount > 0 && e.ColumnIndex == dgvItemsIn.Columns["Quantity"].Index)
                    bChangesOccured = true;
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }
        private void frmItemsIn_Load(object sender, EventArgs e)
        {
            try
            {
                RecordsFunctions.AutoComplete("Items", "BarCode", txtBarCode);
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
        private void txtBarCode_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            try
            {
                if (txtBarCode.Text.Length > 0 && e != null && (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab))
                {
                    if (txtBarCode.Text.Length > 0)
                    {
                        int iItemID = RecordsFunctions.GetIDUsingName("Items", "BarCode", txtBarCode.Text);
                        if (iItemID > 0 && (cmbItemID.SelectedValue == null || cmbItemID.SelectedValue.ToString() != iItemID.ToString()))
                        {
                            tvcmbCategory.SelectedValue = RecordsFunctions.GetNameUsingID("Items", "CategoryID", iItemID);
                            if (cmbItemID.SelectedValue != null && iItemID.ToString() != cmbItemID.SelectedValue.ToString())
                                cmbItemID.SelectedValue = iItemID;
                            txtnQuantity.Text = "1";
                            txtnQuantity.Focus();
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
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }
        private void txtnPurchasePrice_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtnPurchasePrice.Text.Length > 0)
                    btnAdd.Focus();
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }

        #endregion

    }
}