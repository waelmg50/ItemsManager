using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Utilities;
using Managers;

namespace ItemsManager.Report
{
    public partial class frmInvoicesReport : ItemsManager.BaseForms.frmBase
    {

        #region Constructor

        public frmInvoicesReport()
        {
            InitializeComponent();
        }

        #endregion

        #region Members

        bool bIsCustomersTypesLoaded = false, bIsCustomersLoaded = false;

        #endregion

        #region Overrided Methods

        protected override bool ValidateForm()
        {
            bool bResult = base.ValidateForm();
            if (chkbxFilterByCustomer.Checked && cbxCustomer.SelectedIndex < 0)
            {
                errprvForm.SetError(cbxCustomer, Resources.ProgramMessages.MesRequiredField);
                bResult = false;
            }
            if (chkbxFilterByCustomerType.Checked && cbxCustomerType.SelectedIndex < 0)
            {
                errprvForm.SetError(cbxCustomerType, Resources.ProgramMessages.MesRequiredField);
                bResult = false;
            }
            if (chkbxFilterByInvoiceID.Checked && tbxnInvoiceIDFrom.Text.Trim().Length == 0 && tbxnInvoiceIDTo.Text.Trim().Length == 0)
            {
                errprvForm.SetError(tbxnInvoiceIDFrom, Resources.ProgramMessages.MesRequiredField);
                errprvForm.SetError(tbxnInvoiceIDTo, Resources.ProgramMessages.MesRequiredField);
                bResult = false;
            }
            return bResult;
        }

        #endregion

        #region Event Handlers

        private void frmInvoicesReport_Load(object sender, EventArgs e)
        {

        }
        private void chkbxFilterByInvoiceID_CheckedChanged(object sender, EventArgs e)
        {
            pnlInvoiceFilterContorls.Visible = chkbxFilterByInvoiceID.Checked;
        }
        private void chkbxFilterByCustomerType_CheckedChanged(object sender, EventArgs e)
        {
            pnlCustomerTypeFilterControls.Visible = chkbxFilterByCustomerType.Checked;
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                if (!bIsCustomersTypesLoaded)
                {
                    bIsCustomersTypesLoaded = true;
                    cbxCustomerType.DataSource = mngrSuppliersTypes.GetSuppliersTypes();
                    cbxCustomerType.DisplayMember = "Name";
                    cbxCustomerType.ValueMember = "ID";
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
        private void chkbxFilterByCustomer_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                pnlFilterByCustomerControls.Visible = chkbxFilterByCustomer.Checked;
                Cursor.Current = Cursors.WaitCursor;
                if (!bIsCustomersLoaded)
                {
                    bIsCustomersLoaded = true;
                    cbxCustomer.DataSource = mngrSuppliers.GetSuppliersByIsSupplier(false);
                    cbxCustomer.DisplayMember = "Name";
                    cbxCustomer.ValueMember = "ID";
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
                int iInvoiceIDFrom = 0, iInvoiceIDTo = 0, iCustomerTypeID = 0, iCustomerID = 0;
                if (ValidateForm())
                {
                    if (Helper.CheckNumberInt(tbxnInvoiceIDFrom.Text))
                        iInvoiceIDFrom = Convert.ToInt32(tbxnInvoiceIDFrom.Text);
                    if (Helper.CheckNumberInt(tbxnInvoiceIDTo.Text))
                        iInvoiceIDTo = Convert.ToInt32(tbxnInvoiceIDTo.Text);
                    if (Helper.CheckNumberInt(cbxCustomerType.SelectedValue))
                        iCustomerTypeID = Convert.ToInt32(cbxCustomerType.SelectedValue);
                    if (Helper.CheckNumberInt(cbxCustomer.SelectedValue))
                        iCustomerID = Convert.ToInt32(cbxCustomer.SelectedValue);
                    string strReportFileName = @"Report\InvoiceTotal.rpt";
                    if (rdbtnDetails.Checked)
                        strReportFileName = @"Report\InvoiceWithDetails.rpt";
                    //ReportDocument rptInvoices = new ReportDocument();
                    //rptInvoices.Load(strReportFileName);
                    //rptInvoices.SetDataSource(mngrInvoiceHead.GetInvoicesReport(dtpDateFrom.Value, dtpDateTo.Value, iInvoiceIDFrom, iInvoiceIDTo,
                    //    iCustomerTypeID, iCustomerID, rdbtnDetails.Checked));
                    //frmPrintInfo frmPrint = new frmPrintInfo();
                    //frmPrint.crvReport.ReportSource = rptInvoices;
                    //frmPrint.ShowDialog(this);
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
