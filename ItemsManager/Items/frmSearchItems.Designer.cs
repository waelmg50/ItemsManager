namespace ItemsManager.Items
{
    partial class frmSearchItems
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
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.txtKeyWord = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgtxtcItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgtxtcCategoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgtxtcItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbxcItemCategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbxcCalculatedQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgtxtcSellPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.errprvForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvItems
            // 
            this.dgvItems.AllowUserToAddRows = false;
            this.dgvItems.AllowUserToDeleteRows = false;
            this.dgvItems.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvItems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgtxtcItemID,
            this.dgtxtcCategoryID,
            this.dgtxtcItemName,
            this.dgvtbxcItemCategoryName,
            this.dgvtbxcCalculatedQuantity,
            this.dgtxtcSellPrice});
            this.dgvItems.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvItems.Location = new System.Drawing.Point(0, 102);
            this.dgvItems.Margin = new System.Windows.Forms.Padding(4);
            this.dgvItems.MultiSelect = false;
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.RowHeadersWidth = 51;
            this.dgvItems.Size = new System.Drawing.Size(989, 533);
            this.dgvItems.TabIndex = 23;
            this.dgvItems.DoubleClick += new System.EventHandler(this.dgvItemUnits_DoubleClick);
            // 
            // txtKeyWord
            // 
            this.txtKeyWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKeyWord.Location = new System.Drawing.Point(131, 39);
            this.txtKeyWord.Margin = new System.Windows.Forms.Padding(4);
            this.txtKeyWord.MaxLength = 50;
            this.txtKeyWord.Name = "txtKeyWord";
            this.txtKeyWord.Size = new System.Drawing.Size(371, 26);
            this.txtKeyWord.TabIndex = 24;
            this.txtKeyWord.Tag = "1";
            this.txtKeyWord.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtKeyWord_PreviewKeyDown);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(86, 44);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(37, 16);
            this.lblName.TabIndex = 25;
            this.lblName.Text = "الاسم :";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(523, 38);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 28);
            this.btnSearch.TabIndex = 26;
            this.btnSearch.Text = "بحث";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgtxtcItemID
            // 
            this.dgtxtcItemID.DataPropertyName = "ItemID";
            this.dgtxtcItemID.HeaderText = "ItemID";
            this.dgtxtcItemID.MinimumWidth = 6;
            this.dgtxtcItemID.Name = "dgtxtcItemID";
            this.dgtxtcItemID.Visible = false;
            this.dgtxtcItemID.Width = 125;
            // 
            // dgtxtcCategoryID
            // 
            this.dgtxtcCategoryID.DataPropertyName = "CategoryID";
            this.dgtxtcCategoryID.HeaderText = "CategoryID";
            this.dgtxtcCategoryID.MinimumWidth = 6;
            this.dgtxtcCategoryID.Name = "dgtxtcCategoryID";
            this.dgtxtcCategoryID.Visible = false;
            this.dgtxtcCategoryID.Width = 125;
            // 
            // dgtxtcItemName
            // 
            this.dgtxtcItemName.DataPropertyName = "ItemName";
            this.dgtxtcItemName.HeaderText = "الصنف";
            this.dgtxtcItemName.MinimumWidth = 6;
            this.dgtxtcItemName.Name = "dgtxtcItemName";
            this.dgtxtcItemName.ReadOnly = true;
            this.dgtxtcItemName.Width = 200;
            // 
            // dgvtbxcItemCategoryName
            // 
            this.dgvtbxcItemCategoryName.DataPropertyName = "ItemCategoryName";
            this.dgvtbxcItemCategoryName.HeaderText = "التصنيف";
            this.dgvtbxcItemCategoryName.MinimumWidth = 6;
            this.dgvtbxcItemCategoryName.Name = "dgvtbxcItemCategoryName";
            this.dgvtbxcItemCategoryName.ReadOnly = true;
            this.dgvtbxcItemCategoryName.Width = 200;
            // 
            // dgvtbxcCalculatedQuantity
            // 
            this.dgvtbxcCalculatedQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dgvtbxcCalculatedQuantity.DataPropertyName = "CalculatedQuantity";
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.dgvtbxcCalculatedQuantity.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvtbxcCalculatedQuantity.HeaderText = "الرصيد الحالي";
            this.dgvtbxcCalculatedQuantity.MinimumWidth = 6;
            this.dgvtbxcCalculatedQuantity.Name = "dgvtbxcCalculatedQuantity";
            this.dgvtbxcCalculatedQuantity.ReadOnly = true;
            this.dgvtbxcCalculatedQuantity.Width = 102;
            // 
            // dgtxtcSellPrice
            // 
            this.dgtxtcSellPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dgtxtcSellPrice.DataPropertyName = "SellPrice";
            dataGridViewCellStyle3.Format = "N2";
            this.dgtxtcSellPrice.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgtxtcSellPrice.HeaderText = "السعر";
            this.dgtxtcSellPrice.MinimumWidth = 6;
            this.dgtxtcSellPrice.Name = "dgtxtcSellPrice";
            this.dgtxtcSellPrice.ReadOnly = true;
            this.dgtxtcSellPrice.Width = 63;
            // 
            // frmSearchItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(989, 635);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtKeyWord);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.dgvItems);
            this.MinimizeBox = false;
            this.Name = "frmSearchItems";
            this.Text = "مدير الأصناف - البحث عن صنف";
            this.Load += new System.EventHandler(this.frmSearchItems_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errprvForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.TextBox txtKeyWord;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgtxtcItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgtxtcCategoryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgtxtcItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbxcItemCategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbxcCalculatedQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgtxtcSellPrice;
    }
}
