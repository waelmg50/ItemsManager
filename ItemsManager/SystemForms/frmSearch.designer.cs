namespace ItemsManager
{
    partial class frmSearch
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
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.chkbxInstantSearch = new System.Windows.Forms.CheckBox();
            this.pnlSepBtnCheckBox = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pnlSepBtnSearch = new System.Windows.Forms.Panel();
            this.cbxSearchWay = new System.Windows.Forms.ComboBox();
            this.lblSearchWay = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbxSearchIn = new System.Windows.Forms.ComboBox();
            this.lblSearchIn = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbxSearchFor = new System.Windows.Forms.TextBox();
            this.lblSearchFor = new System.Windows.Forms.Label();
            this.pnlSepBegin = new System.Windows.Forms.Panel();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblTableName = new System.Windows.Forms.Label();
            this.lblSearchTable = new System.Windows.Forms.Label();
            this.dgvSearchRes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.errprvForm)).BeginInit();
            this.pnlSearch.SuspendLayout();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchRes)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSearch
            // 
            this.pnlSearch.Controls.Add(this.chkbxInstantSearch);
            this.pnlSearch.Controls.Add(this.pnlSepBtnCheckBox);
            this.pnlSearch.Controls.Add(this.btnSearch);
            this.pnlSearch.Controls.Add(this.pnlSepBtnSearch);
            this.pnlSearch.Controls.Add(this.cbxSearchWay);
            this.pnlSearch.Controls.Add(this.lblSearchWay);
            this.pnlSearch.Controls.Add(this.panel1);
            this.pnlSearch.Controls.Add(this.cbxSearchIn);
            this.pnlSearch.Controls.Add(this.lblSearchIn);
            this.pnlSearch.Controls.Add(this.panel2);
            this.pnlSearch.Controls.Add(this.tbxSearchFor);
            this.pnlSearch.Controls.Add(this.lblSearchFor);
            this.pnlSearch.Controls.Add(this.pnlSepBegin);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearch.Location = new System.Drawing.Point(0, 49);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(920, 31);
            this.pnlSearch.TabIndex = 3;
            // 
            // chkbxInstantSearch
            // 
            this.chkbxInstantSearch.AutoSize = true;
            this.chkbxInstantSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.chkbxInstantSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.chkbxInstantSearch.Location = new System.Drawing.Point(28, 0);
            this.chkbxInstantSearch.Name = "chkbxInstantSearch";
            this.chkbxInstantSearch.Size = new System.Drawing.Size(122, 31);
            this.chkbxInstantSearch.TabIndex = 10;
            this.chkbxInstantSearch.Text = "بحث بمجرد الكتابة";
            this.chkbxInstantSearch.UseVisualStyleBackColor = true;
            // 
            // pnlSepBtnCheckBox
            // 
            this.pnlSepBtnCheckBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlSepBtnCheckBox.Location = new System.Drawing.Point(150, 0);
            this.pnlSepBtnCheckBox.Name = "pnlSepBtnCheckBox";
            this.pnlSepBtnCheckBox.Size = new System.Drawing.Size(14, 31);
            this.pnlSepBtnCheckBox.TabIndex = 9;
            // 
            // btnSearch
            // 
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSearch.Location = new System.Drawing.Point(164, 0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 31);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "بحث";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // pnlSepBtnSearch
            // 
            this.pnlSepBtnSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlSepBtnSearch.Location = new System.Drawing.Point(239, 0);
            this.pnlSepBtnSearch.Name = "pnlSepBtnSearch";
            this.pnlSepBtnSearch.Size = new System.Drawing.Size(14, 31);
            this.pnlSepBtnSearch.TabIndex = 5;
            // 
            // cbxSearchWay
            // 
            this.cbxSearchWay.Dock = System.Windows.Forms.DockStyle.Right;
            this.cbxSearchWay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSearchWay.FormattingEnabled = true;
            this.cbxSearchWay.Items.AddRange(new object[] {
            "من أول الحقل",
            "الحقل بالكامل",
            "أي جزء من الحقل",
            "آخر الحقل"});
            this.cbxSearchWay.Location = new System.Drawing.Point(253, 0);
            this.cbxSearchWay.Name = "cbxSearchWay";
            this.cbxSearchWay.Size = new System.Drawing.Size(121, 27);
            this.cbxSearchWay.TabIndex = 3;
            // 
            // lblSearchWay
            // 
            this.lblSearchWay.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblSearchWay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchWay.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSearchWay.Location = new System.Drawing.Point(374, 0);
            this.lblSearchWay.Name = "lblSearchWay";
            this.lblSearchWay.Size = new System.Drawing.Size(86, 31);
            this.lblSearchWay.TabIndex = 2;
            this.lblSearchWay.Text = "طريقة البحث :";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(460, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(14, 31);
            this.panel1.TabIndex = 7;
            // 
            // cbxSearchIn
            // 
            this.cbxSearchIn.Dock = System.Windows.Forms.DockStyle.Right;
            this.cbxSearchIn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSearchIn.FormattingEnabled = true;
            this.cbxSearchIn.Location = new System.Drawing.Point(474, 0);
            this.cbxSearchIn.Name = "cbxSearchIn";
            this.cbxSearchIn.Size = new System.Drawing.Size(121, 27);
            this.cbxSearchIn.TabIndex = 3;
            // 
            // lblSearchIn
            // 
            this.lblSearchIn.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblSearchIn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchIn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSearchIn.Location = new System.Drawing.Point(595, 0);
            this.lblSearchIn.Name = "lblSearchIn";
            this.lblSearchIn.Size = new System.Drawing.Size(71, 31);
            this.lblSearchIn.TabIndex = 2;
            this.lblSearchIn.Text = "بحث في :";
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(666, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(14, 31);
            this.panel2.TabIndex = 8;
            // 
            // tbxSearchFor
            // 
            this.tbxSearchFor.Dock = System.Windows.Forms.DockStyle.Right;
            this.tbxSearchFor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSearchFor.Location = new System.Drawing.Point(680, 0);
            this.tbxSearchFor.Name = "tbxSearchFor";
            this.tbxSearchFor.Size = new System.Drawing.Size(100, 26);
            this.tbxSearchFor.TabIndex = 1;
            this.tbxSearchFor.TextChanged += new System.EventHandler(this.tbxSearchFor_TextChanged);
            // 
            // lblSearchFor
            // 
            this.lblSearchFor.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblSearchFor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchFor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSearchFor.Location = new System.Drawing.Point(780, 0);
            this.lblSearchFor.Name = "lblSearchFor";
            this.lblSearchFor.Size = new System.Drawing.Size(73, 31);
            this.lblSearchFor.TabIndex = 0;
            this.lblSearchFor.Text = "بحث عن :";
            // 
            // pnlSepBegin
            // 
            this.pnlSepBegin.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlSepBegin.Location = new System.Drawing.Point(853, 0);
            this.pnlSepBegin.Name = "pnlSepBegin";
            this.pnlSepBegin.Size = new System.Drawing.Size(67, 31);
            this.pnlSepBegin.TabIndex = 6;
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.lblTableName);
            this.pnlTop.Controls.Add(this.lblSearchTable);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(920, 49);
            this.pnlTop.TabIndex = 4;
            // 
            // lblTableName
            // 
            this.lblTableName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTableName.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableName.Location = new System.Drawing.Point(203, 11);
            this.lblTableName.Name = "lblTableName";
            this.lblTableName.Size = new System.Drawing.Size(417, 26);
            this.lblTableName.TabIndex = 1;
            this.lblTableName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSearchTable
            // 
            this.lblSearchTable.AutoSize = true;
            this.lblSearchTable.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchTable.Location = new System.Drawing.Point(627, 11);
            this.lblSearchTable.Name = "lblSearchTable";
            this.lblSearchTable.Size = new System.Drawing.Size(91, 24);
            this.lblSearchTable.TabIndex = 0;
            this.lblSearchTable.Text = "البحث في : ";
            // 
            // dgvSearchRes
            // 
            this.dgvSearchRes.AllowUserToAddRows = false;
            this.dgvSearchRes.AllowUserToDeleteRows = false;
            this.dgvSearchRes.AllowUserToOrderColumns = true;
            this.dgvSearchRes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchRes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSearchRes.Location = new System.Drawing.Point(0, 80);
            this.dgvSearchRes.Name = "dgvSearchRes";
            this.dgvSearchRes.ReadOnly = true;
            this.dgvSearchRes.Size = new System.Drawing.Size(920, 471);
            this.dgvSearchRes.TabIndex = 5;
            this.dgvSearchRes.DoubleClick += new System.EventHandler(this.dgvSearchRes_DoubleClick);
            // 
            // frmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(920, 551);
            this.Controls.Add(this.dgvSearchRes);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.pnlTop);
            this.MaximizeBox = false;
            this.Name = "frmSearch";
            this.Text = "نظام تخطيط موارد المؤسسات - محرك البحث";
            ((System.ComponentModel.ISupportInitialize)(this.errprvForm)).EndInit();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchRes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cbxSearchWay;
        private System.Windows.Forms.Label lblSearchWay;
        private System.Windows.Forms.ComboBox cbxSearchIn;
        private System.Windows.Forms.Label lblSearchIn;
        private System.Windows.Forms.TextBox tbxSearchFor;
        private System.Windows.Forms.Label lblSearchFor;
        private System.Windows.Forms.Panel pnlSepBtnSearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlSepBegin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblSearchTable;
        private System.Windows.Forms.Label lblTableName;
        private System.Windows.Forms.Panel pnlSepBtnCheckBox;
        private System.Windows.Forms.CheckBox chkbxInstantSearch;
        private System.Windows.Forms.DataGridView dgvSearchRes;
    }
}
