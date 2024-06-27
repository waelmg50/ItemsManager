namespace ItemsManager.Invoice
{
    partial class frmInvoices
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInvoices));
            this.pnlItemsInControls = new System.Windows.Forms.Panel();
            this.lblPound = new System.Windows.Forms.Label();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtnUnitPrice = new CustomControls.NumericTextBox();
            this.txtnTotalPrice = new CustomControls.NumericTextBox();
            this.txtnQuantity = new CustomControls.NumericTextBox();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.cmbUnitID = new System.Windows.Forms.ComboBox();
            this.lblUnitID = new System.Windows.Forms.Label();
            this.cmbItemID = new System.Windows.Forms.ComboBox();
            this.lblItemID = new System.Windows.Forms.Label();
            this.txtBarCode = new System.Windows.Forms.TextBox();
            this.lblItemCategory = new System.Windows.Forms.Label();
            this.lblBarCode = new System.Windows.Forms.Label();
            this.dgvInvoice = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tvcmbCategory = new CustomControls.ucTreeViewComboBox();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotalCash = new System.Windows.Forms.TextBox();
            this.lblTotalValue = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.cbxCustomer = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.tblDetails)).BeginInit();
            this.pnlControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errprvForm)).BeginInit();
            this.pnlItemsInControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoice)).BeginInit();
            this.pnlFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(472, 9);
            // 
            // pnlControls
            // 
            this.pnlControls.Controls.Add(this.lblCustomer);
            this.pnlControls.Controls.Add(this.cbxCustomer);
            this.pnlControls.Controls.Add(this.pnlItemsInControls);
            this.pnlControls.Controls.Add(this.dgvInvoice);
            this.pnlControls.Controls.Add(this.pnlFooter);
            this.pnlControls.Size = new System.Drawing.Size(598, 491);
            this.pnlControls.Controls.SetChildIndex(this.pnlFooter, 0);
            this.pnlControls.Controls.SetChildIndex(this.dgvInvoice, 0);
            this.pnlControls.Controls.SetChildIndex(this.txtID, 0);
            this.pnlControls.Controls.SetChildIndex(this.lblID, 0);
            this.pnlControls.Controls.SetChildIndex(this.pnlItemsInControls, 0);
            this.pnlControls.Controls.SetChildIndex(this.cbxCustomer, 0);
            this.pnlControls.Controls.SetChildIndex(this.lblCustomer, 0);
            // 
            // lblID
            // 
            this.lblID.Location = new System.Drawing.Point(532, 9);
            // 
            // pnlItemsInControls
            // 
            this.pnlItemsInControls.Controls.Add(this.lblPound);
            this.pnlItemsInControls.Controls.Add(this.btnClean);
            this.pnlItemsInControls.Controls.Add(this.btnAdd);
            this.pnlItemsInControls.Controls.Add(this.txtnUnitPrice);
            this.pnlItemsInControls.Controls.Add(this.txtnTotalPrice);
            this.pnlItemsInControls.Controls.Add(this.txtnQuantity);
            this.pnlItemsInControls.Controls.Add(this.lblUnitPrice);
            this.pnlItemsInControls.Controls.Add(this.lblTotal);
            this.pnlItemsInControls.Controls.Add(this.lblQuantity);
            this.pnlItemsInControls.Controls.Add(this.cmbUnitID);
            this.pnlItemsInControls.Controls.Add(this.lblUnitID);
            this.pnlItemsInControls.Controls.Add(this.cmbItemID);
            this.pnlItemsInControls.Controls.Add(this.lblItemID);
            this.pnlItemsInControls.Controls.Add(this.txtBarCode);
            this.pnlItemsInControls.Controls.Add(this.lblItemCategory);
            this.pnlItemsInControls.Controls.Add(this.lblBarCode);
            this.pnlItemsInControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlItemsInControls.Location = new System.Drawing.Point(0, 37);
            this.pnlItemsInControls.Name = "pnlItemsInControls";
            this.pnlItemsInControls.Size = new System.Drawing.Size(598, 102);
            this.pnlItemsInControls.TabIndex = 4;
            // 
            // lblPound
            // 
            this.lblPound.AutoSize = true;
            this.lblPound.Location = new System.Drawing.Point(12, 42);
            this.lblPound.Name = "lblPound";
            this.lblPound.Size = new System.Drawing.Size(28, 13);
            this.lblPound.TabIndex = 36;
            this.lblPound.Text = "جنيه";
            // 
            // btnClean
            // 
            this.btnClean.Location = new System.Drawing.Point(9, 73);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(75, 23);
            this.btnClean.TabIndex = 35;
            this.btnClean.Text = "تنظيف";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(92, 73);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 35;
            this.btnAdd.Text = "إضافة";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtnUnitPrice
            // 
            this.txtnUnitPrice.BackColor = System.Drawing.Color.White;
            this.txtnUnitPrice.IsInt = false;
            this.txtnUnitPrice.Location = new System.Drawing.Point(43, 39);
            this.txtnUnitPrice.MaxLength = 7;
            this.txtnUnitPrice.Name = "txtnUnitPrice";
            this.txtnUnitPrice.ReadOnly = true;
            this.txtnUnitPrice.Size = new System.Drawing.Size(99, 20);
            this.txtnUnitPrice.TabIndex = 34;
            this.txtnUnitPrice.Tag = "";
            // 
            // txtnTotalPrice
            // 
            this.txtnTotalPrice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.txtnTotalPrice.ForeColor = System.Drawing.Color.Navy;
            this.txtnTotalPrice.IsInt = false;
            this.txtnTotalPrice.Location = new System.Drawing.Point(359, 64);
            this.txtnTotalPrice.MaxLength = 7;
            this.txtnTotalPrice.Name = "txtnTotalPrice";
            this.txtnTotalPrice.Size = new System.Drawing.Size(127, 26);
            this.txtnTotalPrice.TabIndex = 34;
            this.txtnTotalPrice.Tag = "";
            // 
            // txtnQuantity
            // 
            this.txtnQuantity.IsInt = false;
            this.txtnQuantity.Location = new System.Drawing.Point(443, 36);
            this.txtnQuantity.MaxLength = 7;
            this.txtnQuantity.Name = "txtnQuantity";
            this.txtnQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtnQuantity.TabIndex = 34;
            this.txtnQuantity.Tag = "";
            this.txtnQuantity.TextChanged += new System.EventHandler(this.txtnQuantity_TextChanged);
            this.txtnQuantity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnQuantity_KeyDown);
            this.txtnQuantity.Leave += new System.EventHandler(this.txtnQuantity_Leave);
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(148, 39);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(68, 13);
            this.lblUnitPrice.TabIndex = 33;
            this.lblUnitPrice.Text = "سعر الوحدة :";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.Red;
            this.lblTotal.Location = new System.Drawing.Point(498, 64);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(94, 19);
            this.lblTotal.TabIndex = 33;
            this.lblTotal.Text = "إجمالي الصنف :";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(549, 36);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(43, 13);
            this.lblQuantity.TabIndex = 33;
            this.lblQuantity.Text = "الكمية :";
            // 
            // cmbUnitID
            // 
            this.cmbUnitID.FormattingEnabled = true;
            this.cmbUnitID.Location = new System.Drawing.Point(220, 36);
            this.cmbUnitID.Name = "cmbUnitID";
            this.cmbUnitID.Size = new System.Drawing.Size(158, 21);
            this.cmbUnitID.TabIndex = 32;
            this.cmbUnitID.Tag = "";
            this.cmbUnitID.SelectedIndexChanged += new System.EventHandler(this.cmbUnitID_SelectedIndexChanged);
            // 
            // lblUnitID
            // 
            this.lblUnitID.AutoSize = true;
            this.lblUnitID.Location = new System.Drawing.Point(394, 36);
            this.lblUnitID.Name = "lblUnitID";
            this.lblUnitID.Size = new System.Drawing.Size(43, 13);
            this.lblUnitID.TabIndex = 31;
            this.lblUnitID.Text = "الوحدة :";
            // 
            // cmbItemID
            // 
            this.cmbItemID.FormattingEnabled = true;
            this.cmbItemID.Location = new System.Drawing.Point(12, 9);
            this.cmbItemID.Name = "cmbItemID";
            this.cmbItemID.Size = new System.Drawing.Size(130, 21);
            this.cmbItemID.TabIndex = 30;
            this.cmbItemID.Tag = "";
            this.cmbItemID.SelectedIndexChanged += new System.EventHandler(this.cmbItemID_SelectedIndexChanged);
            // 
            // lblItemID
            // 
            this.lblItemID.AutoSize = true;
            this.lblItemID.Location = new System.Drawing.Point(173, 9);
            this.lblItemID.Name = "lblItemID";
            this.lblItemID.Size = new System.Drawing.Size(43, 13);
            this.lblItemID.TabIndex = 29;
            this.lblItemID.Text = "الصنف :";
            // 
            // txtBarCode
            // 
            this.txtBarCode.Location = new System.Drawing.Point(443, 9);
            this.txtBarCode.MaxLength = 50;
            this.txtBarCode.Name = "txtBarCode";
            this.txtBarCode.Size = new System.Drawing.Size(100, 20);
            this.txtBarCode.TabIndex = 1;
            this.txtBarCode.Tag = "";
            this.txtBarCode.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtBarCode_PreviewKeyDown);
            // 
            // lblItemCategory
            // 
            this.lblItemCategory.AutoSize = true;
            this.lblItemCategory.Location = new System.Drawing.Point(386, 9);
            this.lblItemCategory.Name = "lblItemCategory";
            this.lblItemCategory.Size = new System.Drawing.Size(51, 13);
            this.lblItemCategory.TabIndex = 0;
            this.lblItemCategory.Text = "التصنيف :";
            // 
            // lblBarCode
            // 
            this.lblBarCode.AutoSize = true;
            this.lblBarCode.Location = new System.Drawing.Point(549, 9);
            this.lblBarCode.Name = "lblBarCode";
            this.lblBarCode.Size = new System.Drawing.Size(46, 13);
            this.lblBarCode.TabIndex = 0;
            this.lblBarCode.Text = "الباركود :";
            // 
            // dgvInvoice
            // 
            this.dgvInvoice.AllowUserToAddRows = false;
            this.dgvInvoice.AllowUserToDeleteRows = false;
            this.dgvInvoice.AllowUserToOrderColumns = true;
            this.dgvInvoice.AllowUserToResizeColumns = false;
            this.dgvInvoice.AllowUserToResizeRows = false;
            this.dgvInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.ItemID,
            this.ItemName,
            this.Quantity,
            this.UnitID,
            this.UnitName,
            this.UnitPrice,
            this.TotalPrice});
            this.dgvInvoice.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvInvoice.Location = new System.Drawing.Point(0, 139);
            this.dgvInvoice.MultiSelect = false;
            this.dgvInvoice.Name = "dgvInvoice";
            this.dgvInvoice.Size = new System.Drawing.Size(598, 312);
            this.dgvInvoice.TabIndex = 27;
            this.dgvInvoice.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvInvoice_CellValidating);
            this.dgvInvoice.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInvoice_CellValueChanged);
            this.dgvInvoice.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvInvoice_DataError);
            this.dgvInvoice.DoubleClick += new System.EventHandler(this.dgvInvoice_DoubleClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // ItemID
            // 
            this.ItemID.DataPropertyName = "ItemID";
            this.ItemID.HeaderText = "ItemID";
            this.ItemID.Name = "ItemID";
            this.ItemID.Visible = false;
            // 
            // ItemName
            // 
            this.ItemName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ItemName.DataPropertyName = "ItemName";
            this.ItemName.HeaderText = "الصنف";
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            this.ItemName.Width = 61;
            // 
            // Quantity
            // 
            this.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Quantity.DataPropertyName = "Quantity";
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.Quantity.DefaultCellStyle = dataGridViewCellStyle1;
            this.Quantity.HeaderText = "الكمية";
            this.Quantity.MaxInputLength = 5;
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 61;
            // 
            // UnitID
            // 
            this.UnitID.DataPropertyName = "UnitID";
            this.UnitID.HeaderText = "UnitID";
            this.UnitID.Name = "UnitID";
            this.UnitID.Visible = false;
            // 
            // UnitName
            // 
            this.UnitName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.UnitName.DataPropertyName = "UnitName";
            this.UnitName.HeaderText = "الوحدة";
            this.UnitName.Name = "UnitName";
            this.UnitName.ReadOnly = true;
            this.UnitName.Width = 61;
            // 
            // UnitPrice
            // 
            this.UnitPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.UnitPrice.DataPropertyName = "UnitPrice";
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.UnitPrice.DefaultCellStyle = dataGridViewCellStyle2;
            this.UnitPrice.HeaderText = "سعر الوحدة";
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.ReadOnly = true;
            this.UnitPrice.Width = 86;
            // 
            // TotalPrice
            // 
            this.TotalPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TotalPrice.DataPropertyName = "TotalPrice";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.TotalPrice.DefaultCellStyle = dataGridViewCellStyle3;
            this.TotalPrice.HeaderText = "إجمالي الصنف";
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.ReadOnly = true;
            this.TotalPrice.Width = 98;
            // 
            // tvcmbCategory
            // 
            this.tvcmbCategory.Direction = CustomControls.ucTreeViewComboBox.Directions.rtl;
            this.tvcmbCategory.Location = new System.Drawing.Point(219, 70);
            this.tvcmbCategory.Name = "tvcmbCategory";
            this.tvcmbCategory.RecursiveTable = true;
            this.tvcmbCategory.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tvcmbCategory.SelectedValue = ((object)(resources.GetObject("tvcmbCategory.SelectedValue")));
            this.tvcmbCategory.SelectionLevel = -1;
            this.tvcmbCategory.Size = new System.Drawing.Size(158, 21);
            this.tvcmbCategory.TabIndex = 28;
            this.tvcmbCategory.Tag = "";
            this.tvcmbCategory.AfterSelect += new CustomControls.ucTreeViewComboBox.AfterSelectHandler(this.tvcmbCategory_AfterSelect);
            // 
            // pnlFooter
            // 
            this.pnlFooter.Controls.Add(this.label1);
            this.pnlFooter.Controls.Add(this.txtTotalCash);
            this.pnlFooter.Controls.Add(this.lblTotalValue);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 451);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(598, 40);
            this.pnlFooter.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(207, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 19);
            this.label1.TabIndex = 24;
            this.label1.Text = "جنيه";
            // 
            // txtTotalCash
            // 
            this.txtTotalCash.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalCash.ForeColor = System.Drawing.Color.Navy;
            this.txtTotalCash.Location = new System.Drawing.Point(261, 7);
            this.txtTotalCash.MaxLength = 50;
            this.txtTotalCash.Name = "txtTotalCash";
            this.txtTotalCash.Size = new System.Drawing.Size(169, 26);
            this.txtTotalCash.TabIndex = 1;
            // 
            // lblTotalValue
            // 
            this.lblTotalValue.AutoSize = true;
            this.lblTotalValue.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalValue.ForeColor = System.Drawing.Color.Red;
            this.lblTotalValue.Location = new System.Drawing.Point(466, 7);
            this.lblTotalValue.Name = "lblTotalValue";
            this.lblTotalValue.Size = new System.Drawing.Size(129, 19);
            this.lblTotalValue.TabIndex = 0;
            this.lblTotalValue.Text = "إجمالي قيمة الأصناف :";
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Location = new System.Drawing.Point(407, 9);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(45, 13);
            this.lblCustomer.TabIndex = 31;
            this.lblCustomer.Text = "العميل :";
            // 
            // cbxCustomer
            // 
            this.cbxCustomer.FormattingEnabled = true;
            this.cbxCustomer.Location = new System.Drawing.Point(251, 6);
            this.cbxCustomer.Name = "cbxCustomer";
            this.cbxCustomer.Size = new System.Drawing.Size(150, 21);
            this.cbxCustomer.TabIndex = 32;
            this.cbxCustomer.Tag = "1";
            // 
            // frmInvoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(598, 516);
            this.Controls.Add(this.tvcmbCategory);
            this.Name = "frmInvoices";
            this.Text = "مدير الأصناف - الفواتير";
            this.Load += new System.EventHandler(this.frmInvoices_Load);
            this.Controls.SetChildIndex(this.pnlControls, 0);
            this.Controls.SetChildIndex(this.tvcmbCategory, 0);
            ((System.ComponentModel.ISupportInitialize)(this.tblDetails)).EndInit();
            this.pnlControls.ResumeLayout(false);
            this.pnlControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errprvForm)).EndInit();
            this.pnlItemsInControls.ResumeLayout(false);
            this.pnlItemsInControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoice)).EndInit();
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlItemsInControls;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnAdd;
        private CustomControls.NumericTextBox txtnQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.ComboBox cmbUnitID;
        private System.Windows.Forms.Label lblUnitID;
        private System.Windows.Forms.ComboBox cmbItemID;
        private System.Windows.Forms.Label lblItemID;
        private System.Windows.Forms.TextBox txtBarCode;
        private System.Windows.Forms.Label lblItemCategory;
        private System.Windows.Forms.Label lblBarCode;
        private System.Windows.Forms.DataGridView dgvInvoice;
        private CustomControls.ucTreeViewComboBox tvcmbCategory;
        private CustomControls.NumericTextBox txtnUnitPrice;
        private CustomControls.NumericTextBox txtnTotalPrice;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.TextBox txtTotalCash;
        private System.Windows.Forms.Label lblTotalValue;
        private System.Windows.Forms.Label lblPound;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.ComboBox cbxCustomer;
    }
}
