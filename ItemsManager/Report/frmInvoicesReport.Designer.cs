namespace ItemsManager.Report
{
    partial class frmInvoicesReport
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
            this.lblFilterByInvoiceDate = new System.Windows.Forms.Label();
            this.dtpDateFrom = new System.Windows.Forms.DateTimePicker();
            this.lblDateFrom = new System.Windows.Forms.Label();
            this.pnlDateFilter = new System.Windows.Forms.Panel();
            this.pnlInvoiceFilter = new System.Windows.Forms.Panel();
            this.chkbxFilterByInvoiceID = new System.Windows.Forms.CheckBox();
            this.pnlInvoiceFilterContorls = new System.Windows.Forms.Panel();
            this.tbxnInvoiceIDTo = new CustomControls.NumericTextBox();
            this.tbxnInvoiceIDFrom = new CustomControls.NumericTextBox();
            this.lblInvoiceIDTo = new System.Windows.Forms.Label();
            this.lblInvoiceIDFrom = new System.Windows.Forms.Label();
            this.pnlFilterByCustomer = new System.Windows.Forms.Panel();
            this.chkbxFilterByCustomer = new System.Windows.Forms.CheckBox();
            this.pnlFilterByCustomerControls = new System.Windows.Forms.Panel();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.cbxCustomer = new System.Windows.Forms.ComboBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.pnlCustomerTypeFilter = new System.Windows.Forms.Panel();
            this.chkbxFilterByCustomerType = new System.Windows.Forms.CheckBox();
            this.pnlCustomerTypeFilterControls = new System.Windows.Forms.Panel();
            this.lblCustomerType = new System.Windows.Forms.Label();
            this.cbxCustomerType = new System.Windows.Forms.ComboBox();
            this.pnlReportType = new System.Windows.Forms.Panel();
            this.rdbtnDetails = new System.Windows.Forms.RadioButton();
            this.rdbtnTotal = new System.Windows.Forms.RadioButton();
            this.lblReportType = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errprvForm)).BeginInit();
            this.pnlDateFilter.SuspendLayout();
            this.pnlInvoiceFilter.SuspendLayout();
            this.pnlInvoiceFilterContorls.SuspendLayout();
            this.pnlFilterByCustomer.SuspendLayout();
            this.pnlFilterByCustomerControls.SuspendLayout();
            this.pnlCustomerTypeFilter.SuspendLayout();
            this.pnlCustomerTypeFilterControls.SuspendLayout();
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
            // lblFilterByInvoiceDate
            // 
            this.lblFilterByInvoiceDate.AutoSize = true;
            this.lblFilterByInvoiceDate.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.lblFilterByInvoiceDate.Location = new System.Drawing.Point(614, 9);
            this.lblFilterByInvoiceDate.Name = "lblFilterByInvoiceDate";
            this.lblFilterByInvoiceDate.Size = new System.Drawing.Size(120, 13);
            this.lblFilterByInvoiceDate.TabIndex = 2;
            this.lblFilterByInvoiceDate.Text = "تصفية بتاريخ الفاتورة :";
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
            this.pnlDateFilter.Controls.Add(this.lblFilterByInvoiceDate);
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
            // pnlInvoiceFilter
            // 
            this.pnlInvoiceFilter.Controls.Add(this.chkbxFilterByInvoiceID);
            this.pnlInvoiceFilter.Controls.Add(this.pnlInvoiceFilterContorls);
            this.pnlInvoiceFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInvoiceFilter.Location = new System.Drawing.Point(0, 134);
            this.pnlInvoiceFilter.Name = "pnlInvoiceFilter";
            this.pnlInvoiceFilter.Size = new System.Drawing.Size(742, 89);
            this.pnlInvoiceFilter.TabIndex = 5;
            // 
            // chkbxFilterByInvoiceID
            // 
            this.chkbxFilterByInvoiceID.AutoSize = true;
            this.chkbxFilterByInvoiceID.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.chkbxFilterByInvoiceID.Location = new System.Drawing.Point(606, 9);
            this.chkbxFilterByInvoiceID.Name = "chkbxFilterByInvoiceID";
            this.chkbxFilterByInvoiceID.Size = new System.Drawing.Size(127, 17);
            this.chkbxFilterByInvoiceID.TabIndex = 1;
            this.chkbxFilterByInvoiceID.Text = "تصفية برقم الفاتورة";
            this.chkbxFilterByInvoiceID.UseVisualStyleBackColor = true;
            this.chkbxFilterByInvoiceID.CheckedChanged += new System.EventHandler(this.chkbxFilterByInvoiceID_CheckedChanged);
            // 
            // pnlInvoiceFilterContorls
            // 
            this.pnlInvoiceFilterContorls.Controls.Add(this.tbxnInvoiceIDTo);
            this.pnlInvoiceFilterContorls.Controls.Add(this.tbxnInvoiceIDFrom);
            this.pnlInvoiceFilterContorls.Controls.Add(this.lblInvoiceIDTo);
            this.pnlInvoiceFilterContorls.Controls.Add(this.lblInvoiceIDFrom);
            this.pnlInvoiceFilterContorls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlInvoiceFilterContorls.Location = new System.Drawing.Point(0, 35);
            this.pnlInvoiceFilterContorls.Name = "pnlInvoiceFilterContorls";
            this.pnlInvoiceFilterContorls.Size = new System.Drawing.Size(742, 54);
            this.pnlInvoiceFilterContorls.TabIndex = 0;
            this.pnlInvoiceFilterContorls.Visible = false;
            // 
            // tbxnInvoiceIDTo
            // 
            this.tbxnInvoiceIDTo.IsInt = true;
            this.tbxnInvoiceIDTo.Location = new System.Drawing.Point(212, 16);
            this.tbxnInvoiceIDTo.Name = "tbxnInvoiceIDTo";
            this.tbxnInvoiceIDTo.Size = new System.Drawing.Size(100, 20);
            this.tbxnInvoiceIDTo.TabIndex = 1;
            // 
            // tbxnInvoiceIDFrom
            // 
            this.tbxnInvoiceIDFrom.IsInt = true;
            this.tbxnInvoiceIDFrom.Location = new System.Drawing.Point(561, 16);
            this.tbxnInvoiceIDFrom.Name = "tbxnInvoiceIDFrom";
            this.tbxnInvoiceIDFrom.Size = new System.Drawing.Size(100, 20);
            this.tbxnInvoiceIDFrom.TabIndex = 1;
            // 
            // lblInvoiceIDTo
            // 
            this.lblInvoiceIDTo.AutoSize = true;
            this.lblInvoiceIDTo.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.lblInvoiceIDTo.Location = new System.Drawing.Point(318, 16);
            this.lblInvoiceIDTo.Name = "lblInvoiceIDTo";
            this.lblInvoiceIDTo.Size = new System.Drawing.Size(33, 13);
            this.lblInvoiceIDTo.TabIndex = 0;
            this.lblInvoiceIDTo.Text = "إلى :";
            // 
            // lblInvoiceIDFrom
            // 
            this.lblInvoiceIDFrom.AutoSize = true;
            this.lblInvoiceIDFrom.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.lblInvoiceIDFrom.Location = new System.Drawing.Point(696, 16);
            this.lblInvoiceIDFrom.Name = "lblInvoiceIDFrom";
            this.lblInvoiceIDFrom.Size = new System.Drawing.Size(29, 13);
            this.lblInvoiceIDFrom.TabIndex = 0;
            this.lblInvoiceIDFrom.Text = "من :";
            // 
            // pnlFilterByCustomer
            // 
            this.pnlFilterByCustomer.Controls.Add(this.chkbxFilterByCustomer);
            this.pnlFilterByCustomer.Controls.Add(this.pnlFilterByCustomerControls);
            this.pnlFilterByCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilterByCustomer.Location = new System.Drawing.Point(0, 312);
            this.pnlFilterByCustomer.Name = "pnlFilterByCustomer";
            this.pnlFilterByCustomer.Size = new System.Drawing.Size(742, 89);
            this.pnlFilterByCustomer.TabIndex = 6;
            // 
            // chkbxFilterByCustomer
            // 
            this.chkbxFilterByCustomer.AutoSize = true;
            this.chkbxFilterByCustomer.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.chkbxFilterByCustomer.Location = new System.Drawing.Point(628, 9);
            this.chkbxFilterByCustomer.Name = "chkbxFilterByCustomer";
            this.chkbxFilterByCustomer.Size = new System.Drawing.Size(99, 17);
            this.chkbxFilterByCustomer.TabIndex = 1;
            this.chkbxFilterByCustomer.Text = "تصفية بالعميل";
            this.chkbxFilterByCustomer.UseVisualStyleBackColor = true;
            this.chkbxFilterByCustomer.CheckedChanged += new System.EventHandler(this.chkbxFilterByCustomer_CheckedChanged);
            // 
            // pnlFilterByCustomerControls
            // 
            this.pnlFilterByCustomerControls.Controls.Add(this.lblCustomer);
            this.pnlFilterByCustomerControls.Controls.Add(this.cbxCustomer);
            this.pnlFilterByCustomerControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFilterByCustomerControls.Location = new System.Drawing.Point(0, 35);
            this.pnlFilterByCustomerControls.Name = "pnlFilterByCustomerControls";
            this.pnlFilterByCustomerControls.Size = new System.Drawing.Size(742, 54);
            this.pnlFilterByCustomerControls.TabIndex = 0;
            this.pnlFilterByCustomerControls.Visible = false;
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.lblCustomer.Location = new System.Drawing.Point(685, 16);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(47, 13);
            this.lblCustomer.TabIndex = 0;
            this.lblCustomer.Text = "العميل :";
            // 
            // cbxCustomer
            // 
            this.cbxCustomer.FormattingEnabled = true;
            this.cbxCustomer.Location = new System.Drawing.Point(540, 16);
            this.cbxCustomer.Name = "cbxCustomer";
            this.cbxCustomer.Size = new System.Drawing.Size(121, 21);
            this.cbxCustomer.TabIndex = 1;
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
            // pnlCustomerTypeFilter
            // 
            this.pnlCustomerTypeFilter.Controls.Add(this.chkbxFilterByCustomerType);
            this.pnlCustomerTypeFilter.Controls.Add(this.pnlCustomerTypeFilterControls);
            this.pnlCustomerTypeFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCustomerTypeFilter.Location = new System.Drawing.Point(0, 223);
            this.pnlCustomerTypeFilter.Name = "pnlCustomerTypeFilter";
            this.pnlCustomerTypeFilter.Size = new System.Drawing.Size(742, 89);
            this.pnlCustomerTypeFilter.TabIndex = 8;
            // 
            // chkbxFilterByCustomerType
            // 
            this.chkbxFilterByCustomerType.AutoSize = true;
            this.chkbxFilterByCustomerType.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.chkbxFilterByCustomerType.Location = new System.Drawing.Point(609, 9);
            this.chkbxFilterByCustomerType.Name = "chkbxFilterByCustomerType";
            this.chkbxFilterByCustomerType.Size = new System.Drawing.Size(120, 17);
            this.chkbxFilterByCustomerType.TabIndex = 1;
            this.chkbxFilterByCustomerType.Text = "تصفية بنوع العميل";
            this.chkbxFilterByCustomerType.UseVisualStyleBackColor = true;
            this.chkbxFilterByCustomerType.CheckedChanged += new System.EventHandler(this.chkbxFilterByCustomerType_CheckedChanged);
            // 
            // pnlCustomerTypeFilterControls
            // 
            this.pnlCustomerTypeFilterControls.Controls.Add(this.lblCustomerType);
            this.pnlCustomerTypeFilterControls.Controls.Add(this.cbxCustomerType);
            this.pnlCustomerTypeFilterControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlCustomerTypeFilterControls.Location = new System.Drawing.Point(0, 35);
            this.pnlCustomerTypeFilterControls.Name = "pnlCustomerTypeFilterControls";
            this.pnlCustomerTypeFilterControls.Size = new System.Drawing.Size(742, 54);
            this.pnlCustomerTypeFilterControls.TabIndex = 0;
            this.pnlCustomerTypeFilterControls.Visible = false;
            // 
            // lblCustomerType
            // 
            this.lblCustomerType.AutoSize = true;
            this.lblCustomerType.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.lblCustomerType.Location = new System.Drawing.Point(667, 16);
            this.lblCustomerType.Name = "lblCustomerType";
            this.lblCustomerType.Size = new System.Drawing.Size(68, 13);
            this.lblCustomerType.TabIndex = 0;
            this.lblCustomerType.Text = "نوع العميل :";
            // 
            // cbxCustomerType
            // 
            this.cbxCustomerType.FormattingEnabled = true;
            this.cbxCustomerType.Location = new System.Drawing.Point(540, 16);
            this.cbxCustomerType.Name = "cbxCustomerType";
            this.cbxCustomerType.Size = new System.Drawing.Size(121, 21);
            this.cbxCustomerType.TabIndex = 1;
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
            // frmInvoicesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(742, 440);
            this.Controls.Add(this.pnlFilterByCustomer);
            this.Controls.Add(this.pnlCustomerTypeFilter);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.pnlInvoiceFilter);
            this.Controls.Add(this.pnlDateFilter);
            this.Controls.Add(this.pnlReportType);
            this.Name = "frmInvoicesReport";
            this.Text = "مدير الأصناف - تقرير الفواتير";
            this.Load += new System.EventHandler(this.frmInvoicesReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errprvForm)).EndInit();
            this.pnlDateFilter.ResumeLayout(false);
            this.pnlDateFilter.PerformLayout();
            this.pnlInvoiceFilter.ResumeLayout(false);
            this.pnlInvoiceFilter.PerformLayout();
            this.pnlInvoiceFilterContorls.ResumeLayout(false);
            this.pnlInvoiceFilterContorls.PerformLayout();
            this.pnlFilterByCustomer.ResumeLayout(false);
            this.pnlFilterByCustomer.PerformLayout();
            this.pnlFilterByCustomerControls.ResumeLayout(false);
            this.pnlFilterByCustomerControls.PerformLayout();
            this.pnlCustomerTypeFilter.ResumeLayout(false);
            this.pnlCustomerTypeFilter.PerformLayout();
            this.pnlCustomerTypeFilterControls.ResumeLayout(false);
            this.pnlCustomerTypeFilterControls.PerformLayout();
            this.pnlReportType.ResumeLayout(false);
            this.pnlReportType.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDateTo;
        private System.Windows.Forms.DateTimePicker dtpDateTo;
        private System.Windows.Forms.Label lblFilterByInvoiceDate;
        private System.Windows.Forms.DateTimePicker dtpDateFrom;
        private System.Windows.Forms.Label lblDateFrom;
        private System.Windows.Forms.Panel pnlDateFilter;
        private System.Windows.Forms.Panel pnlInvoiceFilter;
        private System.Windows.Forms.CheckBox chkbxFilterByInvoiceID;
        private System.Windows.Forms.Panel pnlInvoiceFilterContorls;
        private CustomControls.NumericTextBox tbxnInvoiceIDTo;
        private CustomControls.NumericTextBox tbxnInvoiceIDFrom;
        private System.Windows.Forms.Label lblInvoiceIDTo;
        private System.Windows.Forms.Label lblInvoiceIDFrom;
        private System.Windows.Forms.Panel pnlFilterByCustomer;
        private System.Windows.Forms.CheckBox chkbxFilterByCustomer;
        private System.Windows.Forms.Panel pnlFilterByCustomerControls;
        private System.Windows.Forms.ComboBox cbxCustomer;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Panel pnlCustomerTypeFilter;
        private System.Windows.Forms.CheckBox chkbxFilterByCustomerType;
        private System.Windows.Forms.Panel pnlCustomerTypeFilterControls;
        private System.Windows.Forms.Label lblCustomerType;
        private System.Windows.Forms.ComboBox cbxCustomerType;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Panel pnlReportType;
        private System.Windows.Forms.RadioButton rdbtnDetails;
        private System.Windows.Forms.RadioButton rdbtnTotal;
        private System.Windows.Forms.Label lblReportType;
    }
}
