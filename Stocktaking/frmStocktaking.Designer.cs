namespace ItemsManager.Stocktaking
{
    partial class frmStocktaking
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
            this.dgvStockTaking = new System.Windows.Forms.DataGridView();
            this.dtpStocktackingDate = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CalculatedQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExistigQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LackQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tblDetails)).BeginInit();
            this.pnlControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errprvForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockTaking)).BeginInit();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(467, 10);
            // 
            // pnlControls
            // 
            this.pnlControls.Controls.Add(this.dgvStockTaking);
            this.pnlControls.Controls.Add(this.dtpStocktackingDate);
            this.pnlControls.Controls.Add(this.lblDate);
            this.pnlControls.Size = new System.Drawing.Size(615, 539);
            this.pnlControls.Controls.SetChildIndex(this.lblDate, 0);
            this.pnlControls.Controls.SetChildIndex(this.dtpStocktackingDate, 0);
            this.pnlControls.Controls.SetChildIndex(this.dgvStockTaking, 0);
            this.pnlControls.Controls.SetChildIndex(this.lblID, 0);
            this.pnlControls.Controls.SetChildIndex(this.txtID, 0);
            // 
            // lblID
            // 
            this.lblID.Location = new System.Drawing.Point(540, 10);
            // 
            // dgvStockTaking
            // 
            this.dgvStockTaking.AllowUserToAddRows = false;
            this.dgvStockTaking.AllowUserToDeleteRows = false;
            this.dgvStockTaking.AllowUserToOrderColumns = true;
            this.dgvStockTaking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStockTaking.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.ItemID,
            this.ItemName,
            this.UnitID,
            this.UnitName,
            this.CalculatedQuantity,
            this.ExistigQuantity,
            this.LackQuantity});
            this.dgvStockTaking.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvStockTaking.Location = new System.Drawing.Point(0, 36);
            this.dgvStockTaking.Name = "dgvStockTaking";
            this.dgvStockTaking.Size = new System.Drawing.Size(615, 503);
            this.dgvStockTaking.TabIndex = 2;
            this.dgvStockTaking.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStockTaking_CellValueChanged);
            this.dgvStockTaking.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvStockTaking_CellValidating);
            this.dgvStockTaking.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvStockTaking_DataError);
            // 
            // dtpStocktackingDate
            // 
            this.dtpStocktackingDate.CustomFormat = "dddd dd MMMM yyyy";
            this.dtpStocktackingDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStocktackingDate.Location = new System.Drawing.Point(229, 10);
            this.dtpStocktackingDate.Name = "dtpStocktackingDate";
            this.dtpStocktackingDate.RightToLeftLayout = true;
            this.dtpStocktackingDate.Size = new System.Drawing.Size(158, 20);
            this.dtpStocktackingDate.TabIndex = 3;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(393, 13);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(42, 13);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "التاريخ :";
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
            this.ItemName.HeaderText = "اسم الصنف";
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            this.ItemName.Width = 86;
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
            this.UnitName.HeaderText = "اسم الوحدة";
            this.UnitName.Name = "UnitName";
            this.UnitName.ReadOnly = true;
            this.UnitName.Width = 86;
            // 
            // CalculatedQuantity
            // 
            this.CalculatedQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CalculatedQuantity.DataPropertyName = "CalculatedQuantity";
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = "0";
            this.CalculatedQuantity.DefaultCellStyle = dataGridViewCellStyle1;
            this.CalculatedQuantity.HeaderText = "الكمية المحسوبة";
            this.CalculatedQuantity.MaxInputLength = 15;
            this.CalculatedQuantity.Name = "CalculatedQuantity";
            this.CalculatedQuantity.ReadOnly = true;
            this.CalculatedQuantity.Width = 101;
            // 
            // ExistigQuantity
            // 
            this.ExistigQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ExistigQuantity.DataPropertyName = "ExistigQuantity";
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = "0";
            this.ExistigQuantity.DefaultCellStyle = dataGridViewCellStyle2;
            this.ExistigQuantity.HeaderText = "الكمية الموجودة";
            this.ExistigQuantity.MaxInputLength = 15;
            this.ExistigQuantity.Name = "ExistigQuantity";
            this.ExistigQuantity.Width = 96;
            // 
            // LackQuantity
            // 
            this.LackQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.LackQuantity.DataPropertyName = "LackQuantity";
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = "0";
            this.LackQuantity.DefaultCellStyle = dataGridViewCellStyle3;
            this.LackQuantity.HeaderText = "كمية العجز";
            this.LackQuantity.MaxInputLength = 15;
            this.LackQuantity.Name = "LackQuantity";
            this.LackQuantity.ReadOnly = true;
            this.LackQuantity.Width = 75;
            // 
            // frmStocktaking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(615, 564);
            this.Name = "frmStocktaking";
            this.Text = "مدير الأصناف - جرد المحل";
            this.Load += new System.EventHandler(this.frmStocktaking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblDetails)).EndInit();
            this.pnlControls.ResumeLayout(false);
            this.pnlControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errprvForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockTaking)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStockTaking;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpStocktackingDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CalculatedQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExistigQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn LackQuantity;
    }
}
