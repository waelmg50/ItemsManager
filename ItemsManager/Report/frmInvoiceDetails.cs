using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Utilities;
using Entities;
using Managers;
using System.Data.SqlClient;
using ItemsManager.Report;

namespace ItemsManager.Report
{
    public partial class frmInvoiceDetails : BaseForms.frmBase
    {

        #region Constructor

        public frmInvoiceDetails()
        {
            InitializeComponent();
        }

        #endregion

        #region Events

        private void frmInvoiceDetails_Load(object sender, EventArgs e)
        {
            try
            {
                dgvData.DataSource = mngrInvoiceDetails.GetInvoiceDetails1();
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }
        private void btngeneral_Click(object sender, EventArgs e)
        {
            try
            {
                dgvData.DataSource = mngrInvoiceDetails.GetInvoiceDetails1();
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
                if (Helper.CheckNumberInt(txtInvoiceHeadID.Text))
                {
                    dgvData.DataSource = mngrInvoiceDetails.GetView_InvoiceDetails1byInvoiceHeadID(Convert.ToInt32(txtInvoiceHeadID.Text));
                    mngrInvoiceDetails.GetView_InvoiceDetails1byInvoiceHeadID(Convert.ToInt32(txtInvoiceHeadID.Text));
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }
        private void btnrptInvoiceHeadID_Click(object sender, EventArgs e)
        {
            try
            {
                if (Helper.CheckNumberInt(txtInvoiceHeadID.Text))
                {
                    //ReportDocument InvoiceDetails1byInvoiceHeadID = new ReportDocument();
                    //InvoiceDetails1byInvoiceHeadID.Load(@"Report\ReportsFiles\rptInvoiceDetails1byInvoiceHeadID.rpt");
                    //InvoiceDetails1byInvoiceHeadID.SetDataSource(mngrInvoiceDetails.GetView_InvoiceDetails1byInvoiceHeadID(
                    //    Convert.ToInt32(txtInvoiceHeadID.Text)));
                    //frmPrintInfo info = new frmPrintInfo();
                    //info.crvReport.ReportSource = InvoiceDetails1byInvoiceHeadID;
                    //info.Show();
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }
        private void btnrptgeneral_Click(object sender, EventArgs e)
        {
            try
            {
                //ReportDocument InvoiceDetails = new ReportDocument();
                //InvoiceDetails.Load(@"Report\ReportsFiles\rptInvoiceDetails.rpt");
                //if (dgvData.DataSource is DataTable && dgvData.RowCount > 0)
                //    InvoiceDetails.SetDataSource((DataTable)dgvData.DataSource);
                //else
                //{
                //    Helper.ShowMessage(Resources.ProgramMessages.MesNoDataToDisplay);
                //    return;
                //}
                //frmPrintInfo info = new frmPrintInfo();
                //info.crvReport.ReportSource = InvoiceDetails;
                //info.Show();
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }

        #endregion

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

    }
}
