using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Utilities;
using Managers;

namespace ItemsManager.Shifts
{
    public partial class frmShiftDetails : ItemsManager.BaseForms.frmActionBase
    {

        #region Constructor

        public frmShiftDetails()
        {
            strTableName = "vwShiftsData";
            bhideDatabaseOperationButtons = true;
            iRecordID = UserLogin.CurrentShiftID;
            frmstsStatus = SystemClasses.Enumerations.FormStatus.Update;
            InitializeComponent();
        }

        #endregion

        #region Overrided Methods

        protected override void DisplayObject()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                base.DisplayObject();
                dgvExpenses.DataSource = mngrShifts.GetShiftExpenses(iRecordID);
                dgvInvoices.DataSource = mngrShifts.GetShiftInvoices(iRecordID);
                dgvItemsIn.DataSource = mngrShifts.GetShiftItemsIn(iRecordID);
                dgvStocktaking.DataSource = mngrShifts.GetShiftStocktaking(iRecordID);
                DataTable tblShiftData = mngrShifts.GetShiftWithExternalData(iRecordID);
                if (tblShiftData.Rows.Count > 0)
                {
                    lblBeginDateValue.Text = Convert.ToDateTime(tblShiftData.Rows[0]["DateIn"]).ToString("dd/MM/yyyy");
                    lblBeginTimeValue.Text = Convert.ToDateTime(tblShiftData.Rows[0]["DateIn"]).ToString("hh:mm:ss tt");
                    if (Helper.CheckNumberDouble(tblShiftData.Rows[0]["TotalInvoices"]))
                        lblTotalInvoicesValue.Text = Convert.ToDecimal(tblShiftData.Rows[0]["TotalInvoices"]).ToString("0.00");
                    else
                        lblTotalInvoicesValue.Text = "0";
                    if (Helper.CheckNumberDouble(tblShiftData.Rows[0]["TotalExpenses"]))
                        lblExpensesValue.Text = Convert.ToDecimal(tblShiftData.Rows[0]["TotalExpenses"]).ToString("0.00");
                    else
                        lblExpensesValue.Text = "0";
                    decimal dBoxValue = Convert.ToDecimal(lblTotalInvoicesValue.Text) - Convert.ToDecimal(lblExpensesValue.Text);
                    lblBoxValue.Text = dBoxValue.ToString("0.00");
                    lblCashInValue.Text = Convert.ToDecimal(tblShiftData.Rows[0]["CashIn"]).ToString("0.00");
                    bool bIsFinished = Convert.ToBoolean(tblShiftData.Rows[0]["Finished"]);
                    if (bIsFinished)
                        lblCashOutValue.Text = Convert.ToDecimal(tblShiftData.Rows[0]["CashOut"]).ToString("0.00");
                    else
                        lblCashOutValue.Text = "0";
                    if (bIsFinished)
                    {
                        lblEndDateValue.Text = Convert.ToDateTime(tblShiftData.Rows[0]["DateOut"]).ToString("dd/MM/yyyy");
                        lblEndTimeValue.Text = Convert.ToDateTime(tblShiftData.Rows[0]["DateOut"]).ToString("hh:mm:ss tt");
                    }
                    else
                        lblEndDateValue.Text = lblEndTimeValue.Text = Resources.ProgramMessages.MesShiftContinous;
                    if (bIsFinished)
                        lblLackValue.Text = (Convert.ToDecimal(lblCashOutValue.Text) - Convert.ToDecimal(lblBoxValue.Text)).ToString("0.00");
                    else
                        lblLackValue.Text = "0";
                    if (bIsFinished)
                    {
                        int iShiftMinutes = Convert.ToInt32(tblShiftData.Rows[0]["TimeConsumed"]);
                        lblShiftPeriodValue.Text = (iShiftMinutes / 60).ToString("00") + " : " + (iShiftMinutes % 60).ToString("00");
                    }
                    else
                        lblShiftPeriodValue.Text = Resources.ProgramMessages.MesShiftContinous;
                    if (bIsFinished)
                        lblShiftStatusValue.Text = Resources.ProgramMessages.MesShiftEnded;
                    else
                        lblShiftPeriodValue.Text = Resources.ProgramMessages.MesShiftContinous;
                    lblUserInName.Text = RecordsFunctions.GetNameUsingID("Users", "FullName", Convert.ToInt32(tblShiftData.Rows[0]["UserInID"]));
                    if(bIsFinished)
                        lblUserOutName.Text = RecordsFunctions.GetNameUsingID("Users", "FullName", Convert.ToInt32(tblShiftData.Rows[0]["UserOutID"]));
                    else
                        lblUserOutName.Text = Resources.ProgramMessages.MesShiftContinous;
                }
                else
                {

                    lblBoxValue.Text = lblCashInValue.Text = lblCashOutValue.Text = lblExpensesValue.Text = lblLackValue.Text = lblShiftPeriodValue.Text =
                        lblTotalInvoicesValue.Text = "0";
                    lblUserInName.Text = lblShiftStatusValue.Text = lblEndDateValue.Text = lblEndTimeValue.Text = lblBeginDateValue.Text
                        = lblBeginTimeValue.Text = lblUserOutName.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
        protected override void Print()
        {
            base.Print();

        }

        #endregion

        #region Event Handlers

        private void dgvOperation_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (sender is DataGridView)
                {
                    DataGridView dgvSender = (DataGridView)sender;
                    if (dgvSender.CurrentRow != null && Helper.CheckNumberInt(dgvSender.CurrentRow.Cells[0].Value))
                    {
                        int iOperationID = Convert.ToInt32(dgvSender.CurrentRow.Cells[0].Value);
                        if (iOperationID > 0)
                        {
                            BaseForms.frmActionBase frmOperation = new BaseForms.frmActionBase();
                            switch (dgvSender.Name)
                            {
                                case "dgvItemsIn":
                                    frmOperation = new Items.frmItemsIn();
                                    break;
                                case "dgvInvoices":
                                    frmOperation = new Invoice.frmInvoices();
                                    break;
                                case "dgvStocktaking":
                                    frmOperation = new Stocktaking.frmStocktaking();
                                    break;
                                case "dgvExpenses":
                                    frmOperation = new Expenses.frmExpenses();
                                    ((Expenses.frmExpenses)frmOperation).iShiftID = iRecordID;
                                    break;
                                default:
                                    return;
                            }
                            frmOperation.iRecordID = iOperationID;
                            frmOperation.frmstsStatus = SystemClasses.Enumerations.FormStatus.Update;
                            frmOperation.ShowDialog(this);
                        }
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
