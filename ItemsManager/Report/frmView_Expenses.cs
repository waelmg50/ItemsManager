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
using System.Data.SqlClient;
using ItemsManager.Report;

namespace ItemsManager.Report
{
    public partial class frmView_Expenses : BaseForms.frmBase
    {

        #region Constructor

        public frmView_Expenses()
        {
            InitializeComponent();
        }

        #endregion

        #region Event Handlers

        private void frmView_Expenses_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = mngrExpenses.GetView_Expenses1(UserLogin.CurrentShiftID);
                cmbtype.DataSource = mngrExpensesTypes.GetExpensesTypes();
                cmbtype.DisplayMember = "Name";
                cmbtype.ValueMember = "ID";
                cmbtype.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }
        private void cmbtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (Helper.CheckNumberInt(cmbtype.SelectedValue))
                {
                    dataGridView1.DataSource = mngrExpenses.GetView_Expenses(Convert.ToInt32(cmbtype.SelectedValue), UserLogin.CurrentShiftID);
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //ReportDocument Expenses = new ReportDocument();
                //Expenses.Load(@"Report\ReportsFiles\rptExpenses.rpt");
                //if (dataGridView1.DataSource is DataTable && dataGridView1.RowCount > 0)
                //    Expenses.SetDataSource((DataTable)dataGridView1.DataSource);
                //else
                //{
                //    Helper.ShowMessage(Resources.ProgramMessages.MesNoDataToDisplay);
                //    return;
                //}
                //frmPrintInfo info = new frmPrintInfo();
                //info.crvReport.ReportSource = Expenses;
                //info.Show();
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }            
        }
        private void btnExpensesTypes_Click(object sender, EventArgs e)
        {
            try
            {
                //ReportDocument Expenses = new ReportDocument();
                //Expenses.Load(@"Report\ReportsFiles\rptExpensesByType.rpt");
                //if (dataGridView1.DataSource is DataTable && dataGridView1.RowCount > 0)
                //    Expenses.SetDataSource((DataTable)dataGridView1.DataSource);
                //else
                //{
                //    Helper.ShowMessage(Resources.ProgramMessages.MesNoDataToDisplay);
                //    return;
                //}
                //frmPrintInfo info = new frmPrintInfo();
                //info.crvReport.ReportSource = Expenses;
                //info.Show();
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }

        #endregion

    }
}
