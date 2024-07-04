using System;
using System.Web.UI.WebControls;
using System.Windows.Forms;
// ...

namespace ReportStorageSample {
    public partial class StorageEditorForm : Form {
        public StorageEditorForm() {
            InitializeComponent();
        }

        

        private void StorageEditorForm_Load(object sender, EventArgs e) {
            if (lstbxReports.Items.Count > 0 && string.IsNullOrEmpty(txtReportName.Text))
                lstbxReports.SelectedIndex = 0;
        }

        

        private void buttonOK_Click(object sender, EventArgs e) {

        }

        private void txtReportName_TextChanged(object sender, EventArgs e)
        {
            if (lstbxReports.Items.Count > 0 && string.IsNullOrEmpty(txtReportName.Text))
                lstbxReports.SelectedIndex = 0;
        }

        private void lstbxReports_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtReportName.Text = lstbxReports.SelectedItem.ToString();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
