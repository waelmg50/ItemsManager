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

namespace ItemsManager.Shifts
{
    public partial class frmShiftIn : ItemsManager.BaseForms.frmBase
    {

        #region Constructor

        public frmShiftIn()
        {
            InitializeComponent();
        }

        #endregion

        #region Overrided Methods

        protected override bool ValidateForm()
        {
            bool bRes = base.ValidateForm();
            if (Helper.CheckNumberDouble(txtnCashIn.Text) && Convert.ToDecimal(txtnCashIn.Text) < 0m)
            {
                errprvForm.SetError(txtnCashIn, Resources.ProgramMessages.ErrMesInvalidNumber);
                bRes = false;
            }
            return bRes;
        }

        #endregion

        #region EventHandlers

        private void tmrTime_Tick(object sender, EventArgs e)
        {
            try
            {
                dtpDateIn.Value = DateTime.Now;
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (UserLogin.CheckUser(txtUserName.Text, txtPassword.Text))
                {
                    if (ValidateForm())
                    {
                        entShifts entShft = new entShifts();
                        entShft.CashIn = Convert.ToDecimal(txtnCashIn.Text);
                        entShft.DateIn = dtpDateIn.Value;
                        entShft.UserInID = UserLogin.LoggedUserID;
                        UserLogin.CurrentShiftID = mngrShifts.Insert(entShft);
                        Close();
                    }
                }
                else
                    Helper.ShowMessage(Resources.ProgramMessages.MesInvalidLogin);
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }
        private void frmShiftIn_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                if (UserLogin.CurrentShiftID <= 0)
                    Application.Exit();
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }

        #endregion

    }
}