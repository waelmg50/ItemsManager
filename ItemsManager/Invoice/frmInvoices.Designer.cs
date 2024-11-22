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
            this.pnlSearchItems = new System.Windows.Forms.Panel();
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
            this.txtID.Location = new System.Drawing.Point(629, 11);
            this.txtID.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            // 
            // pnlControls
            // 
            this.pnlControls.Controls.Add(this.lblCustomer);
            this.pnlControls.Controls.Add(this.cbxCustomer);
            this.pnlControls.Controls.Add(this.pnlItemsInControls);
            this.pnlControls.Controls.Add(this.dgvInvoice);
            this.pnlControls.Controls.Add(this.pnlFooter);
            this.pnlControls.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.pnlControls.Size = new System.Drawing.Size(797, 608);
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
            this.lblID.Location = new System.Drawing.Point(709, 11);
            this.lblID.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            // 
            // pnlItemsInControls
            // 
            this.pnlItemsInControls.Controls.Add(this.pnlSearchItems);
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
            this.pnlItemsInControls.Location = new System.Drawing.Point(0, 49);
            this.pnlItemsInControls.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlItemsInControls.Name = "pnlItemsInControls";
            this.pnlItemsInControls.Size = new System.Drawing.Size(797, 126);
            this.pnlItemsInControls.TabIndex = 4;
            // 
            // lblPound
            // 
            this.lblPound.AutoSize = true;
            this.lblPound.Location = new System.Drawing.Point(31, 47);
            this.lblPound.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPound.Name = "lblPound";
            this.lblPound.Size = new System.Drawing.Size(28, 16);
            this.lblPound.TabIndex = 36;
            this.lblPound.Text = "جنيه";
            // 
            // btnClean
            // 
            this.btnClean.Location = new System.Drawing.Point(12, 90);
            this.btnClean.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(100, 28);
            this.btnClean.TabIndex = 35;
            this.btnClean.Text = "تنظيف";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(123, 90);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 28);
            this.btnAdd.TabIndex = 35;
            this.btnAdd.Text = "إضافة";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtnUnitPrice
            // 
            this.txtnUnitPrice.BackColor = System.Drawing.Color.White;
            this.txtnUnitPrice.IsInt = false;
            this.txtnUnitPrice.Location = new System.Drawing.Point(67, 44);
            this.txtnUnitPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtnUnitPrice.MaxLength = 7;
            this.txtnUnitPrice.Name = "txtnUnitPrice";
            this.txtnUnitPrice.ReadOnly = true;
            this.txtnUnitPrice.Size = new System.Drawing.Size(131, 22);
            this.txtnUnitPrice.TabIndex = 34;
            this.txtnUnitPrice.Tag = "";
            // 
            // txtnTotalPrice
            // 
            this.txtnTotalPrice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.txtnTotalPrice.ForeColor = System.Drawing.Color.Navy;
            this.txtnTotalPrice.IsInt = false;
            this.txtnTotalPrice.Location = new System.Drawing.Point(479, 79);
            this.txtnTotalPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtnTotalPrice.MaxLength = 7;
            this.txtnTotalPrice.Name = "txtnTotalPrice";
            this.txtnTotalPrice.Size = new System.Drawing.Size(168, 30);
            this.txtnTotalPrice.TabIndex = 34;
            this.txtnTotalPrice.Tag = "";
            // 
            // txtnQuantity
            // 
            this.txtnQuantity.IsInt = false;
            this.txtnQuantity.Location = new System.Drawing.Point(591, 44);
            this.txtnQuantity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtnQuantity.MaxLength = 7;
            this.txtnQuantity.Name = "txtnQuantity";
            this.txtnQuantity.Size = new System.Drawing.Size(132, 22);
            this.txtnQuantity.TabIndex = 34;
            this.txtnQuantity.Tag = "";
            this.txtnQuantity.TextChanged += new System.EventHandler(this.txtnQuantity_TextChanged);
            this.txtnQuantity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnQuantity_KeyDown);
            this.txtnQuantity.Leave += new System.EventHandler(this.txtnQuantity_Leave);
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(206, 47);
            this.lblUnitPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(68, 16);
            this.lblUnitPrice.TabIndex = 33;
            this.lblUnitPrice.Text = "سعر الوحدة :";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.Red;
            this.lblTotal.Location = new System.Drawing.Point(664, 79);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(115, 23);
            this.lblTotal.TabIndex = 33;
            this.lblTotal.Text = "إجمالي الصنف :";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(732, 44);
            this.lblQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(42, 16);
            this.lblQuantity.TabIndex = 33;
            this.lblQuantity.Text = "الكمية :";
            // 
            // cmbUnitID
            // 
            this.cmbUnitID.FormattingEnabled = true;
            this.cmbUnitID.Location = new System.Drawing.Point(293, 44);
            this.cmbUnitID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbUnitID.Name = "cmbUnitID";
            this.cmbUnitID.Size = new System.Drawing.Size(209, 24);
            this.cmbUnitID.TabIndex = 32;
            this.cmbUnitID.Tag = "";
            this.cmbUnitID.SelectedIndexChanged += new System.EventHandler(this.cmbUnitID_SelectedIndexChanged);
            // 
            // lblUnitID
            // 
            this.lblUnitID.AutoSize = true;
            this.lblUnitID.Location = new System.Drawing.Point(525, 44);
            this.lblUnitID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUnitID.Name = "lblUnitID";
            this.lblUnitID.Size = new System.Drawing.Size(44, 16);
            this.lblUnitID.TabIndex = 31;
            this.lblUnitID.Text = "الوحدة :";
            // 
            // cmbItemID
            // 
            this.cmbItemID.FormattingEnabled = true;
            this.cmbItemID.Location = new System.Drawing.Point(51, 9);
            this.cmbItemID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbItemID.Name = "cmbItemID";
            this.cmbItemID.Size = new System.Drawing.Size(172, 24);
            this.cmbItemID.TabIndex = 30;
            this.cmbItemID.Tag = "";
            this.cmbItemID.SelectedIndexChanged += new System.EventHandler(this.cmbItemID_SelectedIndexChanged);
            // 
            // lblItemID
            // 
            this.lblItemID.AutoSize = true;
            this.lblItemID.Location = new System.Drawing.Point(231, 11);
            this.lblItemID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItemID.Name = "lblItemID";
            this.lblItemID.Size = new System.Drawing.Size(43, 16);
            this.lblItemID.TabIndex = 29;
            this.lblItemID.Text = "الصنف :";
            // 
            // txtBarCode
            // 
            this.txtBarCode.Location = new System.Drawing.Point(591, 11);
            this.txtBarCode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBarCode.MaxLength = 50;
            this.txtBarCode.Name = "txtBarCode";
            this.txtBarCode.Size = new System.Drawing.Size(132, 22);
            this.txtBarCode.TabIndex = 1;
            this.txtBarCode.Tag = "";
            this.txtBarCode.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtBarCode_PreviewKeyDown);
            // 
            // lblItemCategory
            // 
            this.lblItemCategory.AutoSize = true;
            this.lblItemCategory.Location = new System.Drawing.Point(515, 11);
            this.lblItemCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItemCategory.Name = "lblItemCategory";
            this.lblItemCategory.Size = new System.Drawing.Size(51, 16);
            this.lblItemCategory.TabIndex = 0;
            this.lblItemCategory.Text = "التصنيف :";
            // 
            // lblBarCode
            // 
            this.lblBarCode.AutoSize = true;
            this.lblBarCode.Location = new System.Drawing.Point(732, 11);
            this.lblBarCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBarCode.Name = "lblBarCode";
            this.lblBarCode.Size = new System.Drawing.Size(53, 16);
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
            this.dgvInvoice.Location = new System.Drawing.Point(0, 175);
            this.dgvInvoice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvInvoice.MultiSelect = false;
            this.dgvInvoice.Name = "dgvInvoice";
            this.dgvInvoice.RowHeadersWidth = 51;
            this.dgvInvoice.Size = new System.Drawing.Size(797, 384);
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
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.Quantity.DefaultCellStyle = dataGridViewCellStyle1;
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
            // UnitPrice
            // 
            this.UnitPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.UnitPrice.DataPropertyName = "UnitPrice";
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.UnitPrice.DefaultCellStyle = dataGridViewCellStyle2;
            this.UnitPrice.HeaderText = "سعر الوحدة";
            this.UnitPrice.MinimumWidth = 6;
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.ReadOnly = true;
            this.UnitPrice.Width = 91;
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
            this.TotalPrice.MinimumWidth = 6;
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.ReadOnly = true;
            this.TotalPrice.Width = 105;
            // 
            // tvcmbCategory
            // 
            this.tvcmbCategory.Direction = CustomControls.ucTreeViewComboBox.Directions.rtl;
            this.tvcmbCategory.Location = new System.Drawing.Point(292, 86);
            this.tvcmbCategory.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tvcmbCategory.Name = "tvcmbCategory";
            this.tvcmbCategory.RecursiveTable = true;
            this.tvcmbCategory.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tvcmbCategory.SelectedValue = ((object)(resources.GetObject("tvcmbCategory.SelectedValue")));
            this.tvcmbCategory.SelectionLevel = -1;
            this.tvcmbCategory.Size = new System.Drawing.Size(211, 26);
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
            this.pnlFooter.Location = new System.Drawing.Point(0, 559);
            this.pnlFooter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(797, 49);
            this.pnlFooter.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(276, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 23);
            this.label1.TabIndex = 24;
            this.label1.Text = "جنيه";
            // 
            // txtTotalCash
            // 
            this.txtTotalCash.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalCash.ForeColor = System.Drawing.Color.Navy;
            this.txtTotalCash.Location = new System.Drawing.Point(348, 9);
            this.txtTotalCash.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTotalCash.MaxLength = 50;
            this.txtTotalCash.Name = "txtTotalCash";
            this.txtTotalCash.Size = new System.Drawing.Size(224, 30);
            this.txtTotalCash.TabIndex = 1;
            // 
            // lblTotalValue
            // 
            this.lblTotalValue.AutoSize = true;
            this.lblTotalValue.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalValue.ForeColor = System.Drawing.Color.Red;
            this.lblTotalValue.Location = new System.Drawing.Point(621, 9);
            this.lblTotalValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalValue.Name = "lblTotalValue";
            this.lblTotalValue.Size = new System.Drawing.Size(157, 23);
            this.lblTotalValue.TabIndex = 0;
            this.lblTotalValue.Text = "إجمالي قيمة الأصناف :";
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Location = new System.Drawing.Point(543, 11);
            this.lblCustomer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(42, 16);
            this.lblCustomer.TabIndex = 31;
            this.lblCustomer.Text = "العميل :";
            // 
            // cbxCustomer
            // 
            this.cbxCustomer.FormattingEnabled = true;
            this.cbxCustomer.Location = new System.Drawing.Point(335, 7);
            this.cbxCustomer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxCustomer.Name = "cbxCustomer";
            this.cbxCustomer.Size = new System.Drawing.Size(199, 24);
            this.cbxCustomer.TabIndex = 32;
            this.cbxCustomer.Tag = "1";
            // 
            // pnlSearchItems
            // 
            this.pnlSearchItems.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlSearchItems.BackgroundImage")));
            this.pnlSearchItems.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlSearchItems.Location = new System.Drawing.Point(14, 6);
            this.pnlSearchItems.Name = "pnlSearchItems";
            this.pnlSearchItems.Size = new System.Drawing.Size(30, 30);
            this.pnlSearchItems.TabIndex = 40;
            this.pnlSearchItems.Click += new System.EventHandler(this.pnlSearchItems_Click);
            // 
            // frmInvoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(797, 635);
            this.Controls.Add(this.tvcmbCategory);
            this.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
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
        private System.Windows.Forms.Panel pnlSearchItems;
    }
}
