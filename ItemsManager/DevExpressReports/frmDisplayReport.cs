using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ItemsManager.DevExpressReports
{
    public partial class frmDisplayReport : ItemsManager.BaseForms.frmBase
    {
        public frmDisplayReport()
        {
            InitializeComponent();
        }
        public object ReportDocumnet
        {
            get
            {
                return docvwrDisplayReport.DocumentSource;
            }
            set
            {
                docvwrDisplayReport.DocumentSource = value;
            }
        }
    }
}
