namespace ItemsManager.DevExpressReports
{
    partial class frmDisplayReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.docvwrDisplayReport = new DevExpress.XtraPrinting.Preview.DocumentViewer();
            ((System.ComponentModel.ISupportInitialize)(this.errprvForm)).BeginInit();
            this.SuspendLayout();
            // 
            // docvwrDisplayReport
            // 
            this.docvwrDisplayReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.docvwrDisplayReport.IsMetric = false;
            this.docvwrDisplayReport.Location = new System.Drawing.Point(0, 0);
            this.docvwrDisplayReport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.docvwrDisplayReport.Name = "docvwrDisplayReport";
            this.docvwrDisplayReport.Size = new System.Drawing.Size(989, 635);
            this.docvwrDisplayReport.TabIndex = 0;
            // 
            // frmDisplayReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(989, 635);
            this.Controls.Add(this.docvwrDisplayReport);
            this.Name = "frmDisplayReport";
            this.Text = "مدير الأصناف - عرض التقرير";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.errprvForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraPrinting.Preview.DocumentViewer docvwrDisplayReport;
    }
}
