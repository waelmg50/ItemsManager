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
    public partial class frmItemsUnits : ItemsManager.BaseForms.frmActionBase
    {

        #region Constructor

        public frmItemsUnits()
        {
            strTableName = "ItemsUnits";
            InitializeComponent();
        }
        public frmItemsUnits(int ItemID)
        {
            strTableName = "ItemsUnits";
            iItemID = ItemID;
            strCondtion = " ItemID = " + iItemID.ToString() + " ";
            InitializeComponent();
        }

        #endregion

        #region Members

        entItemsUnits Crrnt = new entItemsUnits();
        int iItemID = 0;

        #endregion

        #region Overrided Methods

        protected override int InsertData()
        {
            try
            {
                base.InsertData();
                return mngrItemsUnits.Insert(Crrnt);
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
                return -1;
            }
        }
        protected override int UpdateData()
        {
            try
            {
                base.UpdateData();
                return mngrItemsUnits.Update(Crrnt);
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
                return -1;
            }
        }
        protected override int Delete()
        {
            try
            {
                base.Delete();
                return mngrItemsUnits.Delete(iRecordID);
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
                if (iRecordID > 0)
                {
                    Crrnt = new entItemsUnits(iRecordID);
                    tvcmbCategory.SelectedValue = RecordsFunctions.GetNameUsingID("Items", "CategoryID", Crrnt.ItemID);
                    cmbItemID.SelectedValue = Crrnt.ItemID;
                    cmbItemID_SelectedIndexChanged(null, null);
                    cmbTypeID.SelectedValue = RecordsFunctions.GetNameUsingID("Units", "TypeID", Crrnt.UnitID);
                    cmbTypeID_SelectedIndexChanged(null, null);
                    cmbUnitID.SelectedValue = Crrnt.UnitID;
                    txtnUnitPrice.Text = Crrnt.UnitPrice.ToString("0.00");
                    chkIsDefault.Checked = Crrnt.IsDefault;
                }
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
                ReInitialize();
                if (iRecordID > 0)
                    Crrnt.ID = iRecordID;
                Crrnt.IsDefault = chkIsDefault.Checked;
                if (Helper.CheckNumberInt(cmbItemID.SelectedValue))
                    Crrnt.ItemID = Convert.ToInt32(cmbItemID.SelectedValue);
                if (Helper.CheckNumberInt(cmbUnitID.SelectedValue))
                    Crrnt.UnitID = Convert.ToInt32(cmbUnitID.SelectedValue);
                if (Helper.CheckNumberDouble(txtnUnitPrice.Text))
                    Crrnt.UnitPrice = Convert.ToDecimal(txtnUnitPrice.Text);
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }
        protected override bool IsFormModified()
        {
            try
            {
                bool Res = base.IsFormModified();
                if (frmstsStatus == SystemClasses.Enumerations.FormStatus.New)
                    return Res || txtnUnitPrice.Text.Length > 0 || cmbTypeID.SelectedValue != null || (tvcmbCategory.SelectedValue != null
                        && tvcmbCategory.SelectedValue.ToString() != "System.Object") || cmbItemID.SelectedValue != null || cmbUnitID.SelectedValue != null
                        || chkIsDefault.Checked;
                else
                {
                    GetObject();
                    return Crrnt != new entItemsUnits(iRecordID);
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
                return false;
            }
        }
        protected override void SetFocus()
        {
            try
            {
                base.SetFocus();
                tvcmbCategory.Focus();
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }
        protected override void ReInitialize()
        {
            base.ReInitialize();
            Crrnt = new entItemsUnits();
        }
        protected override bool ValidateForm()
        {
            try
            {
                bool Res = base.ValidateForm();
                if (cmbItemID.SelectedValue != null && cmbUnitID.SelectedValue != null)
                {
                    if (RecordsFunctions.IsDataExists(strTableName, "ItemID", cmbItemID.SelectedValue.ToString(), iRecordID, "UnitID = "
                        + cmbUnitID.SelectedValue.ToString()))
                    {
                        errprvForm.SetError(cmbItemID, Resources.ProgramMessages.ErrMesUnitIsEnteredForItem);
                        errprvForm.SetError(cmbUnitID, Resources.ProgramMessages.ErrMesUnitIsEnteredForItem);
                        Res = false;
                    }
                }
                if (Helper.CheckNumberDouble(txtnUnitPrice.Text) && Convert.ToDecimal(txtnUnitPrice.Text) <= 0m)
                {
                    errprvForm.SetError(txtnUnitPrice, Resources.ProgramMessages.ErrMesEnterValidPrice);
                    Res = false;
                }
                if (chkIsDefault.Checked && RecordsFunctions.IsDataExists(strTableName, "ItemID", cmbItemID.SelectedValue.ToString(), iRecordID,
                    "UnitID <> " + cmbUnitID.SelectedValue.ToString() + " and IsDefault = 1"))
                {
                    errprvForm.SetError(chkIsDefault, Resources.ProgramMessages.ErrMesItemAlreadyHaveDefaultUnit);
                    errprvForm.SetError(cmbUnitID, Resources.ProgramMessages.ErrMesItemAlreadyHaveDefaultUnit);
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
        protected override void AddNew()
        {
            try
            {
                base.AddNew();
                LoadItemData();
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }
        protected override void EmptyControls(Control.ControlCollection emptControls)
        {
            int iItemID=0, iItemCategoryID =0;
            if (Helper.CheckNumberInt(cmbItemID.SelectedValue))
                iItemID = Convert.ToInt32(cmbItemID.SelectedValue);
            if (Helper.CheckNumberInt(tvcmbCategory.SelectedValue))
                iItemCategoryID = Convert.ToInt32(tvcmbCategory.SelectedValue);
            base.EmptyControls(emptControls);
            if (iItemCategoryID > 0)
                tvcmbCategory.SelectedValue = iItemCategoryID;
            if (iItemID > 0)
                cmbItemID.SelectedValue = iItemID;
        }

        #endregion

        #region Methods

        void LoadData()
        {
            try
            {
                cmbTypeID.DataSource = mngrUnitsTypes.GetUnitsTypesHaveUnits();
                cmbTypeID.DisplayMember = "Name";
                cmbTypeID.ValueMember = "ID";
                cmbTypeID.SelectedIndex = -1;
                cmbTypeID.Text = string.Empty;
                tvcmbCategory.DataSources = new DataTable[] { mngrItemsCategories.GetItemsCategoriesHaveItems() };
                tvcmbCategory.DisplayMembers = new string[] { "Name" };
                tvcmbCategory.PrimaryKeyMemebers = new string[] { "ID" };
                tvcmbCategory.RelationMembers = new string[] { "ParentID" };
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }
        void LoadItemData()
        {
            try
            {
                if (iItemID > 0)
                {
                    tvcmbCategory.SelectedValue = RecordsFunctions.GetNameUsingID("Items", "CategoryID", iItemID);
                    cmbItemID.SelectedValue = iItemID;
                    cmbItemID_SelectedIndexChanged(null, null);
                    tvcmbCategory.Enabled = cmbItemID.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }

        #endregion

        #region Event Handlers

        private void frmItemsUnits_Load(object sender, EventArgs e)
        {
            try
            {
                LoadData();
                LoadItemData();
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
                    cmbItemID.DataSource = mngrItems.GetItemsByCategoryID(Convert.ToInt32(tvcmbCategory.SelectedValue));
                    cmbItemID.DisplayMember = "Name";
                    cmbItemID.ValueMember = "ID";
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }
        private void cmbTypeID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (Helper.CheckNumberInt(cmbTypeID.SelectedValue))
                {
                    cmbUnitID.DataSource = mngrUnits.GetTypeUnits(Convert.ToInt32(cmbTypeID.SelectedValue));
                    cmbUnitID.DisplayMember = "Name";
                    cmbUnitID.ValueMember = "ID";
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
                    dgvItemUnits.DataSource = mngrItemsUnits.GetItemsUnitsByItemID(Convert.ToInt32(cmbItemID.SelectedValue));
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }
        private void dgvItemUnits_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dgvItemUnits.CurrentRow != null && Helper.CheckNumberInt(dgvItemUnits.CurrentRow.Cells[0].Value))
                    ChangeCurrentID(Convert.ToInt32(dgvItemUnits.CurrentRow.Cells[0].Value));
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }

        #endregion

    }
}