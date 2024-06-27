namespace ItemsManager.Items
{
    partial class frmItemsUnitsConversions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmItemsUnitsConversions));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tvcmbCategory = new CustomControls.ucTreeViewComboBox();
            this.cmbToUnitTypeID = new System.Windows.Forms.ComboBox();
            this.lblToUnitTypeID = new System.Windows.Forms.Label();
            this.txtnQuantity = new CustomControls.NumericTextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.cmbItemID = new System.Windows.Forms.ComboBox();
            this.lblItemID = new System.Windows.Forms.Label();
            this.cmbToUnitID = new System.Windows.Forms.ComboBox();
            this.lblToUnitID = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.dgvItemUnitsConversions = new System.Windows.Forms.DataGridView();
            this.lblFromUnitID = new System.Windows.Forms.Label();
            this.cmbFromUnitID = new System.Windows.Forms.ComboBox();
            this.dgtxtcID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgtxtcUnitName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgtxtcToUnitName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgtxtcQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errprvForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemUnitsConversions)).BeginInit();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(262, 14);
            // 
            // pnlControls
            // 
            this.pnlControls.Controls.Add(this.tvcmbCategory);
            this.pnlControls.Controls.Add(this.cmbToUnitTypeID);
            this.pnlControls.Controls.Add(this.lblToUnitTypeID);
            this.pnlControls.Controls.Add(this.txtnQuantity);
            this.pnlControls.Controls.Add(this.lblQuantity);
            this.pnlControls.Controls.Add(this.cmbItemID);
            this.pnlControls.Controls.Add(this.lblItemID);
            this.pnlControls.Controls.Add(this.cmbFromUnitID);
            this.pnlControls.Controls.Add(this.cmbToUnitID);
            this.pnlControls.Controls.Add(this.lblFromUnitID);
            this.pnlControls.Controls.Add(this.lblToUnitID);
            this.pnlControls.Controls.Add(this.lblCategory);
            this.pnlControls.Size = new System.Drawing.Size(440, 209);
            this.pnlControls.Controls.SetChildIndex(this.txtID, 0);
            this.pnlControls.Controls.SetChildIndex(this.lblID, 0);
            this.pnlControls.Controls.SetChildIndex(this.lblCategory, 0);
            this.pnlControls.Controls.SetChildIndex(this.lblToUnitID, 0);
            this.pnlControls.Controls.SetChildIndex(this.lblFromUnitID, 0);
            this.pnlControls.Controls.SetChildIndex(this.cmbToUnitID, 0);
            this.pnlControls.Controls.SetChildIndex(this.cmbFromUnitID, 0);
            this.pnlControls.Controls.SetChildIndex(this.lblItemID, 0);
            this.pnlControls.Controls.SetChildIndex(this.cmbItemID, 0);
            this.pnlControls.Controls.SetChildIndex(this.lblQuantity, 0);
            this.pnlControls.Controls.SetChildIndex(this.txtnQuantity, 0);
            this.pnlControls.Controls.SetChildIndex(this.lblToUnitTypeID, 0);
            this.pnlControls.Controls.SetChildIndex(this.cmbToUnitTypeID, 0);
            this.pnlControls.Controls.SetChildIndex(this.tvcmbCategory, 0);
            // 
            // lblID
            // 
            this.lblID.Location = new System.Drawing.Point(340, 14);
            // 
            // tvcmbCategory
            // 
            this.tvcmbCategory.Direction = CustomControls.ucTreeViewComboBox.Directions.rtl;
            this.tvcmbCategory.Location = new System.Drawing.Point(37, 40);
            this.tvcmbCategory.Name = "tvcmbCategory";
            this.tvcmbCategory.RecursiveTable = true;
            this.tvcmbCategory.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tvcmbCategory.SelectedValue = ((object)(resources.GetObject("tvcmbCategory.SelectedValue")));
            this.tvcmbCategory.SelectionLevel = -1;
            this.tvcmbCategory.Size = new System.Drawing.Size(279, 21);
            this.tvcmbCategory.TabIndex = 24;
            this.tvcmbCategory.Tag = "1";
            this.tvcmbCategory.AfterSelect += new CustomControls.ucTreeViewComboBox.AfterSelectHandler(this.tvcmbCategory_AfterSelect);
            // 
            // cmbToUnitTypeID
            // 
            this.cmbToUnitTypeID.FormattingEnabled = true;
            this.cmbToUnitTypeID.Location = new System.Drawing.Point(37, 121);
            this.cmbToUnitTypeID.Name = "cmbToUnitTypeID";
            this.cmbToUnitTypeID.Size = new System.Drawing.Size(279, 21);
            this.cmbToUnitTypeID.TabIndex = 32;
            this.cmbToUnitTypeID.Tag = "1";
            this.cmbToUnitTypeID.SelectedIndexChanged += new System.EventHandler(this.cmbToUnitTypeID_SelectedIndexChanged);
            // 
            // lblToUnitTypeID
            // 
            this.lblToUnitTypeID.AutoSize = true;
            this.lblToUnitTypeID.Location = new System.Drawing.Point(322, 121);
            this.lblToUnitTypeID.Name = "lblToUnitTypeID";
            this.lblToUnitTypeID.Size = new System.Drawing.Size(81, 13);
            this.lblToUnitTypeID.TabIndex = 31;
            this.lblToUnitTypeID.Text = "إلى نوع الوحدة :";
            // 
            // txtnQuantity
            // 
            this.txtnQuantity.IsInt = false;
            this.txtnQuantity.Location = new System.Drawing.Point(262, 175);
            this.txtnQuantity.MaxLength = 7;
            this.txtnQuantity.Name = "txtnQuantity";
            this.txtnQuantity.Size = new System.Drawing.Size(54, 20);
            this.txtnQuantity.TabIndex = 30;
            this.txtnQuantity.Tag = "1";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(360, 175);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(43, 13);
            this.lblQuantity.TabIndex = 29;
            this.lblQuantity.Text = "الكمية :";
            // 
            // cmbItemID
            // 
            this.cmbItemID.FormattingEnabled = true;
            this.cmbItemID.Location = new System.Drawing.Point(37, 67);
            this.cmbItemID.Name = "cmbItemID";
            this.cmbItemID.Size = new System.Drawing.Size(279, 21);
            this.cmbItemID.TabIndex = 28;
            this.cmbItemID.Tag = "1";
            this.cmbItemID.SelectedIndexChanged += new System.EventHandler(this.cmbItemID_SelectedIndexChanged);
            // 
            // lblItemID
            // 
            this.lblItemID.AutoSize = true;
            this.lblItemID.Location = new System.Drawing.Point(360, 67);
            this.lblItemID.Name = "lblItemID";
            this.lblItemID.Size = new System.Drawing.Size(43, 13);
            this.lblItemID.TabIndex = 27;
            this.lblItemID.Text = "الصنف :";
            // 
            // cmbToUnitID
            // 
            this.cmbToUnitID.FormattingEnabled = true;
            this.cmbToUnitID.Location = new System.Drawing.Point(37, 148);
            this.cmbToUnitID.Name = "cmbToUnitID";
            this.cmbToUnitID.Size = new System.Drawing.Size(279, 21);
            this.cmbToUnitID.TabIndex = 26;
            this.cmbToUnitID.Tag = "1";
            // 
            // lblToUnitID
            // 
            this.lblToUnitID.AutoSize = true;
            this.lblToUnitID.Location = new System.Drawing.Point(340, 148);
            this.lblToUnitID.Name = "lblToUnitID";
            this.lblToUnitID.Size = new System.Drawing.Size(63, 13);
            this.lblToUnitID.TabIndex = 25;
            this.lblToUnitID.Text = "إلى الوحدة :";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(352, 40);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(51, 13);
            this.lblCategory.TabIndex = 23;
            this.lblCategory.Text = "التصنيف :";
            // 
            // dgvItemUnitsConversions
            // 
            this.dgvItemUnitsConversions.AllowUserToAddRows = false;
            this.dgvItemUnitsConversions.AllowUserToDeleteRows = false;
            this.dgvItemUnitsConversions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemUnitsConversions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgtxtcID,
            this.dgtxtcUnitName,
            this.dgtxtcToUnitName,
            this.dgtxtcQuantity});
            this.dgvItemUnitsConversions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvItemUnitsConversions.Location = new System.Drawing.Point(0, 234);
            this.dgvItemUnitsConversions.Name = "dgvItemUnitsConversions";
            this.dgvItemUnitsConversions.Size = new System.Drawing.Size(440, 195);
            this.dgvItemUnitsConversions.TabIndex = 23;
            this.dgvItemUnitsConversions.DoubleClick += new System.EventHandler(this.dgvItemUnits_DoubleClick);
            // 
            // lblFromUnitID
            // 
            this.lblFromUnitID.AutoSize = true;
            this.lblFromUnitID.Location = new System.Drawing.Point(343, 93);
            this.lblFromUnitID.Name = "lblFromUnitID";
            this.lblFromUnitID.Size = new System.Drawing.Size(60, 13);
            this.lblFromUnitID.TabIndex = 25;
            this.lblFromUnitID.Text = "من الوحدة :";
            // 
            // cmbFromUnitID
            // 
            this.cmbFromUnitID.FormattingEnabled = true;
            this.cmbFromUnitID.Location = new System.Drawing.Point(37, 94);
            this.cmbFromUnitID.Name = "cmbFromUnitID";
            this.cmbFromUnitID.Size = new System.Drawing.Size(279, 21);
            this.cmbFromUnitID.TabIndex = 26;
            this.cmbFromUnitID.Tag = "1";
            // 
            // dgtxtcID
            // 
            this.dgtxtcID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgtxtcID.DataPropertyName = "ID";
            this.dgtxtcID.HeaderText = "المسلسل";
            this.dgtxtcID.Name = "dgtxtcID";
            this.dgtxtcID.ReadOnly = true;
            this.dgtxtcID.Width = 81;
            // 
            // dgtxtcUnitName
            // 
            this.dgtxtcUnitName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgtxtcUnitName.DataPropertyName = "FromUnitName";
            this.dgtxtcUnitName.HeaderText = "من الوحدة";
            this.dgtxtcUnitName.Name = "dgtxtcUnitName";
            this.dgtxtcUnitName.ReadOnly = true;
            this.dgtxtcUnitName.Width = 78;
            // 
            // dgtxtcToUnitName
            // 
            this.dgtxtcToUnitName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgtxtcToUnitName.DataPropertyName = "ToUnitName";
            this.dgtxtcToUnitName.HeaderText = "إلى الوحدة";
            this.dgtxtcToUnitName.Name = "dgtxtcToUnitName";
            this.dgtxtcToUnitName.ReadOnly = true;
            this.dgtxtcToUnitName.Width = 81;
            // 
            // dgtxtcQuantity
            // 
            this.dgtxtcQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgtxtcQuantity.DataPropertyName = "Quantity";
            dataGridViewCellStyle1.Format = "N2";
            this.dgtxtcQuantity.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgtxtcQuantity.HeaderText = "الكمية";
            this.dgtxtcQuantity.Name = "dgtxtcQuantity";
            this.dgtxtcQuantity.ReadOnly = true;
            this.dgtxtcQuantity.Width = 61;
            // 
            // frmItemsUnitsConversions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(440, 429);
            this.Controls.Add(this.dgvItemUnitsConversions);
            this.Name = "frmItemsUnitsConversions";
            this.Text = "مدير الأصناف - تحويلات وحدات الأصناف";
            this.Load += new System.EventHandler(this.frmItemsUnitsConversions_Load);
            this.Controls.SetChildIndex(this.dgvItemUnitsConversions, 0);
            this.Controls.SetChildIndex(this.pnlControls, 0);
            this.pnlControls.ResumeLayout(false);
            this.pnlControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errprvForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemUnitsConversions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.ucTreeViewComboBox tvcmbCategory;
        private System.Windows.Forms.ComboBox cmbToUnitTypeID;
        private System.Windows.Forms.Label lblToUnitTypeID;
        private CustomControls.NumericTextBox txtnQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.ComboBox cmbItemID;
        private System.Windows.Forms.Label lblItemID;
        private System.Windows.Forms.ComboBox cmbToUnitID;
        private System.Windows.Forms.Label lblToUnitID;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.DataGridView dgvItemUnitsConversions;
        private System.Windows.Forms.ComboBox cmbFromUnitID;
        private System.Windows.Forms.Label lblFromUnitID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgtxtcID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgtxtcUnitName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgtxtcToUnitName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgtxtcQuantity;
    }
}
