using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.UserDesigner;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using Utilities;

namespace ItemsManager.DevExpressReports
{
    public partial class frmDesignReports : ItemsManager.BaseForms.frmBase
    {
        public frmDesignReports()
        {
            InitializeComponent();
        }
        void FillListBox()
        {
            lstbxReports.Items.Clear();
            string[] urls = Program.ReportStorage.GetStandardUrls(null);
            foreach (string url in urls)
                lstbxReports.Items.Add(url);
        }
        
        private void frmDesignReports_Load(object sender, EventArgs e)
        {
            FillListBox();
        }


        private void btnClearSelection_Click(object sender, EventArgs e)
        {
            lstbxReports.SelectedIndex = -1;
        }

        private void btnDesignReport_Click(object sender, EventArgs e)
        {
            try
            {
                XRDesignRibbonForm frmDesignReport = new XRDesignRibbonForm();
                string strSelectedReport = lstbxReports.SelectedItem as string;
                if (lstbxReports.SelectedIndex >= 0)
                    frmDesignReport.OpenReport(strSelectedReport);
                frmDesignReport.ShowDialog(this);
                FillListBox();
                if (!string.IsNullOrWhiteSpace(strSelectedReport) && lstbxReports.Items.Contains(strSelectedReport))
                    lstbxReports.SelectedItem = strSelectedReport;
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }

        private void btnPreviewReport_Click(object sender, EventArgs e)
        {
            try
            {
                string strSelectedReport = lstbxReports.SelectedItem as string;
                if (!string.IsNullOrWhiteSpace(strSelectedReport) && lstbxReports.SelectedIndex >= 0)
                {
                    using (MemoryStream msReport = new MemoryStream(Program.ReportStorage.GetData(strSelectedReport)))
                    {
                        XtraReport report = XtraReport.FromStream(msReport, true);
                        if (report != null)
                            report.ShowRibbonPreviewDialog();
                    }
                }
                else
                    Helper.ShowMessage("Select Report first");
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }
    }
}
