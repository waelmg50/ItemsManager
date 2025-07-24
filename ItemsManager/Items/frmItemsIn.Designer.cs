namespace ItemsManager.Items
{
    partial class frmItemsIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmItemsIn));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.txtTotalCash = new System.Windows.Forms.TextBox();
            this.lblTotalValue = new System.Windows.Forms.Label();
            this.pnlItemsInControls = new System.Windows.Forms.Panel();
            this.tvcmbCategory = new CustomControls.ucTreeViewComboBox();
            this.pnlSearchItems = new System.Windows.Forms.Panel();
            this.lblPound = new System.Windows.Forms.Label();
            this.txtnPurchasePrice = new CustomControls.NumericTextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtnQuantity = new CustomControls.NumericTextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.cmbUnitID = new System.Windows.Forms.ComboBox();
            this.lblUnitID = new System.Windows.Forms.Label();
            this.cmbItemID = new System.Windows.Forms.ComboBox();
            this.lblItemID = new System.Windows.Forms.Label();
            this.txtBarCode = new System.Windows.Forms.TextBox();
            this.lblItemCategory = new System.Windows.Forms.Label();
            this.lblBarCode = new System.Windows.Forms.Label();
            this.dgvItemsIn = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchasePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.cbxSupplier = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.tblDetails)).BeginInit();
            this.pnlControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errprvForm)).BeginInit();
            this.pnlFooter.SuspendLayout();
            this.pnlItemsInControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemsIn)).BeginInit();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(767, 10);
            this.txtID.Margin = new System.Windows.Forms.Padding(5);
            // 
            // pnlControls
            // 
            this.pnlControls.Controls.Add(this.pnlItemsInControls);
            this.pnlControls.Controls.Add(this.dgvItemsIn);
            this.pnlControls.Controls.Add(this.pnlFooter);
            this.pnlControls.Controls.Add(this.lblSupplier);
            this.pnlControls.Controls.Add(this.cbxSupplier);
            this.pnlControls.Location = new System.Drawing.Point(0, 31);
            this.pnlControls.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.pnlControls.Size = new System.Drawing.Size(919, 730);
            this.pnlControls.Controls.SetChildIndex(this.cbxSupplier, 0);
            this.pnlControls.Controls.SetChildIndex(this.lblSupplier, 0);
            this.pnlControls.Controls.SetChildIndex(this.pnlFooter, 0);
            this.pnlControls.Controls.SetChildIndex(this.dgvItemsIn, 0);
            this.pnlControls.Controls.SetChildIndex(this.pnlItemsInControls, 0);
            this.pnlControls.Controls.SetChildIndex(this.txtID, 0);
            this.pnlControls.Controls.SetChildIndex(this.lblID, 0);
            // 
            // lblID
            // 
            this.lblID.Location = new System.Drawing.Point(847, 14);
            this.lblID.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            // 
            // pnlFooter
            // 
            this.pnlFooter.Controls.Add(this.txtTotalCash);
            this.pnlFooter.Controls.Add(this.lblTotalValue);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 729);
            this.pnlFooter.Margin = new System.Windows.Forms.Padding(4);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(919, 1);
            this.pnlFooter.TabIndex = 2;
            // 
            // txtTotalCash
            // 
            this.txtTotalCash.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalCash.Location = new System.Drawing.Point(348, 20);
            this.txtTotalCash.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalCash.MaxLength = 50;
            this.txtTotalCash.Name = "txtTotalCash";
            this.txtTotalCash.Size = new System.Drawing.Size(224, 30);
            this.txtTotalCash.TabIndex = 1;
            // 
            // lblTotalValue
            // 
            this.lblTotalValue.AutoSize = true;
            this.lblTotalValue.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalValue.Location = new System.Drawing.Point(621, 20);
            this.lblTotalValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalValue.Name = "lblTotalValue";
            this.lblTotalValue.Size = new System.Drawing.Size(157, 23);
            this.lblTotalValue.TabIndex = 0;
            this.lblTotalValue.Text = "إجمالي قيمة الأصناف :";
            // 
            // pnlItemsInControls
            // 
            this.pnlItemsInControls.Controls.Add(this.tvcmbCategory);
            this.pnlItemsInControls.Controls.Add(this.pnlSearchItems);
            this.pnlItemsInControls.Controls.Add(this.lblPound);
            this.pnlItemsInControls.Controls.Add(this.txtnPurchasePrice);
            this.pnlItemsInControls.Controls.Add(this.lblPrice);
            this.pnlItemsInControls.Controls.Add(this.btnClean);
            this.pnlItemsInControls.Controls.Add(this.btnAdd);
            this.pnlItemsInControls.Controls.Add(this.txtnQuantity);
            this.pnlItemsInControls.Controls.Add(this.lblQuantity);
            this.pnlItemsInControls.Controls.Add(this.cmbUnitID);
            this.pnlItemsInControls.Controls.Add(this.lblUnitID);
            this.pnlItemsInControls.Controls.Add(this.cmbItemID);
            this.pnlItemsInControls.Controls.Add(this.lblItemID);
            this.pnlItemsInControls.Controls.Add(this.txtBarCode);
            this.pnlItemsInControls.Controls.Add(this.lblItemCategory);
            this.pnlItemsInControls.Controls.Add(this.lblBarCode);
            this.pnlItemsInControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlItemsInControls.Location = new System.Drawing.Point(0, 45);
            this.pnlItemsInControls.Margin = new System.Windows.Forms.Padding(4);
            this.pnlItemsInControls.Name = "pnlItemsInControls";
            this.pnlItemsInControls.Size = new System.Drawing.Size(919, 119);
            this.pnlItemsInControls.TabIndex = 3;
            // 
            // tvcmbCategory
            // 
            this.tvcmbCategory.Direction = CustomControls.ucTreeViewComboBox.Directions.rtl;
            this.tvcmbCategory.Location = new System.Drawing.Point(411, 10);
            this.tvcmbCategory.Margin = new System.Windows.Forms.Padding(5);
            this.tvcmbCategory.Name = "tvcmbCategory";
            this.tvcmbCategory.RecursiveTable = true;
            this.tvcmbCategory.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tvcmbCategory.SelectedValue = ((object)(resources.GetObject("tvcmbCategory.SelectedValue")));
            this.tvcmbCategory.SelectionLevel = -1;
            this.tvcmbCategory.Size = new System.Drawing.Size(211, 26);
            this.tvcmbCategory.TabIndex = 25;
            this.tvcmbCategory.Tag = "";
            this.tvcmbCategory.AfterSelect += new CustomControls.ucTreeViewComboBox.AfterSelectHandler(this.tvcmbCategory_AfterSelect);
            // 
            // pnlSearchItems
            // 
            this.pnlSearchItems.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlSearchItems.BackgroundImage")));
            this.pnlSearchItems.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlSearchItems.Location = new System.Drawing.Point(92, 7);
            this.pnlSearchItems.Name = "pnlSearchItems";
            this.pnlSearchItems.Size = new System.Drawing.Size(30, 30);
            this.pnlSearchItems.TabIndex = 39;
            this.pnlSearchItems.Click += new System.EventHandler(this.pnlSearchItems_Click);
            // 
            // lblPound
            // 
            this.lblPound.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPound.AutoSize = true;
            this.lblPound.Location = new System.Drawing.Point(138, 52);
            this.lblPound.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPound.Name = "lblPound";
            this.lblPound.Size = new System.Drawing.Size(28, 16);
            this.lblPound.TabIndex = 38;
            this.lblPound.Text = "جنيه";
            // 
            // txtnPurchasePrice
            // 
            this.txtnPurchasePrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtnPurchasePrice.IsInt = false;
            this.txtnPurchasePrice.Location = new System.Drawing.Point(206, 46);
            this.txtnPurchasePrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtnPurchasePrice.MaxLength = 7;
            this.txtnPurchasePrice.Name = "txtnPurchasePrice";
            this.txtnPurchasePrice.Size = new System.Drawing.Size(131, 22);
            this.txtnPurchasePrice.TabIndex = 37;
            this.txtnPurchasePrice.Tag = "";
            this.txtnPurchasePrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnQuantity_KeyDown);
            this.txtnPurchasePrice.Leave += new System.EventHandler(this.txtnPurchasePrice_Leave);
            // 
            // lblPrice
            // 
            this.lblPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(349, 46);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(40, 16);
            this.lblPrice.TabIndex = 36;
            this.lblPrice.Text = "السعر :";
            // 
            // btnClean
            // 
            this.btnClean.Location = new System.Drawing.Point(5, 79);
            this.btnClean.Margin = new System.Windows.Forms.Padding(4);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(100, 28);
            this.btnClean.TabIndex = 35;
            this.btnClean.Text = "تنظيف";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(116, 79);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 28);
            this.btnAdd.TabIndex = 35;
            this.btnAdd.Text = "إضافة";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtnQuantity
            // 
            this.txtnQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtnQuantity.IsInt = false;
            this.txtnQuantity.Location = new System.Drawing.Point(706, 46);
            this.txtnQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.txtnQuantity.MaxLength = 7;
            this.txtnQuantity.Name = "txtnQuantity";
            this.txtnQuantity.Size = new System.Drawing.Size(132, 22);
            this.txtnQuantity.TabIndex = 34;
            this.txtnQuantity.Tag = "";
            this.txtnQuantity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnQuantity_KeyDown);
            this.txtnQuantity.Leave += new System.EventHandler(this.txtnQuantity_Leave);
            // 
            // lblQuantity
            // 
            this.lblQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(861, 46);
            this.lblQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(42, 16);
            this.lblQuantity.TabIndex = 33;
            this.lblQuantity.Text = "الكمية :";
            // 
            // cmbUnitID
            // 
            this.cmbUnitID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbUnitID.FormattingEnabled = true;
            this.cmbUnitID.Location = new System.Drawing.Point(411, 46);
            this.cmbUnitID.Margin = new System.Windows.Forms.Padding(4);
            this.cmbUnitID.Name = "cmbUnitID";
            this.cmbUnitID.Size = new System.Drawing.Size(209, 24);
            this.cmbUnitID.TabIndex = 32;
            this.cmbUnitID.Tag = "";
            // 
            // lblUnitID
            // 
            this.lblUnitID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUnitID.AutoSize = true;
            this.lblUnitID.Location = new System.Drawing.Point(641, 46);
            this.lblUnitID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUnitID.Name = "lblUnitID";
            this.lblUnitID.Size = new System.Drawing.Size(44, 16);
            this.lblUnitID.TabIndex = 31;
            this.lblUnitID.Text = "الوحدة :";
            // 
            // cmbItemID
            // 
            this.cmbItemID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbItemID.FormattingEnabled = true;
            this.cmbItemID.Location = new System.Drawing.Point(138, 10);
            this.cmbItemID.Margin = new System.Windows.Forms.Padding(4);
            this.cmbItemID.Name = "cmbItemID";
            this.cmbItemID.Size = new System.Drawing.Size(199, 24);
            this.cmbItemID.TabIndex = 30;
            this.cmbItemID.Tag = "";
            this.cmbItemID.SelectedIndexChanged += new System.EventHandler(this.cmbItemID_SelectedIndexChanged);
            // 
            // lblItemID
            // 
            this.lblItemID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblItemID.AutoSize = true;
            this.lblItemID.Location = new System.Drawing.Point(346, 14);
            this.lblItemID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItemID.Name = "lblItemID";
            this.lblItemID.Size = new System.Drawing.Size(43, 16);
            this.lblItemID.TabIndex = 29;
            this.lblItemID.Text = "الصنف :";
            // 
            // txtBarCode
            // 
            this.txtBarCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBarCode.Location = new System.Drawing.Point(706, 11);
            this.txtBarCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtBarCode.MaxLength = 50;
            this.txtBarCode.Name = "txtBarCode";
            this.txtBarCode.Size = new System.Drawing.Size(132, 22);
            this.txtBarCode.TabIndex = 1;
            this.txtBarCode.Tag = "";
            this.txtBarCode.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtBarCode_PreviewKeyDown);
            // 
            // lblItemCategory
            // 
            this.lblItemCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblItemCategory.AutoSize = true;
            this.lblItemCategory.Location = new System.Drawing.Point(630, 14);
            this.lblItemCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItemCategory.Name = "lblItemCategory";
            this.lblItemCategory.Size = new System.Drawing.Size(51, 16);
            this.lblItemCategory.TabIndex = 0;
            this.lblItemCategory.Text = "التصنيف :";
            // 
            // lblBarCode
            // 
            this.lblBarCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBarCode.AutoSize = true;
            this.lblBarCode.Location = new System.Drawing.Point(847, 14);
            this.lblBarCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBarCode.Name = "lblBarCode";
            this.lblBarCode.Size = new System.Drawing.Size(53, 16);
            this.lblBarCode.TabIndex = 0;
            this.lblBarCode.Text = "الباركود :";
            // 
            // dgvItemsIn
            // 
            this.dgvItemsIn.AllowUserToAddRows = false;
            this.dgvItemsIn.AllowUserToDeleteRows = false;
            this.dgvItemsIn.AllowUserToOrderColumns = true;
            this.dgvItemsIn.AllowUserToResizeColumns = false;
            this.dgvItemsIn.AllowUserToResizeRows = false;
            this.dgvItemsIn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemsIn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.ItemID,
            this.ItemName,
            this.Quantity,
            this.UnitID,
            this.UnitName,
            this.PurchasePrice});
            this.dgvItemsIn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvItemsIn.Location = new System.Drawing.Point(0, 164);
            this.dgvItemsIn.Margin = new System.Windows.Forms.Padding(4);
            this.dgvItemsIn.MultiSelect = false;
            this.dgvItemsIn.Name = "dgvItemsIn";
            this.dgvItemsIn.RowHeadersWidth = 51;
            this.dgvItemsIn.Size = new System.Drawing.Size(919, 565);
            this.dgvItemsIn.TabIndex = 26;
            this.dgvItemsIn.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItemsIn_CellValueChanged);
            this.dgvItemsIn.DoubleClick += new System.EventHandler(this.dgvItemsIn_DoubleClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Visible = false;
            this.ID.Width = 125;
            // 
            // ItemID
            // 
            this.ItemID.DataPropertyName = "ItemID";
            this.ItemID.HeaderText = "ItemID";
            this.ItemID.MinimumWidth = 6;
            this.ItemID.Name = "ItemID";
            this.ItemID.Visible = false;
            this.ItemID.Width = 125;
            // 
            // ItemName
            // 
            this.ItemName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ItemName.DataPropertyName = "ItemName";
            this.ItemName.HeaderText = "الصنف";
            this.ItemName.MinimumWidth = 6;
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            this.ItemName.Width = 66;
            // 
            // Quantity
            // 
            this.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Quantity.DataPropertyName = "Quantity";
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.Quantity.DefaultCellStyle = dataGridViewCellStyle3;
            this.Quantity.HeaderText = "الكمية";
            this.Quantity.MaxInputLength = 5;
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 65;
            // 
            // UnitID
            // 
            this.UnitID.DataPropertyName = "UnitID";
            this.UnitID.HeaderText = "UnitID";
            this.UnitID.MinimumWidth = 6;
            this.UnitID.Name = "UnitID";
            this.UnitID.Visible = false;
            this.UnitID.Width = 125;
            // 
            // UnitName
            // 
            this.UnitName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.UnitName.DataPropertyName = "UnitName";
            this.UnitName.HeaderText = "الوحدة";
            this.UnitName.MinimumWidth = 6;
            this.UnitName.Name = "UnitName";
            this.UnitName.ReadOnly = true;
            this.UnitName.Width = 67;
            // 
            // PurchasePrice
            // 
            this.PurchasePrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PurchasePrice.DataPropertyName = "PurchasePrice";
            dataGridViewCellStyle4.Format = "N2";
            this.PurchasePrice.DefaultCellStyle = dataGridViewCellStyle4;
            this.PurchasePrice.HeaderText = "سعر الشراء";
            this.PurchasePrice.MinimumWidth = 6;
            this.PurchasePrice.Name = "PurchasePrice";
            this.PurchasePrice.Width = 89;
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Location = new System.Drawing.Point(705, 14);
            this.lblSupplier.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(42, 16);
            this.lblSupplier.TabIndex = 29;
            this.lblSupplier.Text = "المورد :";
            // 
            // cbxSupplier
            // 
            this.cbxSupplier.FormattingEnabled = true;
            this.cbxSupplier.Location = new System.Drawing.Point(497, 10);
            this.cbxSupplier.Margin = new System.Windows.Forms.Padding(4);
            this.cbxSupplier.Name = "cbxSupplier";
            this.cbxSupplier.Size = new System.Drawing.Size(199, 24);
            this.cbxSupplier.TabIndex = 30;
            this.cbxSupplier.Tag = "1";
            this.cbxSupplier.SelectedIndexChanged += new System.EventHandler(this.cmbItemID_SelectedIndexChanged);
            // 
            // frmItemsIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(919, 761);
            this.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.Name = "frmItemsIn";
            this.Text = "مدير الأصناف - فواتير الشراء";
            this.Load += new System.EventHandler(this.frmItemsIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblDetails)).EndInit();
            this.pnlControls.ResumeLayout(false);
            this.pnlControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errprvForm)).EndInit();
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            this.pnlItemsInControls.ResumeLayout(false);
            this.pnlItemsInControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemsIn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Panel pnlItemsInControls;
        private System.Windows.Forms.TextBox txtBarCode;
        private System.Windows.Forms.Label lblBarCode;
        private System.Windows.Forms.Label lblItemCategory;
        private CustomControls.ucTreeViewComboBox tvcmbCategory;
        private System.Windows.Forms.ComboBox cmbItemID;
        private System.Windows.Forms.Label lblItemID;
        private System.Windows.Forms.ComboBox cmbUnitID;
        private System.Windows.Forms.Label lblUnitID;
        private CustomControls.NumericTextBox txtnQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvItemsIn;
        private System.Windows.Forms.TextBox txtTotalCash;
        private System.Windows.Forms.Label lblTotalValue;
        private CustomControls.NumericTextBox txtnPurchasePrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblPound;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchasePrice;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.ComboBox cbxSupplier;
        private System.Windows.Forms.Panel pnlSearchItems;
    }
}
