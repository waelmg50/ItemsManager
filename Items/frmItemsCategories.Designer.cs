namespace ItemsManager.Items
{
    partial class frmItemsCategories
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmItemsCategories));
            this.tvCategories = new System.Windows.Forms.TreeView();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblParentCategory = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.tvcmbParentCategory = new CustomControls.ucTreeViewComboBox();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.BarCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errprvForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(274, 21);
            this.txtID.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            // 
            // pnlControls
            // 
            this.pnlControls.Controls.Add(this.tvcmbParentCategory);
            this.pnlControls.Controls.Add(this.dgvItems);
            this.pnlControls.Controls.Add(this.txtName);
            this.pnlControls.Controls.Add(this.lblParentCategory);
            this.pnlControls.Controls.Add(this.lblName);
            this.pnlControls.Location = new System.Drawing.Point(265, 25);
            this.pnlControls.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pnlControls.Size = new System.Drawing.Size(449, 432);
            this.pnlControls.Controls.SetChildIndex(this.txtID, 0);
            this.pnlControls.Controls.SetChildIndex(this.lblID, 0);
            this.pnlControls.Controls.SetChildIndex(this.lblName, 0);
            this.pnlControls.Controls.SetChildIndex(this.lblParentCategory, 0);
            this.pnlControls.Controls.SetChildIndex(this.txtName, 0);
            this.pnlControls.Controls.SetChildIndex(this.dgvItems, 0);
            this.pnlControls.Controls.SetChildIndex(this.tvcmbParentCategory, 0);
            // 
            // lblID
            // 
            this.lblID.Location = new System.Drawing.Point(364, 21);
            // 
            // tvCategories
            // 
            this.tvCategories.Dock = System.Windows.Forms.DockStyle.Left;
            this.tvCategories.HideSelection = false;
            this.tvCategories.Location = new System.Drawing.Point(0, 25);
            this.tvCategories.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tvCategories.Name = "tvCategories";
            this.tvCategories.RightToLeftLayout = true;
            this.tvCategories.Size = new System.Drawing.Size(265, 432);
            this.tvCategories.TabIndex = 6;
            this.tvCategories.TabStop = false;
            this.tvCategories.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvCategories_AfterSelect);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(12, 58);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.MaxLength = 50;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(325, 24);
            this.txtName.TabIndex = 6;
            this.txtName.Tag = "1";
            // 
            // lblParentCategory
            // 
            this.lblParentCategory.AutoSize = true;
            this.lblParentCategory.Location = new System.Drawing.Point(352, 96);
            this.lblParentCategory.Name = "lblParentCategory";
            this.lblParentCategory.Size = new System.Drawing.Size(90, 17);
            this.lblParentCategory.TabIndex = 8;
            this.lblParentCategory.Text = "التصنيف الأب :";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(387, 58);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(53, 17);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "الاسم :";
            // 
            // tvcmbParentCategory
            // 
            this.tvcmbParentCategory.Direction = CustomControls.ucTreeViewComboBox.Directions.rtl;
            this.tvcmbParentCategory.Location = new System.Drawing.Point(12, 96);
            this.tvcmbParentCategory.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tvcmbParentCategory.Name = "tvcmbParentCategory";
            this.tvcmbParentCategory.RecursiveTable = true;
            this.tvcmbParentCategory.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tvcmbParentCategory.SelectedValue = ((object)(resources.GetObject("tvcmbParentCategory.SelectedValue")));
            this.tvcmbParentCategory.SelectionLevel = -1;
            this.tvcmbParentCategory.Size = new System.Drawing.Size(325, 30);
            this.tvcmbParentCategory.TabIndex = 9;
            this.tvcmbParentCategory.AfterSelect += new CustomControls.ucTreeViewComboBox.AfterSelectHandler(this.tvcmbParentCategory_AfterSelect);
            // 
            // dgvItems
            // 
            this.dgvItems.AllowUserToAddRows = false;
            this.dgvItems.AllowUserToDeleteRows = false;
            this.dgvItems.AllowUserToOrderColumns = true;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BarCode,
            this.ID,
            this.ItemName});
            this.dgvItems.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvItems.Location = new System.Drawing.Point(0, 150);
            this.dgvItems.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.Size = new System.Drawing.Size(449, 282);
            this.dgvItems.TabIndex = 10;
            this.dgvItems.DoubleClick += new System.EventHandler(this.dgvItems_DoubleClick);
            // 
            // BarCode
            // 
            this.BarCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.BarCode.DataPropertyName = "BarCode";
            this.BarCode.HeaderText = "الباركود";
            this.BarCode.Name = "BarCode";
            this.BarCode.ReadOnly = true;
            this.BarCode.Width = 74;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "المسلسل";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // ItemName
            // 
            this.ItemName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ItemName.DataPropertyName = "Name";
            this.ItemName.HeaderText = "اسم الصنف";
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            // 
            // frmItemsCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.ClientSize = new System.Drawing.Size(714, 457);
            this.Controls.Add(this.tvCategories);
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Name = "frmItemsCategories";
            this.Text = "مدير الأصناف - تصنيفات الأصناف";
            this.Load += new System.EventHandler(this.frmItemsCategories_Load);
            this.Controls.SetChildIndex(this.tvCategories, 0);
            this.Controls.SetChildIndex(this.pnlControls, 0);
            this.pnlControls.ResumeLayout(false);
            this.pnlControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errprvForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tvCategories;
        private CustomControls.ucTreeViewComboBox tvcmbParentCategory;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblParentCategory;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn BarCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
    }
}
