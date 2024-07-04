namespace ItemsManager.DevExpressReports
{
    partial class frmDesignReports
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
            this.lstbxReports = new System.Windows.Forms.ListBox();
            this.btnPreviewReport = new System.Windows.Forms.Button();
            this.btnClearSelection = new System.Windows.Forms.Button();
            this.btnDesignReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errprvForm)).BeginInit();
            this.SuspendLayout();
            // 
            // lstbxReports
            // 
            this.lstbxReports.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstbxReports.FormattingEnabled = true;
            this.lstbxReports.ItemHeight = 16;
            this.lstbxReports.Location = new System.Drawing.Point(29, 25);
            this.lstbxReports.Margin = new System.Windows.Forms.Padding(4);
            this.lstbxReports.Name = "lstbxReports";
            this.lstbxReports.Size = new System.Drawing.Size(1136, 628);
            this.lstbxReports.TabIndex = 2;
            // 
            // btnPreviewReport
            // 
            this.btnPreviewReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPreviewReport.Location = new System.Drawing.Point(536, 671);
            this.btnPreviewReport.Name = "btnPreviewReport";
            this.btnPreviewReport.Size = new System.Drawing.Size(149, 43);
            this.btnPreviewReport.TabIndex = 3;
            this.btnPreviewReport.Text = "Preview Report";
            this.btnPreviewReport.UseVisualStyleBackColor = true;
            this.btnPreviewReport.Click += new System.EventHandler(this.btnPreviewReport_Click);
            // 
            // btnClearSelection
            // 
            this.btnClearSelection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClearSelection.Location = new System.Drawing.Point(280, 671);
            this.btnClearSelection.Name = "btnClearSelection";
            this.btnClearSelection.Size = new System.Drawing.Size(149, 43);
            this.btnClearSelection.TabIndex = 3;
            this.btnClearSelection.Text = "Clear Selection";
            this.btnClearSelection.UseVisualStyleBackColor = true;
            this.btnClearSelection.Click += new System.EventHandler(this.btnClearSelection_Click);
            // 
            // btnDesignReport
            // 
            this.btnDesignReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDesignReport.Location = new System.Drawing.Point(781, 671);
            this.btnDesignReport.Name = "btnDesignReport";
            this.btnDesignReport.Size = new System.Drawing.Size(149, 43);
            this.btnDesignReport.TabIndex = 3;
            this.btnDesignReport.Text = "Design Report";
            this.btnDesignReport.UseVisualStyleBackColor = true;
            this.btnDesignReport.Click += new System.EventHandler(this.btnDesignReport_Click);
            // 
            // frmDesignReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1192, 726);
            this.Controls.Add(this.btnClearSelection);
            this.Controls.Add(this.btnDesignReport);
            this.Controls.Add(this.btnPreviewReport);
            this.Controls.Add(this.lstbxReports);
            this.Name = "frmDesignReports";
            this.Text = "مدير الأصناف - تصميم التقارير";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDesignReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errprvForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstbxReports;
        private System.Windows.Forms.Button btnPreviewReport;
        private System.Windows.Forms.Button btnClearSelection;
        private System.Windows.Forms.Button btnDesignReport;
    }
}
