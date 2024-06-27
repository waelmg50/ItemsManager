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
    public partial class frmItems : ItemsManager.BaseForms.frmActionBase
    {

        #region Constructor

        public frmItems()
        {
            strTableName = "Items";
            InitializeComponent();
        }

        #endregion

        #region Members

        entItems Crrnt = new entItems();

        #endregion

        #region Overrided Methods

        protected override int InsertData()
        {
            try
            {
                base.InsertData();
                return mngrItems.Insert(Crrnt);
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
                int iRes = mngrItems.Update(Crrnt);
                tvcmbCategory_AfterSelect(null, null);
                return iRes;
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
                return mngrItems.Delete(iRecordID);
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
                    Crrnt = new entItems(iRecordID);
                    txtName.Text = Crrnt.Name;
                    txtBarCode.Text = Crrnt.BarCode;
                    txtDescription.Text = Crrnt.Description;
                    tvcmbCategory.SelectedValue = Crrnt.CategoryID;
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
                Crrnt.Name = txtName.Text;
                Crrnt.BarCode = txtBarCode.Text.Trim();
                Crrnt.Description = txtDescription.Text;
                if (Helper.CheckNumberInt(tvcmbCategory.SelectedValue))
                    Crrnt.CategoryID = Convert.ToInt32(tvcmbCategory.SelectedValue);
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
                    return Res || txtName.Text.Length > 0 || txtBarCode.Text.Length > 0 || txtDescription.Text.Length > 0 ||
                        (tvcmbCategory.SelectedValue != null && tvcmbCategory.SelectedValue.ToString() != "System.Object");
                else
                {
                    GetObject();
                    return Crrnt != new entItems(iRecordID);
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
                txtBarCode.Focus();
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }
        protected override void ReInitialize()
        {
            base.ReInitialize();
            Crrnt = new entItems();
        }
        protected override bool ValidateForm()
        {
            try
            {
                bool Res = base.ValidateForm();
                if (RecordsFunctions.IsDataExists(strTableName, "Name", txtName.Text, iRecordID))
                {
                    errprvForm.SetError(txtName, Resources.ProgramMessages.ErrMessExistNameAr);
                    Res = false;
                }
                if (RecordsFunctions.IsDataExists(strTableName, "BarCode", txtBarCode.Text, iRecordID))
                {
                    errprvForm.SetError(txtBarCode, Resources.ProgramMessages.ErrMessExistNameAr);
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
        protected override void LoadInitialControls()
        {
            try
            {
                base.LoadInitialControls();
                LoadItemsCategories();
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }

         #endregion

        #region Methods

        void LoadItemsCategories()
        {
            try
            {
                tvcmbCategory.DataSources = new DataTable[] { mngrItemsCategories.GetItemsCategories() };
                tvcmbCategory.DisplayMembers = new string[] { "Name" };
                tvcmbCategory.PrimaryKeyMemebers = new string[] { "ID" };
                tvcmbCategory.RelationMembers = new string[] { "ParentID" };
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }

        #endregion

        #region Event Handlers

        private void frmItems_Load(object sender, EventArgs e)
        {
            try
            {
                RecordsFunctions.AutoComplete(strTableName, "BarCode", txtBarCode);
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }
        private void txtBarCode_Leave(object sender, EventArgs e)
        {
            try
            {
                if(txtBarCode.Text.Length > 0 && RecordsFunctions.IsDataExists(strTableName, "BarCode", txtBarCode.Text, 0))
                    ChangeCurrentID(RecordsFunctions.GetIDUsingName(strTableName, "BarCode", txtBarCode.Text));
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
                    dgvItems.DataSource = mngrItems.GetItemsByCategoryID(Convert.ToInt32(tvcmbCategory.SelectedValue));
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }
        private void dgvItems_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dgvItems.CurrentRow != null && Helper.CheckNumberInt(dgvItems["ID", dgvItems.CurrentRow.Index].Value))
                    ChangeCurrentID(Convert.ToInt32(dgvItems["ID", dgvItems.CurrentRow.Index].Value));
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }
        private void btnUnits_Click(object sender, EventArgs e)
        {
            try
            {
                if (iRecordID > 0)
                {
                    frmItemsUnits frmItmsUnts = new frmItemsUnits(iRecordID);
                    frmItmsUnts.ShowDialog(this);
                }
                else
                    Helper.ShowMessage(Resources.ProgramMessages.MesChooseItem);
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }
        private void btnUnitsConversions_Click(object sender, EventArgs e)
        {
            try
            {
                if (iRecordID > 0)
                {
                    frmItemsUnitsConversions frmItmsUntsConv = new frmItemsUnitsConversions(iRecordID);
                    frmItmsUntsConv.ShowDialog(this);
                }
                else
                    Helper.ShowMessage(Resources.ProgramMessages.MesChooseItem);
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }

        #endregion
 
    }
}