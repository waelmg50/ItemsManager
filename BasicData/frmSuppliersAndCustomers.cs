using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Managers;
using Entities;
using Utilities;

namespace ItemsManager.BasicData
{
    public partial class frmSuppliersAndCustomers : BaseForms.frmActionBase
    {

        #region Constructor

        public frmSuppliersAndCustomers()
        {
            InitializeComponent();
            strTableName = "Suppliers";
        }

        #endregion

        #region Members

        entSuppliers entCurrent = new entSuppliers();

        #endregion

        #region Overrided Methods

        protected override int InsertData()
        {
            try
            {
                base.InsertData();
                return mngrSuppliers.Insert(entCurrent);
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
                return mngrSuppliers.Update(entCurrent);
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
                return mngrSuppliersTypes.Delete(iRecordID);
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
                    entCurrent = new entSuppliers(iRecordID);
                    tbxName.Text = entCurrent.Name;
                    tbxAddress.Text = entCurrent.Address;
                    cbxType.SelectedValue = entCurrent.TypeID;
                    chkbxIsSupplier.Checked = entCurrent.IsSupplier;
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
                    entCurrent.ID = iRecordID;
                entCurrent.Name = tbxName.Text;
                entCurrent.Address = tbxAddress.Text;
                entCurrent.TypeID = Convert.ToInt32(cbxType.SelectedValue);
                entCurrent.IsSupplier = chkbxIsSupplier.Checked;
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }
        protected override bool IsFormModified()
        {
            bool bResult = base.IsFormModified();
            if (frmstsStatus == SystemClasses.Enumerations.FormStatus.New)
                return bResult || tbxName.Text.Length > 0 || cbxType.SelectedIndex > -1 || tbxAddress.Text.Length > 0 || chkbxIsSupplier.Checked;
            else
            {
                GetObject();
                return entCurrent != new entSuppliers(iRecordID);
            }
        }
        protected override void SetFocus()
        {
            try
            {
                base.SetFocus();
                tbxName.Focus();
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }
        protected override void ReInitialize()
        {
            base.ReInitialize();
            entCurrent = new entSuppliers();
        }
        protected override bool ValidateForm()
        {
            try
            {
                bool bResult = base.ValidateForm();
                if (RecordsFunctions.IsDataExists(strTableName, "Name", tbxName.Text, iRecordID))
                {
                    errprvForm.SetError(tbxName, Resources.ProgramMessages.ErrMessExistNameAr);
                    return false;
                }
                return bResult;
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
                return false;
            }
        }

        #endregion

        #region Event Handlers

        private void frmSuppliersAndCustomers_Load(object sender, EventArgs e)
        {
            cbxType.DataSource = mngrSuppliersTypes.GetSuppliersTypes();
            cbxType.DisplayMember = "Name";
            cbxType.ValueMember = "ID";
        }

        #endregion

    }
}
