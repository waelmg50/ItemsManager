using ItemsManager.DevExpressReports;
using Managers;
using System;
using System.Data;
using System.Windows.Forms;
using Utilities;

namespace ItemsManager.Report
{
    public partial class frmExpencesReport : BaseForms.frmBase
    {

        #region Constructor

        public frmExpencesReport()
        {
            InitializeComponent();
        }

        #endregion

        #region Events Handlers

        private void chkbxFilterByExpenseType_CheckedChanged(object sender, EventArgs e)
        {
            pnlExpenseTypeFilterControls.Visible = chkbxFilterByExpenseType.Checked;
            if (!chkbxFilterByExpenseType.Checked)
                cbxExpenseType.SelectedIndex = -1;
        }
        private void chkbxFilterByStatement_CheckedChanged(object sender, EventArgs e)
        {
            pnlFilterByStatementControls.Visible = chkbxFilterByStatement.Checked;
            if (!chkbxFilterByStatement.Checked)
                tbxStatement.Text = string.Empty;
        }
        private void chkbxFilterByRemarks_CheckedChanged(object sender, EventArgs e)
        {
            pnlFilterByRemarksControls.Visible = chkbxFilterByRemarks.Checked;
            if (!chkbxFilterByRemarks.Checked)
                tbxRemarks.Text = string.Empty;
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                int iExpenseType = 0;
                if (ValidateForm())
                {
                    if (Helper.CheckNumberInt(cbxExpenseType.SelectedValue))
                        iExpenseType = Convert.ToInt32(cbxExpenseType.SelectedValue);
                    string strReportFileName = $@"{Application.StartupPath}\Report\Expenses.repx";
                    DevExpress.XtraReports.UI.XtraReport rptExpenses = new DevExpress.XtraReports.UI.XtraReport();
                    rptExpenses.LoadLayout(strReportFileName);
                    DataTable tblReportSource = mngrExpenses.GetExpencesReport(dtpDateFrom.Value, dtpDateTo.Value, iExpenseType, tbxStatement.Text, tbxRemarks.Text);
                    tblReportSource.TableName = "ReportSource";
                    rptExpenses.DataSource = tblReportSource;
                    rptExpenses.DataMember = tblReportSource.TableName;
                    frmDisplayReport frmDspRprt = new frmDisplayReport() { ReportDocumnet = rptExpenses };
                    frmDspRprt.ShowDialog(this);
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

        #endregion

    }
}
