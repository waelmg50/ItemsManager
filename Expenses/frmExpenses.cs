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

namespace ItemsManager.Expenses
{
    public partial class frmExpenses : ItemsManager.BaseForms.frmActionBase
    {

        #region Constructor

        public frmExpenses()
        {
            strTableName = "Expenses";
            InitializeComponent();
        }

        #endregion

        #region Members

        entExpenses Crrnt = new entExpenses();
        public int iShiftID = UserLogin.CurrentShiftID;

        #endregion

        #region Overrided Methods

        protected override int InsertData()
        {
            try
            {
                base.InsertData();
                return mngrExpenses.Insert(Crrnt);
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
                return mngrExpenses.Update(Crrnt);
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
                return mngrExpenses.Delete(iRecordID);
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
                    Crrnt = new entExpenses(iRecordID);
                    txtStatement.Text = Crrnt.Statement;
                    cmbTypeID.SelectedValue = Crrnt.TypeID;
                    txtnValue.Text = Crrnt.Value.ToString("0.00");
                    txtRemarks.Text = Crrnt.Remarks;
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
                Crrnt.Statement = txtStatement.Text;
                Crrnt.TypeID = Helper.CheckNumberInt(cmbTypeID.SelectedValue) ? Convert.ToInt32(cmbTypeID.SelectedValue) : 0;
                Crrnt.Value = Helper.CheckNumberDouble(txtnValue.Text) ? Convert.ToDecimal(txtnValue.Text) : 0m;
                Crrnt.Remarks = txtRemarks.Text;
                Crrnt.ShiftID = iShiftID;
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
                return Res || txtStatement.Text.Length > 0 || cmbTypeID.SelectedValue != null || txtnValue.Text.Length > 0 || txtRemarks.Text.Length > 0;
            else
            {
                GetObject();
                return Crrnt != new entExpenses(iRecordID);
            }
        }
        protected override void SetFocus()
        {
            try
            {
                base.SetFocus();
                txtStatement.Focus();
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }
        protected override void ReInitialize()
        {
            base.ReInitialize();
            Crrnt = new entExpenses();
        }
        protected override void LoadInitialControls()
        {
            try
            {
                base.LoadInitialControls();
                cmbTypeID.DataSource = mngrExpensesTypes.GetExpensesTypes();
                cmbTypeID.DisplayMember = "Name";
                cmbTypeID.ValueMember = "ID";
                cmbTypeID.SelectedIndex = -1;
                if (cmbTypeID.Items.Count == 0)
                {
                    Helper.ShowMessage(Resources.ProgramMessages.MesInsertExpencesTypes);
                    Close();
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }

        #endregion

        #region Event Handlers

        private void frmExpenses_Load(object sender, EventArgs e)
        {
            try
            {
                Text += " - " + Resources.ProgramMessages.MesShifNo + " [" + iShiftID.ToString() + "]";
                strCondtion = "ShiftID = " + iShiftID.ToString();
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }

        #endregion

    }
}
