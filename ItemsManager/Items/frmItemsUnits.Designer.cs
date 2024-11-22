namespace ItemsManager.Items
{
    partial class frmItemsUnits
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmItemsUnits));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tvcmbCategory = new CustomControls.ucTreeViewComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cmbItemID = new System.Windows.Forms.ComboBox();
            this.lblItemID = new System.Windows.Forms.Label();
            this.cmbUnitID = new System.Windows.Forms.ComboBox();
            this.lblUnitID = new System.Windows.Forms.Label();
            this.txtnUnitPrice = new CustomControls.NumericTextBox();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.chkIsDefault = new System.Windows.Forms.CheckBox();
            this.dgvItemUnits = new System.Windows.Forms.DataGridView();
            this.dgtxtcID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgtxtcUnitID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgtxtcUnitName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgtxtcQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgbcIsDefault = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cmbTypeID = new System.Windows.Forms.ComboBox();
            this.lblTypeID = new System.Windows.Forms.Label();
            this.lblPound = new System.Windows.Forms.Label();
            this.pnlControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errprvForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemUnits)).BeginInit();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(311, 15);
            this.txtID.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            // 
            // pnlControls
            // 
            this.pnlControls.Controls.Add(this.tvcmbCategory);
            this.pnlControls.Controls.Add(this.lblPound);
            this.pnlControls.Controls.Add(this.cmbTypeID);
            this.pnlControls.Controls.Add(this.lblTypeID);
            this.pnlControls.Controls.Add(this.chkIsDefault);
            this.pnlControls.Controls.Add(this.txtnUnitPrice);
            this.pnlControls.Controls.Add(this.lblUnitPrice);
            this.pnlControls.Controls.Add(this.cmbItemID);
            this.pnlControls.Controls.Add(this.lblItemID);
            this.pnlControls.Controls.Add(this.cmbUnitID);
            this.pnlControls.Controls.Add(this.lblUnitID);
            this.pnlControls.Controls.Add(this.lblCategory);
            this.pnlControls.Location = new System.Drawing.Point(0, 31);
            this.pnlControls.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pnlControls.Size = new System.Drawing.Size(487, 247);
            this.pnlControls.Controls.SetChildIndex(this.txtID, 0);
            this.pnlControls.Controls.SetChildIndex(this.lblID, 0);
            this.pnlControls.Controls.SetChildIndex(this.lblCategory, 0);
            this.pnlControls.Controls.SetChildIndex(this.lblUnitID, 0);
            this.pnlControls.Controls.SetChildIndex(this.cmbUnitID, 0);
            this.pnlControls.Controls.SetChildIndex(this.lblItemID, 0);
            this.pnlControls.Controls.SetChildIndex(this.cmbItemID, 0);
            this.pnlControls.Controls.SetChildIndex(this.lblUnitPrice, 0);
            this.pnlControls.Controls.SetChildIndex(this.txtnUnitPrice, 0);
            this.pnlControls.Controls.SetChildIndex(this.chkIsDefault, 0);
            this.pnlControls.Controls.SetChildIndex(this.lblTypeID, 0);
            this.pnlControls.Controls.SetChildIndex(this.cmbTypeID, 0);
            this.pnlControls.Controls.SetChildIndex(this.lblPound, 0);
            this.pnlControls.Controls.SetChildIndex(this.tvcmbCategory, 0);
            // 
            // lblID
            // 
            this.lblID.Location = new System.Drawing.Point(391, 15);
            this.lblID.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            // 
            // tvcmbCategory
            // 
            this.tvcmbCategory.Direction = CustomControls.ucTreeViewComboBox.Directions.rtl;
            this.tvcmbCategory.Location = new System.Drawing.Point(11, 47);
            this.tvcmbCategory.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tvcmbCategory.Name = "tvcmbCategory";
            this.tvcmbCategory.RecursiveTable = true;
            this.tvcmbCategory.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tvcmbCategory.SelectedValue = ((object)(resources.GetObject("tvcmbCategory.SelectedValue")));
            this.tvcmbCategory.SelectionLevel = -1;
            this.tvcmbCategory.Size = new System.Drawing.Size(372, 26);
            this.tvcmbCategory.TabIndex = 13;
            this.tvcmbCategory.Tag = "1";
            this.tvcmbCategory.AfterSelect += new CustomControls.ucTreeViewComboBox.AfterSelectHandler(this.tvcmbCategory_AfterSelect);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(407, 47);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(51, 16);
            this.lblCategory.TabIndex = 12;
            this.lblCategory.Text = "التصنيف :";
            // 
            // cmbItemID
            // 
            this.cmbItemID.FormattingEnabled = true;
            this.cmbItemID.Location = new System.Drawing.Point(11, 80);
            this.cmbItemID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbItemID.Name = "cmbItemID";
            this.cmbItemID.Size = new System.Drawing.Size(371, 24);
            this.cmbItemID.TabIndex = 17;
            this.cmbItemID.Tag = "1";
            this.cmbItemID.SelectedIndexChanged += new System.EventHandler(this.cmbItemID_SelectedIndexChanged);
            // 
            // lblItemID
            // 
            this.lblItemID.AutoSize = true;
            this.lblItemID.Location = new System.Drawing.Point(417, 80);
            this.lblItemID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItemID.Name = "lblItemID";
            this.lblItemID.Size = new System.Drawing.Size(43, 16);
            this.lblItemID.TabIndex = 16;
            this.lblItemID.Text = "الصنف :";
            // 
            // cmbUnitID
            // 
            this.cmbUnitID.FormattingEnabled = true;
            this.cmbUnitID.Location = new System.Drawing.Point(11, 146);
            this.cmbUnitID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbUnitID.Name = "cmbUnitID";
            this.cmbUnitID.Size = new System.Drawing.Size(371, 24);
            this.cmbUnitID.TabIndex = 15;
            this.cmbUnitID.Tag = "1";
            // 
            // lblUnitID
            // 
            this.lblUnitID.AutoSize = true;
            this.lblUnitID.Location = new System.Drawing.Point(417, 146);
            this.lblUnitID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUnitID.Name = "lblUnitID";
            this.lblUnitID.Size = new System.Drawing.Size(44, 16);
            this.lblUnitID.TabIndex = 14;
            this.lblUnitID.Text = "الوحدة :";
            // 
            // txtnUnitPrice
            // 
            this.txtnUnitPrice.IsInt = false;
            this.txtnUnitPrice.Location = new System.Drawing.Point(311, 180);
            this.txtnUnitPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtnUnitPrice.MaxLength = 7;
            this.txtnUnitPrice.Name = "txtnUnitPrice";
            this.txtnUnitPrice.Size = new System.Drawing.Size(71, 22);
            this.txtnUnitPrice.TabIndex = 19;
            this.txtnUnitPrice.Tag = "1";
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(417, 180);
            this.lblUnitPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(40, 16);
            this.lblUnitPrice.TabIndex = 18;
            this.lblUnitPrice.Text = "السعر :";
            // 
            // chkIsDefault
            // 
            this.chkIsDefault.AutoSize = true;
            this.chkIsDefault.Location = new System.Drawing.Point(340, 212);
            this.chkIsDefault.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkIsDefault.Name = "chkIsDefault";
            this.chkIsDefault.Size = new System.Drawing.Size(101, 20);
            this.chkIsDefault.TabIndex = 20;
            this.chkIsDefault.Text = "الوحدة الرئيسية";
            this.chkIsDefault.UseVisualStyleBackColor = true;
            // 
            // dgvItemUnits
            // 
            this.dgvItemUnits.AllowUserToAddRows = false;
            this.dgvItemUnits.AllowUserToDeleteRows = false;
            this.dgvItemUnits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemUnits.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgtxtcID,
            this.dgtxtcUnitID,
            this.dgtxtcUnitName,
            this.dgtxtcQuantity,
            this.dgbcIsDefault});
            this.dgvItemUnits.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvItemUnits.Location = new System.Drawing.Point(0, 278);
            this.dgvItemUnits.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvItemUnits.Name = "dgvItemUnits";
            this.dgvItemUnits.RowHeadersWidth = 51;
            this.dgvItemUnits.Size = new System.Drawing.Size(487, 207);
            this.dgvItemUnits.TabIndex = 22;
            this.dgvItemUnits.DoubleClick += new System.EventHandler(this.dgvItemUnits_DoubleClick);
            // 
            // dgtxtcID
            // 
            this.dgtxtcID.DataPropertyName = "ID";
            this.dgtxtcID.HeaderText = "ID";
            this.dgtxtcID.MinimumWidth = 6;
            this.dgtxtcID.Name = "dgtxtcID";
            this.dgtxtcID.Visible = false;
            this.dgtxtcID.Width = 125;
            // 
            // dgtxtcUnitID
            // 
            this.dgtxtcUnitID.DataPropertyName = "UnitID";
            this.dgtxtcUnitID.HeaderText = "UnitID";
            this.dgtxtcUnitID.MinimumWidth = 6;
            this.dgtxtcUnitID.Name = "dgtxtcUnitID";
            this.dgtxtcUnitID.Visible = false;
            this.dgtxtcUnitID.Width = 125;
            // 
            // dgtxtcUnitName
            // 
            this.dgtxtcUnitName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgtxtcUnitName.DataPropertyName = "Name";
            this.dgtxtcUnitName.HeaderText = "الوحدة";
            this.dgtxtcUnitName.MinimumWidth = 6;
            this.dgtxtcUnitName.Name = "dgtxtcUnitName";
            this.dgtxtcUnitName.ReadOnly = true;
            this.dgtxtcUnitName.Width = 67;
            // 
            // dgtxtcQuantity
            // 
            this.dgtxtcQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgtxtcQuantity.DataPropertyName = "UnitPrice";
            dataGridViewCellStyle4.Format = "N2";
            this.dgtxtcQuantity.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgtxtcQuantity.HeaderText = "السعر";
            this.dgtxtcQuantity.MinimumWidth = 6;
            this.dgtxtcQuantity.Name = "dgtxtcQuantity";
            this.dgtxtcQuantity.ReadOnly = true;
            this.dgtxtcQuantity.Width = 63;
            // 
            // dgbcIsDefault
            // 
            this.dgbcIsDefault.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgbcIsDefault.DataPropertyName = "IsDefault";
            this.dgbcIsDefault.HeaderText = "رئيسية";
            this.dgbcIsDefault.MinimumWidth = 6;
            this.dgbcIsDefault.Name = "dgbcIsDefault";
            this.dgbcIsDefault.ReadOnly = true;
            this.dgbcIsDefault.Width = 45;
            // 
            // cmbTypeID
            // 
            this.cmbTypeID.FormattingEnabled = true;
            this.cmbTypeID.Location = new System.Drawing.Point(11, 113);
            this.cmbTypeID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbTypeID.Name = "cmbTypeID";
            this.cmbTypeID.Size = new System.Drawing.Size(371, 24);
            this.cmbTypeID.TabIndex = 22;
            this.cmbTypeID.Tag = "1";
            this.cmbTypeID.SelectedIndexChanged += new System.EventHandler(this.cmbTypeID_SelectedIndexChanged);
            // 
            // lblTypeID
            // 
            this.lblTypeID.AutoSize = true;
            this.lblTypeID.Location = new System.Drawing.Point(393, 113);
            this.lblTypeID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTypeID.Name = "lblTypeID";
            this.lblTypeID.Size = new System.Drawing.Size(65, 16);
            this.lblTypeID.TabIndex = 21;
            this.lblTypeID.Text = "نوع الوحدة :";
            // 
            // lblPound
            // 
            this.lblPound.AutoSize = true;
            this.lblPound.Location = new System.Drawing.Point(265, 180);
            this.lblPound.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPound.Name = "lblPound";
            this.lblPound.Size = new System.Drawing.Size(28, 16);
            this.lblPound.TabIndex = 23;
            this.lblPound.Text = "جنيه";
            // 
            // frmItemsUnits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(487, 485);
            this.Controls.Add(this.dgvItemUnits);
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "frmItemsUnits";
            this.Text = "مدير الأصناف - وحدات الأصناف";
            this.Load += new System.EventHandler(this.frmItemsUnits_Load);
            this.Controls.SetChildIndex(this.dgvItemUnits, 0);
            this.Controls.SetChildIndex(this.pnlControls, 0);
            this.pnlControls.ResumeLayout(false);
            this.pnlControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errprvForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemUnits)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.ucTreeViewComboBox tvcmbCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cmbItemID;
        private System.Windows.Forms.Label lblItemID;
        private System.Windows.Forms.ComboBox cmbUnitID;
        private System.Windows.Forms.Label lblUnitID;
        private System.Windows.Forms.CheckBox chkIsDefault;
        private CustomControls.NumericTextBox txtnUnitPrice;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.DataGridView dgvItemUnits;
        private System.Windows.Forms.ComboBox cmbTypeID;
        private System.Windows.Forms.Label lblTypeID;
        private System.Windows.Forms.Label lblPound;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgtxtcID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgtxtcUnitID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgtxtcUnitName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgtxtcQuantity;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgbcIsDefault;
    }
}
