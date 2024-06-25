namespace ItemsManager.Report
{
    partial class frmItemsInReport
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
            this.lblDateTo = new System.Windows.Forms.Label();
            this.dtpDateTo = new System.Windows.Forms.DateTimePicker();
            this.lblFilterByItemsInDate = new System.Windows.Forms.Label();
            this.dtpDateFrom = new System.Windows.Forms.DateTimePicker();
            this.lblDateFrom = new System.Windows.Forms.Label();
            this.pnlDateFilter = new System.Windows.Forms.Panel();
            this.pnlItemsInFilter = new System.Windows.Forms.Panel();
            this.chkbxFilterByItemsInID = new System.Windows.Forms.CheckBox();
            this.pnlItemsInFilterContorls = new System.Windows.Forms.Panel();
            this.tbxnItemsInIDTo = new CustomControls.NumericTextBox();
            this.tbxnItemsInIDFrom = new CustomControls.NumericTextBox();
            this.lblItemsInIDTo = new System.Windows.Forms.Label();
            this.lblItemsInIDFrom = new System.Windows.Forms.Label();
            this.pnlFilterBySupplier = new System.Windows.Forms.Panel();
            this.chkbxFilterBySupplier = new System.Windows.Forms.CheckBox();
            this.pnlFilterBySupplierControls = new System.Windows.Forms.Panel();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.cbxSupplier = new System.Windows.Forms.ComboBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.pnlSupplierTypeFilter = new System.Windows.Forms.Panel();
            this.chkbxFilterBySupplierType = new System.Windows.Forms.CheckBox();
            this.pnlSupplierTypeFilterControls = new System.Windows.Forms.Panel();
            this.lblSupplierType = new System.Windows.Forms.Label();
            this.cbxSupplierType = new System.Windows.Forms.ComboBox();
            this.pnlReportType = new System.Windows.Forms.Panel();
            this.rdbtnDetails = new System.Windows.Forms.RadioButton();
            this.rdbtnTotal = new System.Windows.Forms.RadioButton();
            this.lblReportType = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errprvForm)).BeginInit();
            this.pnlDateFilter.SuspendLayout();
            this.pnlItemsInFilter.SuspendLayout();
            this.pnlItemsInFilterContorls.SuspendLayout();
            this.pnlFilterBySupplier.SuspendLayout();
            this.pnlFilterBySupplierControls.SuspendLayout();
            this.pnlSupplierTypeFilter.SuspendLayout();
            this.pnlSupplierTypeFilterControls.SuspendLayout();
            this.pnlReportType.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDateTo
            // 
            this.lblDateTo.AutoSize = true;
            this.lblDateTo.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.lblDateTo.Location = new System.Drawing.Point(318, 42);
            this.lblDateTo.Name = "lblDateTo";
            this.lblDateTo.Size = new System.Drawing.Size(33, 13);
            this.lblDateTo.TabIndex = 0;
            this.lblDateTo.Text = "إلى :";
            // 
            // dtpDateTo
            // 
            this.dtpDateTo.CustomFormat = "dddd dd, MMMM, yyyy";
            this.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateTo.Location = new System.Drawing.Point(16, 42);
            this.dtpDateTo.Name = "dtpDateTo";
            this.dtpDateTo.RightToLeftLayout = true;
            this.dtpDateTo.Size = new System.Drawing.Size(296, 20);
            this.dtpDateTo.TabIndex = 1;
            // 
            // lblFilterByItemsInDate
            // 
            this.lblFilterByItemsInDate.AutoSize = true;
            this.lblFilterByItemsInDate.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.lblFilterByItemsInDate.Location = new System.Drawing.Point(614, 9);
            this.lblFilterByItemsInDate.Name = "lblFilterByItemsInDate";
            this.lblFilterByItemsInDate.Size = new System.Drawing.Size(120, 13);
            this.lblFilterByItemsInDate.TabIndex = 2;
            this.lblFilterByItemsInDate.Text = "تصفية بتاريخ الفاتورة :";
            // 
            // dtpDateFrom
            // 
            this.dtpDateFrom.CustomFormat = "dddd dd, MMMM, yyyy";
            this.dtpDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateFrom.Location = new System.Drawing.Point(365, 42);
            this.dtpDateFrom.Name = "dtpDateFrom";
            this.dtpDateFrom.RightToLeftLayout = true;
            this.dtpDateFrom.Size = new System.Drawing.Size(296, 20);
            this.dtpDateFrom.TabIndex = 3;
            // 
            // lblDateFrom
            // 
            this.lblDateFrom.AutoSize = true;
            this.lblDateFrom.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.lblDateFrom.Location = new System.Drawing.Point(698, 42);
            this.lblDateFrom.Name = "lblDateFrom";
            this.lblDateFrom.Size = new System.Drawing.Size(29, 13);
            this.lblDateFrom.TabIndex = 2;
            this.lblDateFrom.Text = "من :";
            // 
            // pnlDateFilter
            // 
            this.pnlDateFilter.Controls.Add(this.lblFilterByItemsInDate);
            this.pnlDateFilter.Controls.Add(this.dtpDateFrom);
            this.pnlDateFilter.Controls.Add(this.lblDateTo);
            this.pnlDateFilter.Controls.Add(this.lblDateFrom);
            this.pnlDateFilter.Controls.Add(this.dtpDateTo);
            this.pnlDateFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDateFilter.Location = new System.Drawing.Point(0, 55);
            this.pnlDateFilter.Name = "pnlDateFilter";
            this.pnlDateFilter.Size = new System.Drawing.Size(742, 79);
            this.pnlDateFilter.TabIndex = 4;
            // 
            // pnlItemsInFilter
            // 
            this.pnlItemsInFilter.Controls.Add(this.chkbxFilterByItemsInID);
            this.pnlItemsInFilter.Controls.Add(this.pnlItemsInFilterContorls);
            this.pnlItemsInFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlItemsInFilter.Location = new System.Drawing.Point(0, 134);
            this.pnlItemsInFilter.Name = "pnlItemsInFilter";
            this.pnlItemsInFilter.Size = new System.Drawing.Size(742, 89);
            this.pnlItemsInFilter.TabIndex = 5;
            // 
            // chkbxFilterByItemsInID
            // 
            this.chkbxFilterByItemsInID.AutoSize = true;
            this.chkbxFilterByItemsInID.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.chkbxFilterByItemsInID.Location = new System.Drawing.Point(606, 9);
            this.chkbxFilterByItemsInID.Name = "chkbxFilterByItemsInID";
            this.chkbxFilterByItemsInID.Size = new System.Drawing.Size(127, 17);
            this.chkbxFilterByItemsInID.TabIndex = 1;
            this.chkbxFilterByItemsInID.Text = "تصفية برقم الفاتورة";
            this.chkbxFilterByItemsInID.UseVisualStyleBackColor = true;
            this.chkbxFilterByItemsInID.CheckedChanged += new System.EventHandler(this.chkbxFilterByItemsInID_CheckedChanged);
            // 
            // pnlItemsInFilterContorls
            // 
            this.pnlItemsInFilterContorls.Controls.Add(this.tbxnItemsInIDTo);
            this.pnlItemsInFilterContorls.Controls.Add(this.tbxnItemsInIDFrom);
            this.pnlItemsInFilterContorls.Controls.Add(this.lblItemsInIDTo);
            this.pnlItemsInFilterContorls.Controls.Add(this.lblItemsInIDFrom);
            this.pnlItemsInFilterContorls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlItemsInFilterContorls.Location = new System.Drawing.Point(0, 35);
            this.pnlItemsInFilterContorls.Name = "pnlItemsInFilterContorls";
            this.pnlItemsInFilterContorls.Size = new System.Drawing.Size(742, 54);
            this.pnlItemsInFilterContorls.TabIndex = 0;
            this.pnlItemsInFilterContorls.Visible = false;
            // 
            // tbxnItemsInIDTo
            // 
            this.tbxnItemsInIDTo.IsInt = true;
            this.tbxnItemsInIDTo.Location = new System.Drawing.Point(212, 16);
            this.tbxnItemsInIDTo.Name = "tbxnItemsInIDTo";
            this.tbxnItemsInIDTo.Size = new System.Drawing.Size(100, 20);
            this.tbxnItemsInIDTo.TabIndex = 1;
            // 
            // tbxnItemsInIDFrom
            // 
            this.tbxnItemsInIDFrom.IsInt = true;
            this.tbxnItemsInIDFrom.Location = new System.Drawing.Point(561, 16);
            this.tbxnItemsInIDFrom.Name = "tbxnItemsInIDFrom";
            this.tbxnItemsInIDFrom.Size = new System.Drawing.Size(100, 20);
            this.tbxnItemsInIDFrom.TabIndex = 1;
            // 
            // lblItemsInIDTo
            // 
            this.lblItemsInIDTo.AutoSize = true;
            this.lblItemsInIDTo.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.lblItemsInIDTo.Location = new System.Drawing.Point(318, 16);
            this.lblItemsInIDTo.Name = "lblItemsInIDTo";
            this.lblItemsInIDTo.Size = new System.Drawing.Size(33, 13);
            this.lblItemsInIDTo.TabIndex = 0;
            this.lblItemsInIDTo.Text = "إلى :";
            // 
            // lblItemsInIDFrom
            // 
            this.lblItemsInIDFrom.AutoSize = true;
            this.lblItemsInIDFrom.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.lblItemsInIDFrom.Location = new System.Drawing.Point(696, 16);
            this.lblItemsInIDFrom.Name = "lblItemsInIDFrom";
            this.lblItemsInIDFrom.Size = new System.Drawing.Size(29, 13);
            this.lblItemsInIDFrom.TabIndex = 0;
            this.lblItemsInIDFrom.Text = "من :";
            // 
            // pnlFilterBySupplier
            // 
            this.pnlFilterBySupplier.Controls.Add(this.chkbxFilterBySupplier);
            this.pnlFilterBySupplier.Controls.Add(this.pnlFilterBySupplierControls);
            this.pnlFilterBySupplier.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilterBySupplier.Location = new System.Drawing.Point(0, 312);
            this.pnlFilterBySupplier.Name = "pnlFilterBySupplier";
            this.pnlFilterBySupplier.Size = new System.Drawing.Size(742, 89);
            this.pnlFilterBySupplier.TabIndex = 6;
            // 
            // chkbxFilterBySupplier
            // 
            this.chkbxFilterBySupplier.AutoSize = true;
            this.chkbxFilterBySupplier.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.chkbxFilterBySupplier.Location = new System.Drawing.Point(628, 9);
            this.chkbxFilterBySupplier.Name = "chkbxFilterBySupplier";
            this.chkbxFilterBySupplier.Size = new System.Drawing.Size(97, 17);
            this.chkbxFilterBySupplier.TabIndex = 1;
            this.chkbxFilterBySupplier.Text = "تصفية بالمورد";
            this.chkbxFilterBySupplier.UseVisualStyleBackColor = true;
            this.chkbxFilterBySupplier.CheckedChanged += new System.EventHandler(this.chkbxFilterBySupplier_CheckedChanged);
            // 
            // pnlFilterBySupplierControls
            // 
            this.pnlFilterBySupplierControls.Controls.Add(this.lblSupplier);
            this.pnlFilterBySupplierControls.Controls.Add(this.cbxSupplier);
            this.pnlFilterBySupplierControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFilterBySupplierControls.Location = new System.Drawing.Point(0, 35);
            this.pnlFilterBySupplierControls.Name = "pnlFilterBySupplierControls";
            this.pnlFilterBySupplierControls.Size = new System.Drawing.Size(742, 54);
            this.pnlFilterBySupplierControls.TabIndex = 0;
            this.pnlFilterBySupplierControls.Visible = false;
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.lblSupplier.Location = new System.Drawing.Point(685, 16);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(45, 13);
            this.lblSupplier.TabIndex = 0;
            this.lblSupplier.Text = "المورد :";
            // 
            // cbxSupplier
            // 
            this.cbxSupplier.FormattingEnabled = true;
            this.cbxSupplier.Location = new System.Drawing.Point(540, 16);
            this.cbxSupplier.Name = "cbxSupplier";
            this.cbxSupplier.Size = new System.Drawing.Size(121, 21);
            this.cbxSupplier.TabIndex = 1;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.btnPrint.Location = new System.Drawing.Point(334, 411);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 7;
            this.btnPrint.Text = "طباعة";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // pnlSupplierTypeFilter
            // 
            this.pnlSupplierTypeFilter.Controls.Add(this.chkbxFilterBySupplierType);
            this.pnlSupplierTypeFilter.Controls.Add(this.pnlSupplierTypeFilterControls);
            this.pnlSupplierTypeFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSupplierTypeFilter.Location = new System.Drawing.Point(0, 223);
            this.pnlSupplierTypeFilter.Name = "pnlSupplierTypeFilter";
            this.pnlSupplierTypeFilter.Size = new System.Drawing.Size(742, 89);
            this.pnlSupplierTypeFilter.TabIndex = 8;
            // 
            // chkbxFilterBySupplierType
            // 
            this.chkbxFilterBySupplierType.AutoSize = true;
            this.chkbxFilterBySupplierType.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.chkbxFilterBySupplierType.Location = new System.Drawing.Point(609, 9);
            this.chkbxFilterBySupplierType.Name = "chkbxFilterBySupplierType";
            this.chkbxFilterBySupplierType.Size = new System.Drawing.Size(118, 17);
            this.chkbxFilterBySupplierType.TabIndex = 1;
            this.chkbxFilterBySupplierType.Text = "تصفية بنوع المورد";
            this.chkbxFilterBySupplierType.UseVisualStyleBackColor = true;
            this.chkbxFilterBySupplierType.CheckedChanged += new System.EventHandler(this.chkbxFilterBySupplierType_CheckedChanged);
            // 
            // pnlSupplierTypeFilterControls
            // 
            this.pnlSupplierTypeFilterControls.Controls.Add(this.lblSupplierType);
            this.pnlSupplierTypeFilterControls.Controls.Add(this.cbxSupplierType);
            this.pnlSupplierTypeFilterControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSupplierTypeFilterControls.Location = new System.Drawing.Point(0, 35);
            this.pnlSupplierTypeFilterControls.Name = "pnlSupplierTypeFilterControls";
            this.pnlSupplierTypeFilterControls.Size = new System.Drawing.Size(742, 54);
            this.pnlSupplierTypeFilterControls.TabIndex = 0;
            this.pnlSupplierTypeFilterControls.Visible = false;
            // 
            // lblSupplierType
            // 
            this.lblSupplierType.AutoSize = true;
            this.lblSupplierType.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.lblSupplierType.Location = new System.Drawing.Point(667, 16);
            this.lblSupplierType.Name = "lblSupplierType";
            this.lblSupplierType.Size = new System.Drawing.Size(66, 13);
            this.lblSupplierType.TabIndex = 0;
            this.lblSupplierType.Text = "نوع المورد :";
            // 
            // cbxSupplierType
            // 
            this.cbxSupplierType.FormattingEnabled = true;
            this.cbxSupplierType.Location = new System.Drawing.Point(540, 16);
            this.cbxSupplierType.Name = "cbxSupplierType";
            this.cbxSupplierType.Size = new System.Drawing.Size(121, 21);
            this.cbxSupplierType.TabIndex = 1;
            // 
            // pnlReportType
            // 
            this.pnlReportType.Controls.Add(this.rdbtnDetails);
            this.pnlReportType.Controls.Add(this.rdbtnTotal);
            this.pnlReportType.Controls.Add(this.lblReportType);
            this.pnlReportType.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlReportType.Location = new System.Drawing.Point(0, 0);
            this.pnlReportType.Name = "pnlReportType";
            this.pnlReportType.Size = new System.Drawing.Size(742, 55);
            this.pnlReportType.TabIndex = 9;
            // 
            // rdbtnDetails
            // 
            this.rdbtnDetails.AutoSize = true;
            this.rdbtnDetails.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.rdbtnDetails.Location = new System.Drawing.Point(225, 16);
            this.rdbtnDetails.Name = "rdbtnDetails";
            this.rdbtnDetails.Size = new System.Drawing.Size(87, 23);
            this.rdbtnDetails.TabIndex = 3;
            this.rdbtnDetails.Text = "تفصيلي";
            this.rdbtnDetails.UseVisualStyleBackColor = true;
            // 
            // rdbtnTotal
            // 
            this.rdbtnTotal.AutoSize = true;
            this.rdbtnTotal.Checked = true;
            this.rdbtnTotal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.rdbtnTotal.Location = new System.Drawing.Point(436, 16);
            this.rdbtnTotal.Name = "rdbtnTotal";
            this.rdbtnTotal.Size = new System.Drawing.Size(82, 23);
            this.rdbtnTotal.TabIndex = 3;
            this.rdbtnTotal.TabStop = true;
            this.rdbtnTotal.Text = "إجمالي";
            this.rdbtnTotal.UseVisualStyleBackColor = true;
            // 
            // lblReportType
            // 
            this.lblReportType.AutoSize = true;
            this.lblReportType.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblReportType.Location = new System.Drawing.Point(632, 18);
            this.lblReportType.Name = "lblReportType";
            this.lblReportType.Size = new System.Drawing.Size(95, 19);
            this.lblReportType.TabIndex = 2;
            this.lblReportType.Text = "نوع التقرير :";
            // 
            // frmItemsInReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(742, 440);
            this.Controls.Add(this.pnlFilterBySupplier);
            this.Controls.Add(this.pnlSupplierTypeFilter);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.pnlItemsInFilter);
            this.Controls.Add(this.pnlDateFilter);
            this.Controls.Add(this.pnlReportType);
            this.Name = "frmItemsInReport";
            this.Text = "مدير الأصناف - تقرير فواتير الشراء";
            this.Load += new System.EventHandler(this.frmItemsInReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errprvForm)).EndInit();
            this.pnlDateFilter.ResumeLayout(false);
            this.pnlDateFilter.PerformLayout();
            this.pnlItemsInFilter.ResumeLayout(false);
            this.pnlItemsInFilter.PerformLayout();
            this.pnlItemsInFilterContorls.ResumeLayout(false);
            this.pnlItemsInFilterContorls.PerformLayout();
            this.pnlFilterBySupplier.ResumeLayout(false);
            this.pnlFilterBySupplier.PerformLayout();
            this.pnlFilterBySupplierControls.ResumeLayout(false);
            this.pnlFilterBySupplierControls.PerformLayout();
            this.pnlSupplierTypeFilter.ResumeLayout(false);
            this.pnlSupplierTypeFilter.PerformLayout();
            this.pnlSupplierTypeFilterControls.ResumeLayout(false);
            this.pnlSupplierTypeFilterControls.PerformLayout();
            this.pnlReportType.ResumeLayout(false);
            this.pnlReportType.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDateTo;
        private System.Windows.Forms.DateTimePicker dtpDateTo;
        private System.Windows.Forms.Label lblFilterByItemsInDate;
        private System.Windows.Forms.DateTimePicker dtpDateFrom;
        private System.Windows.Forms.Label lblDateFrom;
        private System.Windows.Forms.Panel pnlDateFilter;
        private System.Windows.Forms.Panel pnlItemsInFilter;
        private System.Windows.Forms.CheckBox chkbxFilterByItemsInID;
        private System.Windows.Forms.Panel pnlItemsInFilterContorls;
        private CustomControls.NumericTextBox tbxnItemsInIDTo;
        private CustomControls.NumericTextBox tbxnItemsInIDFrom;
        private System.Windows.Forms.Label lblItemsInIDTo;
        private System.Windows.Forms.Label lblItemsInIDFrom;
        private System.Windows.Forms.Panel pnlFilterBySupplier;
        private System.Windows.Forms.CheckBox chkbxFilterBySupplier;
        private System.Windows.Forms.Panel pnlFilterBySupplierControls;
        private System.Windows.Forms.ComboBox cbxSupplier;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Panel pnlSupplierTypeFilter;
        private System.Windows.Forms.CheckBox chkbxFilterBySupplierType;
        private System.Windows.Forms.Panel pnlSupplierTypeFilterControls;
        private System.Windows.Forms.Label lblSupplierType;
        private System.Windows.Forms.ComboBox cbxSupplierType;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.Panel pnlReportType;
        private System.Windows.Forms.RadioButton rdbtnDetails;
        private System.Windows.Forms.RadioButton rdbtnTotal;
        private System.Windows.Forms.Label lblReportType;
    }
}
