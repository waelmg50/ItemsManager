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
    public partial class frmItemsCategories : ItemsManager.BaseForms.frmActionBase
    {

        #region Constructor

        public frmItemsCategories()
        {
            strTableName = "ItemsCategories";
            InitializeComponent();
        }

        #endregion

        #region Members

        entItemsCategories Crrnt = new entItemsCategories();

        #endregion

        #region Overrided Methods

        protected override int InsertData()
        {
            try
            {
                base.InsertData();
                return mngrItemsCategories.Insert(Crrnt);
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
                return mngrItemsCategories.Update(Crrnt);
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
                int iDeleteRes = mngrItemsCategories.Delete(iRecordID);
                LoadItemsCategories();
                return iDeleteRes;
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
                    Crrnt = new entItemsCategories(iRecordID);
                    txtName.Text = Crrnt.Name;
                    tvCategories.SelectedNode = TreeManager.SearchNodes(tvCategories.Nodes, Crrnt.ID);
                    if (Crrnt.ParentID > 0)
                        tvcmbParentCategory.SelectedValue = Crrnt.ParentID;
                    else
                        tvcmbParentCategory.SelectedValue = null;
                    dgvItems.DataSource = mngrItems.GetItemsByCategoryID(iRecordID);
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
                if (Helper.CheckNumberInt(tvcmbParentCategory.SelectedValue))
                    Crrnt.ParentID = Convert.ToInt32(tvcmbParentCategory.SelectedValue);
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
                    return Res || txtName.Text.Length > 0 || (tvcmbParentCategory.SelectedValue != null && tvcmbParentCategory.SelectedValue.ToString() != "System.Object");
                else
                {
                    GetObject();
                    return Crrnt != new entItemsCategories(iRecordID);
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
                txtName.Focus();
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }
        protected override void ReInitialize()
        {
            base.ReInitialize();
            Crrnt = new entItemsCategories();
        }
        protected override bool ValidateForm()
        {
            try
            {
                bool Res = base.ValidateForm();
                if (RecordsFunctions.IsDataExists(strTableName, "Name", txtName.Text, iRecordID))
                {
                    errprvForm.SetError(txtName, Resources.ProgramMessages.ErrMessExistNameAr);
                    return false;
                }
                return Res;
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
                return false;
            }
        }
        protected override void Save()
        {
            base.Save();
            LoadItemsCategories();
        }

        #endregion

        #region Methods

        void LoadItemsCategories()
        {
            try
            {
                DataTable tblItemsCategories = mngrItemsCategories.GetItemsCategories();
                TreeManager.CreateTreeInRecursiveTable(tvCategories, tblItemsCategories, "ID", "Name", "ParentID", 0, 1);

                tvcmbParentCategory.DataSources = new DataTable[] { tblItemsCategories };
                tvcmbParentCategory.DisplayMembers = new string[] { "Name" };
                tvcmbParentCategory.PrimaryKeyMemebers = new string[] { "ID" };
                tvcmbParentCategory.RelationMembers = new string[] { "ParentID" };
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }

        #endregion

        #region Event Handlers

        private void frmItemsCategories_Load(object sender, EventArgs e)
        {
            try
            {
                LoadItemsCategories();
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }
        private void tvCategories_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                if (tvCategories.SelectedNode != null && Helper.CheckNumberInt(tvCategories.SelectedNode.Tag))
                    ChangeCurrentID(Convert.ToInt32(tvCategories.SelectedNode.Tag));
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
                {
                    frmItems frmItms = new frmItems();
                    frmItms.iRecordID = Convert.ToInt32(dgvItems["ID", dgvItems.CurrentRow.Index].Value);
                    frmItms.frmstsStatus = SystemClasses.Enumerations.FormStatus.Update;
                    frmItms.ShowDialog(this);
                    DisplayObject();
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }
        private void tvcmbParentCategory_AfterSelect(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }

        #endregion

    }
}
