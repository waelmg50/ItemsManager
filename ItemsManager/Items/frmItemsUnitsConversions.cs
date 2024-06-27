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
    public partial class frmItemsUnitsConversions : ItemsManager.BaseForms.frmActionBase
    {

        #region Constructor

        public frmItemsUnitsConversions()
        {
            strTableName = "ItemsUnitsConversions";
            InitializeComponent();
        }
        public frmItemsUnitsConversions(int ItemID)
        {
            strTableName = "ItemsUnitsConversions";
            iItemID = ItemID;
            strCondtion = " ItemID = " + iItemID.ToString() + " ";
            InitializeComponent();
        }

        #endregion

        #region Members

        entItemsUnitsConversions Crrnt = new entItemsUnitsConversions();
        int iItemID = 0;

        #endregion

        #region Overrided Methods

        protected override int InsertData()
        {
            try
            {
                base.InsertData();
                return mngrItemsUnitsConversions.Insert(Crrnt);
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
                return mngrItemsUnitsConversions.Update(Crrnt);
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
                return mngrItemsUnitsConversions.Delete(iRecordID);
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
                    Crrnt = new entItemsUnitsConversions(iRecordID);
                    tvcmbCategory.SelectedValue = RecordsFunctions.GetNameUsingID("Items", "CategoryID", Crrnt.ItemID);
                    cmbItemID.SelectedValue = Crrnt.ItemID;
                    cmbItemID_SelectedIndexChanged(null, null);
                    cmbFromUnitID.SelectedValue = Crrnt.FromUnitID;
                    cmbToUnitTypeID.SelectedValue = RecordsFunctions.GetNameUsingID("Units", "TypeID", Crrnt.ToUnitID);
                    cmbToUnitID.SelectedValue = Crrnt.ToUnitID;
                    txtnQuantity.Text = Crrnt.Quantity.ToString("0.00");
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
                if (Helper.CheckNumberInt(cmbItemID.SelectedValue))
                    Crrnt.ItemID = Convert.ToInt32(cmbItemID.SelectedValue);
                if (Helper.CheckNumberInt(cmbFromUnitID.SelectedValue))
                    Crrnt.FromUnitID = Convert.ToInt32(cmbFromUnitID.SelectedValue);
                if (Helper.CheckNumberInt(cmbToUnitID.SelectedValue))
                    Crrnt.ToUnitID = Convert.ToInt32(cmbToUnitID.SelectedValue);
                if (Helper.CheckNumberDouble(txtnQuantity.Text))
                    Crrnt.Quantity = Convert.ToDecimal(txtnQuantity.Text);
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
                    return Res || txtnQuantity.Text.Length > 0 || cmbToUnitTypeID.SelectedValue != null
                        || Helper.CheckNumberInt(tvcmbCategory.SelectedValue) || cmbItemID.SelectedValue != null
                        || cmbToUnitID.SelectedValue != null || cmbFromUnitID.SelectedValue != null;
                else
                {
                    GetObject();
                    return Crrnt != new entItemsUnitsConversions(iRecordID);
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
            Crrnt = new entItemsUnitsConversions();
        }
        protected override bool ValidateForm()
        {
            try
            {
                bool Res = base.ValidateForm();
                if (cmbItemID.SelectedValue != null && cmbToUnitID.SelectedValue != null)
                {
                    if (RecordsFunctions.IsDataExists(strTableName, "ItemID", cmbItemID.SelectedValue.ToString(), iRecordID, "FromUnitID = "
                        + cmbFromUnitID.SelectedValue.ToString() + " and ToUnitID = " + cmbToUnitID.SelectedValue.ToString()))
                    {
                        errprvForm.SetError(cmbItemID, Resources.ProgramMessages.ErrMesConversionEnteredForItem);
                        errprvForm.SetError(cmbFromUnitID, Resources.ProgramMessages.ErrMesConversionEnteredForItem);
                        errprvForm.SetError(cmbToUnitID, Resources.ProgramMessages.ErrMesConversionEnteredForItem);
                        Res = false;
                    }
                }
                if (Helper.CheckNumberDouble(txtnQuantity.Text) && Convert.ToDecimal(txtnQuantity.Text) <= 0m)
                {
                    errprvForm.SetError(txtnQuantity, Resources.ProgramMessages.ErrMesEnterValidQuantity);
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

        #endregion

        #region Methods

        void LoadData()
        {
            try
            {
                tvcmbCategory.DataSources = new DataTable[] { mngrItemsCategories.GetItemsCategoriesHaveNumericItems() };
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

        private void frmItemsUnitsConversions_Load(object sender, EventArgs e)
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
        private void cmbToUnitTypeID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (Helper.CheckNumberInt(cmbToUnitTypeID.SelectedValue) && Helper.CheckNumberInt(cmbItemID.SelectedValue))
                {
                    cmbToUnitID.DataSource = mngrUnits.GetItemTypeUnits(Convert.ToInt32(cmbToUnitTypeID.SelectedValue),
                        Convert.ToInt32(cmbItemID.SelectedValue));
                    cmbToUnitID.DisplayMember = "Name";
                    cmbToUnitID.ValueMember = "ID";
                }
                else
                    cmbToUnitID.DataSource = null;
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
                    dgvItemUnitsConversions.DataSource = mngrItemsUnitsConversions.GetItemsUnitsConversionsByItemID(iItemID);
                    cmbFromUnitID.DataSource = mngrUnits.GetItemTypeUnits(2, iItemID);
                    cmbToUnitTypeID.DataSource = mngrUnitsTypes.GetUnitsTypesHaveItemUnits(iItemID);
                    cmbFromUnitID.DisplayMember = cmbToUnitTypeID.DisplayMember = "Name";
                    cmbFromUnitID.ValueMember = cmbToUnitTypeID.ValueMember = "ID";
                    cmbToUnitTypeID.SelectedIndex = -1;
                    cmbToUnitTypeID.Text = string.Empty;
                }
                else
                    cmbFromUnitID.DataSource = cmbToUnitID.DataSource = null;
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
                if (dgvItemUnitsConversions.CurrentRow != null && Helper.CheckNumberInt(dgvItemUnitsConversions.CurrentRow.Cells[0].Value))
                    ChangeCurrentID(Convert.ToInt32(dgvItemUnitsConversions.CurrentRow.Cells[0].Value));
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }

        #endregion

    }
}
