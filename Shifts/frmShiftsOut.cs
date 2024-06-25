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
    public partial class frmShiftsOut : ItemsManager.BaseForms.frmBase
    {

        #region Constructor

        public frmShiftsOut()
        {
            InitializeComponent();
        }

        #endregion

        #region Overrided Methods

        protected override bool ValidateForm()
        {
            bool bRes = base.ValidateForm();
            if (Helper.CheckNumberDouble(txtnCashOut.Text) && Convert.ToDecimal(txtnCashOut.Text) < 0m)
            {
                errprvForm.SetError(txtnCashOut, Resources.ProgramMessages.ErrMesInvalidNumber);
                bRes = false;
            }
            return bRes;
        }

        #endregion

        #region Event Handlers

        private void tmrTime_Tick(object sender, EventArgs e)
        {
            try
            {
                dtpDateOut.Value = DateTime.Now;
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }
        private void btnCloseShift_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateForm())
                {
                    entShifts entCurrentShift = new entShifts(mngrShifts.GetCurrentShiftID());
                    entCurrentShift.CashOut = Convert.ToDecimal(txtnCashOut.Text);
                    entCurrentShift.UserOutID = UserLogin.LoggedUserID;
                    entCurrentShift.DateOut = dtpDateOut.Value;
                    mngrShifts.Update(entCurrentShift);
                    Helper.ShowMessage(Resources.ProgramMessages.ErrMesShiftClosed);
                    Application.Exit();
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
