namespace ItemsManager.Items
{
    partial class frmItems
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmItems));
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblBarCode = new System.Windows.Forms.Label();
            this.txtBarCode = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.tvcmbCategory = new CustomControls.ucTreeViewComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.BarCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUnits = new System.Windows.Forms.Button();
            this.btnUnitsConversions = new System.Windows.Forms.Button();
            this.pnlControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errprvForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(245, 20);
            // 
            // pnlControls
            // 
            this.pnlControls.Controls.Add(this.btnUnitsConversions);
            this.pnlControls.Controls.Add(this.btnUnits);
            this.pnlControls.Controls.Add(this.tvcmbCategory);
            this.pnlControls.Controls.Add(this.dgvItems);
            this.pnlControls.Controls.Add(this.lblCategory);
            this.pnlControls.Controls.Add(this.txtBarCode);
            this.pnlControls.Controls.Add(this.txtDescription);
            this.pnlControls.Controls.Add(this.txtName);
            this.pnlControls.Controls.Add(this.lblBarCode);
            this.pnlControls.Controls.Add(this.lblDescription);
            this.pnlControls.Controls.Add(this.lblName);
            this.pnlControls.Size = new System.Drawing.Size(407, 468);
            this.pnlControls.Controls.SetChildIndex(this.txtID, 0);
            this.pnlControls.Controls.SetChildIndex(this.lblID, 0);
            this.pnlControls.Controls.SetChildIndex(this.lblName, 0);
            this.pnlControls.Controls.SetChildIndex(this.lblDescription, 0);
            this.pnlControls.Controls.SetChildIndex(this.lblBarCode, 0);
            this.pnlControls.Controls.SetChildIndex(this.txtName, 0);
            this.pnlControls.Controls.SetChildIndex(this.txtDescription, 0);
            this.pnlControls.Controls.SetChildIndex(this.txtBarCode, 0);
            this.pnlControls.Controls.SetChildIndex(this.lblCategory, 0);
            this.pnlControls.Controls.SetChildIndex(this.dgvItems, 0);
            this.pnlControls.Controls.SetChildIndex(this.tvcmbCategory, 0);
            this.pnlControls.Controls.SetChildIndex(this.btnUnits, 0);
            this.pnlControls.Controls.SetChildIndex(this.btnUnitsConversions, 0);
            // 
            // lblID
            // 
            this.lblID.Location = new System.Drawing.Point(322, 20);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(21, 131);
            this.txtName.MaxLength = 50;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(279, 20);
            this.txtName.TabIndex = 8;
            this.txtName.Tag = "1";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(343, 131);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(43, 13);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "الاسم :";
            // 
            // lblBarCode
            // 
            this.lblBarCode.AutoSize = true;
            this.lblBarCode.Location = new System.Drawing.Point(339, 57);
            this.lblBarCode.Name = "lblBarCode";
            this.lblBarCode.Size = new System.Drawing.Size(46, 13);
            this.lblBarCode.TabIndex = 9;
            this.lblBarCode.Text = "الباركود :";
            // 
            // txtBarCode
            // 
            this.txtBarCode.Location = new System.Drawing.Point(20, 57);
            this.txtBarCode.MaxLength = 50;
            this.txtBarCode.Name = "txtBarCode";
            this.txtBarCode.Size = new System.Drawing.Size(279, 20);
            this.txtBarCode.TabIndex = 8;
            this.txtBarCode.Tag = "1";
            this.txtBarCode.Leave += new System.EventHandler(this.txtBarCode_Leave);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(341, 168);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(44, 13);
            this.lblDescription.TabIndex = 9;
            this.lblDescription.Text = "الوصف :";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(20, 168);
            this.txtDescription.MaxLength = 100;
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(279, 58);
            this.txtDescription.TabIndex = 8;
            this.txtDescription.Tag = "";
            // 
            // tvcmbCategory
            // 
            this.tvcmbCategory.Direction = CustomControls.ucTreeViewComboBox.Directions.rtl;
            this.tvcmbCategory.Location = new System.Drawing.Point(20, 94);
            this.tvcmbCategory.Name = "tvcmbCategory";
            this.tvcmbCategory.RecursiveTable = true;
            this.tvcmbCategory.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tvcmbCategory.SelectedValue = ((object)(resources.GetObject("tvcmbCategory.SelectedValue")));
            this.tvcmbCategory.SelectionLevel = -1;
            this.tvcmbCategory.Size = new System.Drawing.Size(279, 21);
            this.tvcmbCategory.TabIndex = 11;
            this.tvcmbCategory.AfterSelect += new CustomControls.ucTreeViewComboBox.AfterSelectHandler(this.tvcmbCategory_AfterSelect);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(334, 94);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(51, 13);
            this.lblCategory.TabIndex = 10;
            this.lblCategory.Text = "التصنيف :";
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
            this.dgvItems.Location = new System.Drawing.Point(0, 259);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.Size = new System.Drawing.Size(407, 209);
            this.dgvItems.TabIndex = 12;
            this.dgvItems.DoubleClick += new System.EventHandler(this.dgvItems_DoubleClick);
            // 
            // BarCode
            // 
            this.BarCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.BarCode.DataPropertyName = "BarCode";
            this.BarCode.HeaderText = "الباركود";
            this.BarCode.Name = "BarCode";
            this.BarCode.ReadOnly = true;
            this.BarCode.Width = 64;
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
            this.ItemName.Width = 86;
            // 
            // btnUnits
            // 
            this.btnUnits.Location = new System.Drawing.Point(246, 230);
            this.btnUnits.Name = "btnUnits";
            this.btnUnits.Size = new System.Drawing.Size(75, 23);
            this.btnUnits.TabIndex = 13;
            this.btnUnits.Text = "الوحدات";
            this.btnUnits.UseVisualStyleBackColor = true;
            this.btnUnits.Click += new System.EventHandler(this.btnUnits_Click);
            // 
            // btnUnitsConversions
            // 
            this.btnUnitsConversions.Location = new System.Drawing.Point(85, 230);
            this.btnUnitsConversions.Name = "btnUnitsConversions";
            this.btnUnitsConversions.Size = new System.Drawing.Size(90, 23);
            this.btnUnitsConversions.TabIndex = 13;
            this.btnUnitsConversions.Text = "تحويلات الوحدات";
            this.btnUnitsConversions.UseVisualStyleBackColor = true;
            this.btnUnitsConversions.Click += new System.EventHandler(this.btnUnitsConversions_Click);
            // 
            // frmItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(407, 493);
            this.Name = "frmItems";
            this.Text = "مدير الأصناف - الأصناف";
            this.Load += new System.EventHandler(this.frmItems_Load);
            this.pnlControls.ResumeLayout(false);
            this.pnlControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errprvForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBarCode;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblBarCode;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblName;
        private CustomControls.ucTreeViewComboBox tvcmbCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn BarCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.Button btnUnitsConversions;
        private System.Windows.Forms.Button btnUnits;
    }
}
