namespace ItemsManager.Report
{
    partial class frmExpencesReport
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
            this.pnlDateFilter = new System.Windows.Forms.Panel();
            this.lblFilterByExpenseDate = new System.Windows.Forms.Label();
            this.dtpDateFrom = new System.Windows.Forms.DateTimePicker();
            this.lblDateTo = new System.Windows.Forms.Label();
            this.lblDateFrom = new System.Windows.Forms.Label();
            this.dtpDateTo = new System.Windows.Forms.DateTimePicker();
            this.pnlExpenceTypeFilter = new System.Windows.Forms.Panel();
            this.chkbxFilterByExpenseType = new System.Windows.Forms.CheckBox();
            this.pnlExpenseTypeFilterControls = new System.Windows.Forms.Panel();
            this.lblCustomerType = new System.Windows.Forms.Label();
            this.cbxExpenseType = new System.Windows.Forms.ComboBox();
            this.pnlFilterByStatement = new System.Windows.Forms.Panel();
            this.chkbxFilterByStatement = new System.Windows.Forms.CheckBox();
            this.pnlFilterByStatementControls = new System.Windows.Forms.Panel();
            this.lblStatementContains = new System.Windows.Forms.Label();
            this.tbxStatement = new System.Windows.Forms.TextBox();
            this.pnlFilterByRemarks = new System.Windows.Forms.Panel();
            this.chkbxFilterByRemarks = new System.Windows.Forms.CheckBox();
            this.pnlFilterByRemarksControls = new System.Windows.Forms.Panel();
            this.tbxRemarks = new System.Windows.Forms.TextBox();
            this.lblRemarksContains = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errprvForm)).BeginInit();
            this.pnlDateFilter.SuspendLayout();
            this.pnlExpenceTypeFilter.SuspendLayout();
            this.pnlExpenseTypeFilterControls.SuspendLayout();
            this.pnlFilterByStatement.SuspendLayout();
            this.pnlFilterByStatementControls.SuspendLayout();
            this.pnlFilterByRemarks.SuspendLayout();
            this.pnlFilterByRemarksControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDateFilter
            // 
            this.pnlDateFilter.Controls.Add(this.lblFilterByExpenseDate);
            this.pnlDateFilter.Controls.Add(this.dtpDateFrom);
            this.pnlDateFilter.Controls.Add(this.lblDateTo);
            this.pnlDateFilter.Controls.Add(this.lblDateFrom);
            this.pnlDateFilter.Controls.Add(this.dtpDateTo);
            this.pnlDateFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDateFilter.Location = new System.Drawing.Point(0, 0);
            this.pnlDateFilter.Margin = new System.Windows.Forms.Padding(4);
            this.pnlDateFilter.Name = "pnlDateFilter";
            this.pnlDateFilter.Size = new System.Drawing.Size(989, 97);
            this.pnlDateFilter.TabIndex = 5;
            // 
            // lblFilterByExpenseDate
            // 
            this.lblFilterByExpenseDate.AutoSize = true;
            this.lblFilterByExpenseDate.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.lblFilterByExpenseDate.Location = new System.Drawing.Point(805, 11);
            this.lblFilterByExpenseDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFilterByExpenseDate.Name = "lblFilterByExpenseDate";
            this.lblFilterByExpenseDate.Size = new System.Drawing.Size(163, 17);
            this.lblFilterByExpenseDate.TabIndex = 2;
            this.lblFilterByExpenseDate.Text = "تصفية بتاريخ المصروف :";
            // 
            // dtpDateFrom
            // 
            this.dtpDateFrom.CustomFormat = "dddd dd, MMMM, yyyy";
            this.dtpDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateFrom.Location = new System.Drawing.Point(467, 52);
            this.dtpDateFrom.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDateFrom.Name = "dtpDateFrom";
            this.dtpDateFrom.RightToLeftLayout = true;
            this.dtpDateFrom.Size = new System.Drawing.Size(393, 22);
            this.dtpDateFrom.TabIndex = 3;
            // 
            // lblDateTo
            // 
            this.lblDateTo.AutoSize = true;
            this.lblDateTo.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.lblDateTo.Location = new System.Drawing.Point(424, 52);
            this.lblDateTo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateTo.Name = "lblDateTo";
            this.lblDateTo.Size = new System.Drawing.Size(41, 17);
            this.lblDateTo.TabIndex = 0;
            this.lblDateTo.Text = "إلى :";
            // 
            // lblDateFrom
            // 
            this.lblDateFrom.AutoSize = true;
            this.lblDateFrom.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.lblDateFrom.Location = new System.Drawing.Point(931, 52);
            this.lblDateFrom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateFrom.Name = "lblDateFrom";
            this.lblDateFrom.Size = new System.Drawing.Size(37, 17);
            this.lblDateFrom.TabIndex = 2;
            this.lblDateFrom.Text = "من :";
            // 
            // dtpDateTo
            // 
            this.dtpDateTo.CustomFormat = "dddd dd, MMMM, yyyy";
            this.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateTo.Location = new System.Drawing.Point(21, 52);
            this.dtpDateTo.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDateTo.Name = "dtpDateTo";
            this.dtpDateTo.RightToLeftLayout = true;
            this.dtpDateTo.Size = new System.Drawing.Size(393, 22);
            this.dtpDateTo.TabIndex = 1;
            // 
            // pnlExpenceTypeFilter
            // 
            this.pnlExpenceTypeFilter.Controls.Add(this.chkbxFilterByExpenseType);
            this.pnlExpenceTypeFilter.Controls.Add(this.pnlExpenseTypeFilterControls);
            this.pnlExpenceTypeFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlExpenceTypeFilter.Location = new System.Drawing.Point(0, 97);
            this.pnlExpenceTypeFilter.Margin = new System.Windows.Forms.Padding(4);
            this.pnlExpenceTypeFilter.Name = "pnlExpenceTypeFilter";
            this.pnlExpenceTypeFilter.Size = new System.Drawing.Size(989, 110);
            this.pnlExpenceTypeFilter.TabIndex = 9;
            // 
            // chkbxFilterByExpenseType
            // 
            this.chkbxFilterByExpenseType.AutoSize = true;
            this.chkbxFilterByExpenseType.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.chkbxFilterByExpenseType.Location = new System.Drawing.Point(801, 11);
            this.chkbxFilterByExpenseType.Margin = new System.Windows.Forms.Padding(4);
            this.chkbxFilterByExpenseType.Name = "chkbxFilterByExpenseType";
            this.chkbxFilterByExpenseType.Size = new System.Drawing.Size(167, 21);
            this.chkbxFilterByExpenseType.TabIndex = 1;
            this.chkbxFilterByExpenseType.Text = "تصفية بنوع المصروف";
            this.chkbxFilterByExpenseType.UseVisualStyleBackColor = true;
            this.chkbxFilterByExpenseType.CheckedChanged += new System.EventHandler(this.chkbxFilterByExpenseType_CheckedChanged);
            // 
            // pnlExpenseTypeFilterControls
            // 
            this.pnlExpenseTypeFilterControls.Controls.Add(this.lblCustomerType);
            this.pnlExpenseTypeFilterControls.Controls.Add(this.cbxExpenseType);
            this.pnlExpenseTypeFilterControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlExpenseTypeFilterControls.Location = new System.Drawing.Point(0, 44);
            this.pnlExpenseTypeFilterControls.Margin = new System.Windows.Forms.Padding(4);
            this.pnlExpenseTypeFilterControls.Name = "pnlExpenseTypeFilterControls";
            this.pnlExpenseTypeFilterControls.Size = new System.Drawing.Size(989, 66);
            this.pnlExpenseTypeFilterControls.TabIndex = 0;
            this.pnlExpenseTypeFilterControls.Visible = false;
            // 
            // lblCustomerType
            // 
            this.lblCustomerType.AutoSize = true;
            this.lblCustomerType.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.lblCustomerType.Location = new System.Drawing.Point(864, 20);
            this.lblCustomerType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustomerType.Name = "lblCustomerType";
            this.lblCustomerType.Size = new System.Drawing.Size(104, 17);
            this.lblCustomerType.TabIndex = 0;
            this.lblCustomerType.Text = "نوع المصروف :";
            // 
            // cbxExpenseType
            // 
            this.cbxExpenseType.FormattingEnabled = true;
            this.cbxExpenseType.Location = new System.Drawing.Point(587, 20);
            this.cbxExpenseType.Margin = new System.Windows.Forms.Padding(4);
            this.cbxExpenseType.Name = "cbxExpenseType";
            this.cbxExpenseType.Size = new System.Drawing.Size(211, 24);
            this.cbxExpenseType.TabIndex = 1;
            // 
            // pnlFilterByStatement
            // 
            this.pnlFilterByStatement.Controls.Add(this.chkbxFilterByStatement);
            this.pnlFilterByStatement.Controls.Add(this.pnlFilterByStatementControls);
            this.pnlFilterByStatement.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilterByStatement.Location = new System.Drawing.Point(0, 207);
            this.pnlFilterByStatement.Margin = new System.Windows.Forms.Padding(4);
            this.pnlFilterByStatement.Name = "pnlFilterByStatement";
            this.pnlFilterByStatement.Size = new System.Drawing.Size(989, 110);
            this.pnlFilterByStatement.TabIndex = 10;
            // 
            // chkbxFilterByStatement
            // 
            this.chkbxFilterByStatement.AutoSize = true;
            this.chkbxFilterByStatement.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.chkbxFilterByStatement.Location = new System.Drawing.Point(852, 11);
            this.chkbxFilterByStatement.Margin = new System.Windows.Forms.Padding(4);
            this.chkbxFilterByStatement.Name = "chkbxFilterByStatement";
            this.chkbxFilterByStatement.Size = new System.Drawing.Size(116, 21);
            this.chkbxFilterByStatement.TabIndex = 1;
            this.chkbxFilterByStatement.Text = "تصفية بالبيان";
            this.chkbxFilterByStatement.UseVisualStyleBackColor = true;
            this.chkbxFilterByStatement.CheckedChanged += new System.EventHandler(this.chkbxFilterByStatement_CheckedChanged);
            // 
            // pnlFilterByStatementControls
            // 
            this.pnlFilterByStatementControls.Controls.Add(this.tbxStatement);
            this.pnlFilterByStatementControls.Controls.Add(this.lblStatementContains);
            this.pnlFilterByStatementControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFilterByStatementControls.Location = new System.Drawing.Point(0, 44);
            this.pnlFilterByStatementControls.Margin = new System.Windows.Forms.Padding(4);
            this.pnlFilterByStatementControls.Name = "pnlFilterByStatementControls";
            this.pnlFilterByStatementControls.Size = new System.Drawing.Size(989, 66);
            this.pnlFilterByStatementControls.TabIndex = 0;
            this.pnlFilterByStatementControls.Visible = false;
            // 
            // lblStatementContains
            // 
            this.lblStatementContains.AutoSize = true;
            this.lblStatementContains.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.lblStatementContains.Location = new System.Drawing.Point(835, 20);
            this.lblStatementContains.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatementContains.Name = "lblStatementContains";
            this.lblStatementContains.Size = new System.Drawing.Size(133, 17);
            this.lblStatementContains.TabIndex = 0;
            this.lblStatementContains.Text = "البيان يحتوي على :";
            // 
            // tbxStatement
            // 
            this.tbxStatement.Location = new System.Drawing.Point(587, 17);
            this.tbxStatement.Name = "tbxStatement";
            this.tbxStatement.Size = new System.Drawing.Size(211, 22);
            this.tbxStatement.TabIndex = 1;
            // 
            // pnlFilterByRemarks
            // 
            this.pnlFilterByRemarks.Controls.Add(this.chkbxFilterByRemarks);
            this.pnlFilterByRemarks.Controls.Add(this.pnlFilterByRemarksControls);
            this.pnlFilterByRemarks.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilterByRemarks.Location = new System.Drawing.Point(0, 317);
            this.pnlFilterByRemarks.Margin = new System.Windows.Forms.Padding(4);
            this.pnlFilterByRemarks.Name = "pnlFilterByRemarks";
            this.pnlFilterByRemarks.Size = new System.Drawing.Size(989, 110);
            this.pnlFilterByRemarks.TabIndex = 11;
            // 
            // chkbxFilterByRemarks
            // 
            this.chkbxFilterByRemarks.AutoSize = true;
            this.chkbxFilterByRemarks.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.chkbxFilterByRemarks.Location = new System.Drawing.Point(818, 11);
            this.chkbxFilterByRemarks.Margin = new System.Windows.Forms.Padding(4);
            this.chkbxFilterByRemarks.Name = "chkbxFilterByRemarks";
            this.chkbxFilterByRemarks.Size = new System.Drawing.Size(150, 21);
            this.chkbxFilterByRemarks.TabIndex = 1;
            this.chkbxFilterByRemarks.Text = "تصفية بالملاحظات";
            this.chkbxFilterByRemarks.UseVisualStyleBackColor = true;
            this.chkbxFilterByRemarks.CheckedChanged += new System.EventHandler(this.chkbxFilterByRemarks_CheckedChanged);
            // 
            // pnlFilterByRemarksControls
            // 
            this.pnlFilterByRemarksControls.Controls.Add(this.tbxRemarks);
            this.pnlFilterByRemarksControls.Controls.Add(this.lblRemarksContains);
            this.pnlFilterByRemarksControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFilterByRemarksControls.Location = new System.Drawing.Point(0, 44);
            this.pnlFilterByRemarksControls.Margin = new System.Windows.Forms.Padding(4);
            this.pnlFilterByRemarksControls.Name = "pnlFilterByRemarksControls";
            this.pnlFilterByRemarksControls.Size = new System.Drawing.Size(989, 66);
            this.pnlFilterByRemarksControls.TabIndex = 0;
            this.pnlFilterByRemarksControls.Visible = false;
            // 
            // tbxRemarks
            // 
            this.tbxRemarks.Location = new System.Drawing.Point(587, 17);
            this.tbxRemarks.Name = "tbxRemarks";
            this.tbxRemarks.Size = new System.Drawing.Size(211, 22);
            this.tbxRemarks.TabIndex = 1;
            // 
            // lblRemarksContains
            // 
            this.lblRemarksContains.AutoSize = true;
            this.lblRemarksContains.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.lblRemarksContains.Location = new System.Drawing.Point(801, 20);
            this.lblRemarksContains.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRemarksContains.Name = "lblRemarksContains";
            this.lblRemarksContains.Size = new System.Drawing.Size(167, 17);
            this.lblRemarksContains.TabIndex = 0;
            this.lblRemarksContains.Text = "الملاحظات تحتوي على :";
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.btnPrint.Location = new System.Drawing.Point(444, 441);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(100, 28);
            this.btnPrint.TabIndex = 12;
            this.btnPrint.Text = "طباعة";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // frmExpencesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(989, 488);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.pnlFilterByRemarks);
            this.Controls.Add(this.pnlFilterByStatement);
            this.Controls.Add(this.pnlExpenceTypeFilter);
            this.Controls.Add(this.pnlDateFilter);
            this.Name = "frmExpencesReport";
            this.Text = "مدير الأصناف - المصاريف";
            ((System.ComponentModel.ISupportInitialize)(this.errprvForm)).EndInit();
            this.pnlDateFilter.ResumeLayout(false);
            this.pnlDateFilter.PerformLayout();
            this.pnlExpenceTypeFilter.ResumeLayout(false);
            this.pnlExpenceTypeFilter.PerformLayout();
            this.pnlExpenseTypeFilterControls.ResumeLayout(false);
            this.pnlExpenseTypeFilterControls.PerformLayout();
            this.pnlFilterByStatement.ResumeLayout(false);
            this.pnlFilterByStatement.PerformLayout();
            this.pnlFilterByStatementControls.ResumeLayout(false);
            this.pnlFilterByStatementControls.PerformLayout();
            this.pnlFilterByRemarks.ResumeLayout(false);
            this.pnlFilterByRemarks.PerformLayout();
            this.pnlFilterByRemarksControls.ResumeLayout(false);
            this.pnlFilterByRemarksControls.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDateFilter;
        private System.Windows.Forms.Label lblFilterByExpenseDate;
        private System.Windows.Forms.DateTimePicker dtpDateFrom;
        private System.Windows.Forms.Label lblDateTo;
        private System.Windows.Forms.Label lblDateFrom;
        private System.Windows.Forms.DateTimePicker dtpDateTo;
        private System.Windows.Forms.Panel pnlExpenceTypeFilter;
        private System.Windows.Forms.CheckBox chkbxFilterByExpenseType;
        private System.Windows.Forms.Panel pnlExpenseTypeFilterControls;
        private System.Windows.Forms.Label lblCustomerType;
        private System.Windows.Forms.ComboBox cbxExpenseType;
        private System.Windows.Forms.Panel pnlFilterByStatement;
        private System.Windows.Forms.CheckBox chkbxFilterByStatement;
        private System.Windows.Forms.Panel pnlFilterByStatementControls;
        private System.Windows.Forms.TextBox tbxStatement;
        private System.Windows.Forms.Label lblStatementContains;
        private System.Windows.Forms.Panel pnlFilterByRemarks;
        private System.Windows.Forms.CheckBox chkbxFilterByRemarks;
        private System.Windows.Forms.Panel pnlFilterByRemarksControls;
        private System.Windows.Forms.TextBox tbxRemarks;
        private System.Windows.Forms.Label lblRemarksContains;
        private System.Windows.Forms.Button btnPrint;
    }
}
