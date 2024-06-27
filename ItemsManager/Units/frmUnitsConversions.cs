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
    public partial class frmUnitsConversions : ItemsManager.BaseForms.frmActionBase
    {

        #region Constructor

        public frmUnitsConversions()
        {
            strTableName = "UnitsConversions";
            InitializeComponent();
        }

        #endregion

        #region Members

        entUnitsConversions Crrnt = new entUnitsConversions();

        #endregion

        #region Overrided Methods

        protected override int InsertData()
        {
            try
            {
                base.InsertData();
                return mngrUnitsConversions.Insert(Crrnt);
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
                return mngrUnitsConversions.Update(Crrnt);
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
                return mngrUnitsConversions.Delete(iRecordID);
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
                    Crrnt = new entUnitsConversions(iRecordID);
                    cmbFromUnitID.SelectedValue = Crrnt.FromUnitID;
                    cmbToUnitID.SelectedValue = Crrnt.ToUnitID;
                    txtnQuantity.Text = Crrnt.Quantity.ToString("0.000");
                    if (iRecordID < 4)
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
            bool Res = base.IsFormModified();
            if (frmstsStatus == SystemClasses.Enumerations.FormStatus.New)
                return Res || txtnQuantity.Text.Length > 0 || cmbToUnitID.SelectedIndex >= 0 || cmbFromUnitID.SelectedIndex >= 0;
            else
            {
                GetObject();
                return Crrnt != new entUnitsConversions(iRecordID);
            }
        }
        protected override void SetFocus()
        {
            try
            {
                base.SetFocus();
                cmbFromUnitID.Focus();
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }
        protected override void ReInitialize()
        {
            base.ReInitialize();
            Crrnt = new entUnitsConversions();
        }
        protected override bool ValidateForm()
        {
            try
            {
                bool Res = base.ValidateForm();
                if (RecordsFunctions.IsDataExists(strTableName, "FromUnitID", cmbFromUnitID.SelectedValue.ToString(), iRecordID,
                    "ToUnitID = " + cmbToUnitID.SelectedValue.ToString()))
                {
                    errprvForm.SetError(cmbFromUnitID, Resources.ProgramMessages.ErrMesUnitConversionEntered);
                    errprvForm.SetError(cmbToUnitID, Resources.ProgramMessages.ErrMesUnitConversionEntered);
                    Res = false;
                }
                if (cmbFromUnitID.SelectedValue == cmbToUnitID.SelectedValue)
                {
                    errprvForm.SetError(cmbFromUnitID, Resources.ProgramMessages.ErrMesToAndFromUnitsEqual);
                    errprvForm.SetError(cmbToUnitID, Resources.ProgramMessages.ErrMesToAndFromUnitsEqual);
                    Res = false;
                }
                if (!Helper.CheckNumberDouble(txtnQuantity.Text.Trim()) || Convert.ToDecimal(txtnQuantity.Text.Trim()) <= 0m)
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

        #endregion

        #region Methods

        void LoadUnits()
        {
            try
            {
                cmbFromUnitID.DataSource = mngrUnits.GetUnits();
                cmbFromUnitID.DisplayMember = "Name";
                cmbFromUnitID.ValueMember = "ID";
                cmbFromUnitID.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }

        #endregion

        #region Event Handlers

        private void frmUnitsConversions_Load(object sender, EventArgs e)
        {
            try
            {
                LoadUnits();
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }
        private void cmbFromUnitID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbFromUnitID.SelectedIndex >= 0 && cmbToUnitID.SelectedIndex >= 0 && txtnQuantity.Text.Trim().Length > 0)
                    lblConversionExample.Text = "1 " + cmbFromUnitID.Text + " = " + txtnQuantity.Text + " " + cmbToUnitID.Text;
                if (sender is ComboBox)
                {
                    ComboBox cmbSender = ((ComboBox)sender);
                    if (cmbSender.Name == "cmbFromUnitID" && Helper.CheckNumberInt(cmbSender.SelectedValue))
                    {
                        entUnits entUnt = new entUnits(Convert.ToInt32(cmbSender.SelectedValue));
                        cmbToUnitID.DataSource = mngrUnits.GetTypeUnits(entUnt.TypeID);
                        cmbToUnitID.DisplayMember = "Name";
                        cmbToUnitID.ValueMember = "ID";
                    }
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
