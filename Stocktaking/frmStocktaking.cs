using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Entities;
using Managers;
using Utilities;

namespace ItemsManager.Stocktaking
{
    public partial class frmStocktaking : ItemsManager.BaseForms.frmMasterDetailsBase
    {

        #region Constructor

        public frmStocktaking()
        {
            strTableName = "StocktakingHead";
            InitializeComponent();
        }

        #endregion

        #region Memebers

        entStocktakingHead Crrnt = new entStocktakingHead();

        #endregion

        #region Overrided Methods

        protected override void AddNew()
        {
            base.AddNew();
            LoadEmptyStocktaking();
        }
        protected override bool IsFormModified()
        {
            base.IsFormModified();
            return bChangesOccured;
        }
        protected override void LoadGrid()
        {
            try
            {
                base.LoadGrid();
                if (frmstsStatus == SystemClasses.Enumerations.FormStatus.New)
                    LoadEmptyStocktaking();
                else
                {
                    tblDetails = mngrStocktakingDetails.GetStocktakingDetails(iRecordID);
                    dgvStockTaking.DataSource = tblDetails;
                }
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
                return mngrStocktakingHead.Insert(Crrnt, sqltrnSave);
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
                return mngrStocktakingHead.Update(Crrnt, sqltrnSave);
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
                return 0;
            }
        }
        protected override int Delete()
        {
            base.Delete();
            return mngrStocktakingHead.Delete(iRecordID);
        }
        protected override int DeleteDetails(int iDetailID)
        {
            try
            {
                base.DeleteDetails(iDetailID);
                return mngrStocktakingDetails.Delete(iDetailsID, sqltrnSave);
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
                txtID.Focus();
                base.SaveDetails(dRowDetial);
                int iSaveRes = 0;
                entStocktakingDetails entStcktkngDtls = new entStocktakingDetails();
                if (Helper.CheckNumberInt(dRowDetial["ID"]))
                    entStcktkngDtls.ID = Convert.ToInt32(dRowDetial["ID"]);
                entStcktkngDtls.ItemID = Convert.ToInt32(dRowDetial["ItemID"]);
                entStcktkngDtls.UnitID = Convert.ToInt32(dRowDetial["UnitID"]);
                entStcktkngDtls.CalculatedQuantity = Convert.ToDecimal(dRowDetial["CalculatedQuantity"]);
                entStcktkngDtls.ExistigQuantity = Convert.ToDecimal(dRowDetial["ExistigQuantity"]);
                entStcktkngDtls.StocktakingHeadID = iRecordID;
                if (entStcktkngDtls.ID <= 0)
                    iSaveRes = mngrStocktakingDetails.Insert(entStcktkngDtls, sqltrnSave);
                else
                {
                    iSaveRes = mngrStocktakingDetails.Update(entStcktkngDtls, sqltrnSave);
                    iSaveRes = entStcktkngDtls.ID;
                }
                if (iSaveRes <= 0)
                    return iSaveRes;
                if (RelateWithItemsIn(iSaveRes, entStcktkngDtls.CalculatedQuantity - entStcktkngDtls.ExistigQuantity, true))
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
                entStocktakingHead entStcktkngHd = new entStocktakingHead(iRecordID);
                dtpStocktackingDate.Value = DateTime.Now;
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
                Crrnt.StockTakingDate = DateTime.Now;
                Crrnt.ShiftID = UserLogin.CurrentShiftID;
                Crrnt.UserID = UserLogin.LoggedUserID;
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }
        protected override bool ValidateForm()
        {
            bool Res = base.ValidateForm();
            if (dgvStockTaking.Rows.Count == 0)
            {
                Helper.ShowMessage(Resources.ProgramMessages.ErrMesEnterItmes);
                dgvStockTaking.Focus();
                Res = false;
            }
            return Res;
        }

        #endregion

        #region Methods

        void LoadEmptyStocktaking()
        {
            try
            {
                tblDetails = mngrStocktakingHead.GetEmptyStocktaking();
                if (tblDetails == null || tblDetails.Rows.Count == 0)
                {
                    Helper.ShowMessage(Resources.ProgramMessages.ErrMesNoItemsExist);
                    Close();
                }
                else
                    dgvStockTaking.DataSource = tblDetails;
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }
        void LoadExistingStocktaking()
        {
            tblDetails = mngrStocktakingDetails.GetStocktakingDetails(iRecordID);
            dgvStockTaking.DataSource = tblDetails;
        }
        bool RelateWithItemsIn(int iDetails, decimal dQuantity, bool bFirstCall)
        {
            try
            {
                if (bFirstCall)
                    mngrItemsInDetails_StocktakingDetails.DeleteAllStocktakingDetails(iDetails, sqltrnSave);
                entStocktakingDetails entStackingDtls = new entStocktakingDetails(iDetails, sqltrnSave);
                int iItemID = entStackingDtls.ItemID;
                if (entStackingDtls.LackQuantity <= 0)
                    return true;
                DataTable tblItemInDetail = mngrItemsInDetails.GetItemsInOldestUnfinished(iItemID, sqltrnSave);
                if (tblItemInDetail.Rows.Count > 0)
                {
                    int iItemInDetailID = Convert.ToInt32(tblItemInDetail.Rows[0]["ID"]);
                    int iItemInUnitID = Convert.ToInt32(tblItemInDetail.Rows[0]["UnitID"]);
                    decimal dItemInQuantity = Convert.ToDecimal(tblItemInDetail.Rows[0]["CurrentQuantity"]);
                    int iStocktakingDetailUnitID = entStackingDtls.UnitID;
                    decimal dStocktakingDetailQuantity = dQuantity;
                    decimal dUnitRelation = mngrItemsUnitsConversions.GetUnitsRelation(iStocktakingDetailUnitID, iItemInUnitID, iItemID, sqltrnSave);
                    dStocktakingDetailQuantity *= dUnitRelation;
                    entItemsInDetails_StocktakingDetails entItemsInInvDtls = new entItemsInDetails_StocktakingDetails();
                    entItemsInInvDtls.StocktakingDetailsID = iDetails;
                    entItemsInInvDtls.ItemInID = iItemInDetailID;
                    bool bIsSmallStocktaking = dItemInQuantity >= dStocktakingDetailQuantity;
                    if (bIsSmallStocktaking)
                        entItemsInInvDtls.Quantity = dStocktakingDetailQuantity;
                    else
                        entItemsInInvDtls.Quantity = dItemInQuantity;
                    int iInsertRes = mngrItemsInDetails_StocktakingDetails.Insert(entItemsInInvDtls, sqltrnSave);
                    if (iInsertRes <= 0)
                        return false;
                    if (!bIsSmallStocktaking)
                        return RelateWithItemsIn(iDetails, dStocktakingDetailQuantity - dItemInQuantity, false);
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

        #endregion

        #region Event Handlers

        private void frmStocktaking_Load(object sender, EventArgs e)
        {
            try
            {
                LoadEmptyStocktaking();
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }
        private void dgvStockTaking_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e == null || dgvStockTaking.Columns["ExistigQuantity"] == null || e.ColumnIndex != dgvStockTaking.Columns["ExistigQuantity"].Index)
                    return;
                if (dgvStockTaking.CurrentRow != null
                    && Helper.CheckNumberDouble(dgvStockTaking["ExistigQuantity", e.RowIndex].EditedFormattedValue)
                    && Helper.CheckNumberDouble(dgvStockTaking["CalculatedQuantity", e.RowIndex].EditedFormattedValue))
                {
                    int iRowIndex = dgvStockTaking.CurrentRow.Index;
                    dgvStockTaking["LackQuantity", iRowIndex].Value
                        = Convert.ToDecimal(dgvStockTaking["CalculatedQuantity", e.RowIndex].EditedFormattedValue)
                        - Convert.ToDecimal(dgvStockTaking["ExistigQuantity", e.RowIndex].EditedFormattedValue);
                    bChangesOccured = true;
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }
        private void dgvStockTaking_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e == null || dgvStockTaking.Columns["ExistigQuantity"] == null || e.ColumnIndex != dgvStockTaking.Columns["ExistigQuantity"].Index)
                return;
            if (!Helper.CheckNumberDouble(dgvStockTaking["ExistigQuantity", e.RowIndex].EditedFormattedValue))
            {
                Helper.ShowMessage(Resources.ProgramMessages.ErrMesEnterValidQuantity);
                e.Cancel = true;
                return;
            }
            if (Convert.ToDecimal(dgvStockTaking["ExistigQuantity", e.RowIndex].EditedFormattedValue) >
                Convert.ToDecimal(dgvStockTaking["CalculatedQuantity", e.RowIndex].EditedFormattedValue))
            {
                Helper.ShowMessage(Resources.ProgramMessages.ErrMesExistingQuantityBiggerThanCalculated);
                e.Cancel = true;
            }
        }
        private void dgvStockTaking_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //e.Cancel = true;
        }

        #endregion

    }
}
