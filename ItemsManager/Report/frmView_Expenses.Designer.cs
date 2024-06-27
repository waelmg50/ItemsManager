namespace ItemsManager.Report
{
    partial class frmView_Expenses
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmbtype = new System.Windows.Forms.ComboBox();
            this.btnExpenses = new System.Windows.Forms.Button();
            this.btnExpensesTypes = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errprvForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(517, 275);
            this.dataGridView1.TabIndex = 0;
            // 
            // cmbtype
            // 
            this.cmbtype.FormattingEnabled = true;
            this.cmbtype.Location = new System.Drawing.Point(328, 295);
            this.cmbtype.Name = "cmbtype";
            this.cmbtype.Size = new System.Drawing.Size(201, 21);
            this.cmbtype.TabIndex = 1;
            this.cmbtype.SelectedIndexChanged += new System.EventHandler(this.cmbtype_SelectedIndexChanged);
            // 
            // btnExpenses
            // 
            this.btnExpenses.Location = new System.Drawing.Point(117, 293);
            this.btnExpenses.Name = "btnExpenses";
            this.btnExpenses.Size = new System.Drawing.Size(75, 23);
            this.btnExpenses.TabIndex = 2;
            this.btnExpenses.Text = "عام";
            this.btnExpenses.UseVisualStyleBackColor = true;
            this.btnExpenses.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnExpensesTypes
            // 
            this.btnExpensesTypes.Location = new System.Drawing.Point(226, 293);
            this.btnExpensesTypes.Name = "btnExpensesTypes";
            this.btnExpensesTypes.Size = new System.Drawing.Size(75, 23);
            this.btnExpensesTypes.TabIndex = 3;
            this.btnExpensesTypes.Text = "حسب النوع";
            this.btnExpensesTypes.UseVisualStyleBackColor = true;
            this.btnExpensesTypes.Click += new System.EventHandler(this.btnExpensesTypes_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "خروج";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmView_Expenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 329);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnExpensesTypes);
            this.Controls.Add(this.btnExpenses);
            this.Controls.Add(this.cmbtype);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmView_Expenses";
            this.Text = "مدير الأصناف - عرض تفاصيل المصروفات";
            this.Load += new System.EventHandler(this.frmView_Expenses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errprvForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbtype;
        private System.Windows.Forms.Button btnExpenses;
        private System.Windows.Forms.Button btnExpensesTypes;
        private System.Windows.Forms.Button button1;
    }
}