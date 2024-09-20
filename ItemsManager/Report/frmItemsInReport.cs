using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Utilities;
using Managers;
using ItemsManager.DevExpressReports;

namespace ItemsManager.Report
{
    public partial class frmItemsInReport : ItemsManager.BaseForms.frmBase
    {

        #region Constructor

        public frmItemsInReport()
        {
            InitializeComponent();
        }

        #endregion

        #region Members

        bool bIsSuppliersTypesLoaded = false, bIsSuppliersLoaded = false;

        #endregion

        #region Overrided Methods

        protected override bool ValidateForm()
        {
            bool bResult = base.ValidateForm();
            if (chkbxFilterBySupplier.Checked && cbxSupplier.SelectedIndex < 0)
            {
                errprvForm.SetError(cbxSupplier, Resources.ProgramMessages.MesRequiredField);
                bResult = false;
            }
            if (chkbxFilterBySupplierType.Checked && cbxSupplierType.SelectedIndex < 0)
            {
                errprvForm.SetError(cbxSupplierType, Resources.ProgramMessages.MesRequiredField);
                bResult = false;
            }
            if (chkbxFilterByItemsInID.Checked && tbxnItemsInIDFrom.Text.Trim().Length == 0 && tbxnItemsInIDTo.Text.Trim().Length == 0)
            {
                errprvForm.SetError(tbxnItemsInIDFrom, Resources.ProgramMessages.MesRequiredField);
                errprvForm.SetError(tbxnItemsInIDTo, Resources.ProgramMessages.MesRequiredField);
                bResult = false;
            }
            return bResult;
        }

        #endregion

        #region Event Handlers

        private void frmItemsInReport_Load(object sender, EventArgs e)
        {

        }
        private void chkbxFilterByItemsInID_CheckedChanged(object sender, EventArgs e)
        {
            pnlItemsInFilterContorls.Visible = chkbxFilterByItemsInID.Checked;
        }
        private void chkbxFilterBySupplierType_CheckedChanged(object sender, EventArgs e)
        {
            pnlSupplierTypeFilterControls.Visible = chkbxFilterBySupplierType.Checked;
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                if (!bIsSuppliersTypesLoaded)
                {
                    bIsSuppliersTypesLoaded = true;
                    cbxSupplierType.DataSource = mngrSuppliersTypes.GetSuppliersTypes();
                    cbxSupplierType.DisplayMember = "Name";
                    cbxSupplierType.ValueMember = "ID";
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
        private void chkbxFilterBySupplier_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                pnlFilterBySupplierControls.Visible = chkbxFilterBySupplier.Checked;
                Cursor.Current = Cursors.WaitCursor;
                if (!bIsSuppliersLoaded)
                {
                    bIsSuppliersLoaded = true;
                    cbxSupplier.DataSource = mngrSuppliers.GetSuppliersByIsSupplier(true);
                    cbxSupplier.DisplayMember = "Name";
                    cbxSupplier.ValueMember = "ID";
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
        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                int iItemsInIDFrom = 0, iItemsInIDTo = 0, iSupplierTypeID = 0, iSupplierID = 0;
                if (ValidateForm())
                {
                    if (Helper.CheckNumberInt(tbxnItemsInIDFrom.Text))
                        iItemsInIDFrom = Convert.ToInt32(tbxnItemsInIDFrom.Text);
                    if (Helper.CheckNumberInt(tbxnItemsInIDTo.Text))
                        iItemsInIDTo = Convert.ToInt32(tbxnItemsInIDTo.Text);
                    if (Helper.CheckNumberInt(cbxSupplierType.SelectedValue))
                        iSupplierTypeID = Convert.ToInt32(cbxSupplierType.SelectedValue);
                    if (Helper.CheckNumberInt(cbxSupplier.SelectedValue))
                        iSupplierID = Convert.ToInt32(cbxSupplier.SelectedValue);
                    string strReportFileName = @"Report\ItemsInTotal.repx";
                    if (rdbtnDetails.Checked)
                        strReportFileName = @"Report\ItemsInWithDetails.repx";
                    DevExpress.XtraReports.UI.XtraReport rptInvoices = new DevExpress.XtraReports.UI.XtraReport();
                    rptInvoices.LoadLayout(strReportFileName);
                    DataTable tblReportSource = mngrItemsInHead.GetItemsInReport(dtpDateFrom.Value, dtpDateTo.Value, iItemsInIDFrom, iItemsInIDTo, iSupplierTypeID, iSupplierID, rdbtnDetails.Checked);
                    tblReportSource.TableName = "ReportSource";
                    rptInvoices.DataSource = tblReportSource;
                    rptInvoices.DataMember = tblReportSource.TableName;
                    frmDisplayReport frmDspRprt = new frmDisplayReport() { ReportDocumnet = rptInvoices };
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
