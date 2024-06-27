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

namespace ItemsManager.Units
{
    public partial class frmUnits : ItemsManager.BaseForms.frmActionBase
    {

        #region Constructor

        public frmUnits()
        {
            strTableName = "Units";
            InitializeComponent();
        }

        #endregion

        #region Members

        entUnits Crrnt = new entUnits();

        #endregion

        #region Overrided Methods

        protected override int InsertData()
        {
            try
            {
                base.InsertData();
                return mngrUnits.Insert(Crrnt);
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
                return mngrUnits.Update(Crrnt);
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
                return mngrUnits.Delete(iRecordID);
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
                    Crrnt = new entUnits(iRecordID);
                    txtName.Text = Crrnt.Name;
                    cmbTypeID.SelectedValue = Crrnt.TypeID;
                    if (iRecordID < 2)
                        pnlControls.Tag = 1;
                    else
                        pnlControls.Tag = null;
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
                Crrnt.TypeID = Convert.ToInt32(cmbTypeID.SelectedValue);
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }
        protected override bool IsFormModified()
        {
            bool Res = base.IsFormModified();
            if (frmstsStatus == SystemClasses.Enumerations.FormStatus.New)
                return Res || txtName.Text.Length > 0 || cmbTypeID.SelectedValue != null;
            else
            {
                GetObject();
                return Crrnt != new entUnits(iRecordID);
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
            Crrnt = new entUnits();
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

        #endregion

        #region Methods

        void LoadUnitTypes()
        {
            try
            {
                cmbTypeID.DataSource = mngrUnitsTypes.GetUnitsTypes();
                cmbTypeID.DisplayMember = "Name";
                cmbTypeID.ValueMember = "ID";
                cmbTypeID.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }

        #endregion

        #region Event Handlers

        private void frmUnits_Load(object sender, EventArgs e)
        {
            try
            {
                LoadUnitTypes();
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }

        #endregion

    }
}
