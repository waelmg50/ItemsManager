namespace ItemsManager.Report
{
    partial class frmInvoiceDetails
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
            this.btngeneral = new System.Windows.Forms.Button();
            this.btnInvoiceHeadID = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.txtInvoiceHeadID = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnrptInvoiceHeadID = new System.Windows.Forms.Button();
            this.btnrptgeneral = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errprvForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btngeneral
            // 
            this.btngeneral.Location = new System.Drawing.Point(12, 289);
            this.btngeneral.Name = "btngeneral";
            this.btngeneral.Size = new System.Drawing.Size(75, 23);
            this.btngeneral.TabIndex = 0;
            this.btngeneral.Text = "عام";
            this.btngeneral.UseVisualStyleBackColor = true;
            this.btngeneral.Click += new System.EventHandler(this.btngeneral_Click);
            // 
            // btnInvoiceHeadID
            // 
            this.btnInvoiceHeadID.Location = new System.Drawing.Point(517, 289);
            this.btnInvoiceHeadID.Name = "btnInvoiceHeadID";
            this.btnInvoiceHeadID.Size = new System.Drawing.Size(75, 23);
            this.btnInvoiceHeadID.TabIndex = 1;
            this.btnInvoiceHeadID.Text = "الرقم";
            this.btnInvoiceHeadID.UseVisualStyleBackColor = true;
            this.btnInvoiceHeadID.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(517, 316);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "التاريخ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dgvData
            // 
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(12, 12);
            this.dgvData.Name = "dgvData";
            this.dgvData.Size = new System.Drawing.Size(580, 271);
            this.dgvData.TabIndex = 3;
            // 
            // txtInvoiceHeadID
            // 
            this.txtInvoiceHeadID.Location = new System.Drawing.Point(274, 291);
            this.txtInvoiceHeadID.Name = "txtInvoiceHeadID";
            this.txtInvoiceHeadID.Size = new System.Drawing.Size(200, 20);
            this.txtInvoiceHeadID.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 317);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.RightToLeftLayout = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(226, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(274, 317);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.RightToLeftLayout = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnrptInvoiceHeadID);
            this.groupBox1.Controls.Add(this.btnrptgeneral);
            this.groupBox1.Location = new System.Drawing.Point(12, 343);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(462, 59);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "التقرير";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "التاريخ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnrptInvoiceHeadID
            // 
            this.btnrptInvoiceHeadID.Location = new System.Drawing.Point(192, 23);
            this.btnrptInvoiceHeadID.Name = "btnrptInvoiceHeadID";
            this.btnrptInvoiceHeadID.Size = new System.Drawing.Size(75, 23);
            this.btnrptInvoiceHeadID.TabIndex = 3;
            this.btnrptInvoiceHeadID.Text = "الرقم";
            this.btnrptInvoiceHeadID.UseVisualStyleBackColor = true;
            this.btnrptInvoiceHeadID.Click += new System.EventHandler(this.btnrptInvoiceHeadID_Click);
            // 
            // btnrptgeneral
            // 
            this.btnrptgeneral.Location = new System.Drawing.Point(381, 23);
            this.btnrptgeneral.Name = "btnrptgeneral";
            this.btnrptgeneral.Size = new System.Drawing.Size(75, 23);
            this.btnrptgeneral.TabIndex = 1;
            this.btnrptgeneral.Text = "عام";
            this.btnrptgeneral.UseVisualStyleBackColor = true;
            this.btnrptgeneral.Click += new System.EventHandler(this.btnrptgeneral_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(517, 366);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(75, 23);
            this.btnexit.TabIndex = 8;
            this.btnexit.Text = "خروج";
            this.btnexit.UseVisualStyleBackColor = true;
            // 
            // frmInvoiceDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 413);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtInvoiceHeadID);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnInvoiceHeadID);
            this.Controls.Add(this.btngeneral);
            this.MaximizeBox = false;
            this.Name = "frmInvoiceDetails";
            this.Text = "مدير الأصناف - تفاصيل الفاتورة";
            this.Load += new System.EventHandler(this.frmInvoiceDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errprvForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btngeneral;
        private System.Windows.Forms.Button btnInvoiceHeadID;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.TextBox txtInvoiceHeadID;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnrptInvoiceHeadID;
        private System.Windows.Forms.Button btnrptgeneral;
        private System.Windows.Forms.Button btnexit;
    }
}