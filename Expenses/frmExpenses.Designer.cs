namespace ItemsManager.Expenses
{
    partial class frmExpenses
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
            this.txtStatement = new System.Windows.Forms.TextBox();
            this.lblStatement = new System.Windows.Forms.Label();
            this.lblExpenseType = new System.Windows.Forms.Label();
            this.cmbTypeID = new System.Windows.Forms.ComboBox();
            this.txtnValue = new CustomControls.NumericTextBox();
            this.lblValue = new System.Windows.Forms.Label();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.lblRemarks = new System.Windows.Forms.Label();
            this.pnlControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errprvForm)).BeginInit();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(356, 7);
            // 
            // pnlControls
            // 
            this.pnlControls.Controls.Add(this.txtRemarks);
            this.pnlControls.Controls.Add(this.lblRemarks);
            this.pnlControls.Controls.Add(this.txtnValue);
            this.pnlControls.Controls.Add(this.lblValue);
            this.pnlControls.Controls.Add(this.cmbTypeID);
            this.pnlControls.Controls.Add(this.txtStatement);
            this.pnlControls.Controls.Add(this.lblExpenseType);
            this.pnlControls.Controls.Add(this.lblStatement);
            this.pnlControls.Size = new System.Drawing.Size(542, 169);
            this.pnlControls.Controls.SetChildIndex(this.txtID, 0);
            this.pnlControls.Controls.SetChildIndex(this.lblID, 0);
            this.pnlControls.Controls.SetChildIndex(this.lblStatement, 0);
            this.pnlControls.Controls.SetChildIndex(this.lblExpenseType, 0);
            this.pnlControls.Controls.SetChildIndex(this.txtStatement, 0);
            this.pnlControls.Controls.SetChildIndex(this.cmbTypeID, 0);
            this.pnlControls.Controls.SetChildIndex(this.lblValue, 0);
            this.pnlControls.Controls.SetChildIndex(this.txtnValue, 0);
            this.pnlControls.Controls.SetChildIndex(this.lblRemarks, 0);
            this.pnlControls.Controls.SetChildIndex(this.txtRemarks, 0);
            // 
            // lblID
            // 
            this.lblID.Location = new System.Drawing.Point(418, 7);
            // 
            // txtStatement
            // 
            this.txtStatement.Location = new System.Drawing.Point(131, 31);
            this.txtStatement.MaxLength = 50;
            this.txtStatement.Name = "txtStatement";
            this.txtStatement.Size = new System.Drawing.Size(279, 20);
            this.txtStatement.TabIndex = 4;
            this.txtStatement.Tag = "";
            // 
            // lblStatement
            // 
            this.lblStatement.AutoSize = true;
            this.lblStatement.Location = new System.Drawing.Point(443, 31);
            this.lblStatement.Name = "lblStatement";
            this.lblStatement.Size = new System.Drawing.Size(38, 13);
            this.lblStatement.TabIndex = 5;
            this.lblStatement.Text = "البيان :";
            // 
            // lblExpenseType
            // 
            this.lblExpenseType.AutoSize = true;
            this.lblExpenseType.Location = new System.Drawing.Point(445, 55);
            this.lblExpenseType.Name = "lblExpenseType";
            this.lblExpenseType.Size = new System.Drawing.Size(36, 13);
            this.lblExpenseType.TabIndex = 5;
            this.lblExpenseType.Text = "النوع :";
            // 
            // cmbTypeID
            // 
            this.cmbTypeID.FormattingEnabled = true;
            this.cmbTypeID.Location = new System.Drawing.Point(131, 55);
            this.cmbTypeID.Name = "cmbTypeID";
            this.cmbTypeID.Size = new System.Drawing.Size(279, 21);
            this.cmbTypeID.TabIndex = 6;
            this.cmbTypeID.Tag = "1";
            // 
            // txtnValue
            // 
            this.txtnValue.IsInt = false;
            this.txtnValue.Location = new System.Drawing.Point(246, 80);
            this.txtnValue.Name = "txtnValue";
            this.txtnValue.Size = new System.Drawing.Size(164, 20);
            this.txtnValue.TabIndex = 15;
            this.txtnValue.Tag = "1";
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(438, 80);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(43, 13);
            this.lblValue.TabIndex = 14;
            this.lblValue.Text = "القيمة :";
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(61, 104);
            this.txtRemarks.MaxLength = 100;
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(349, 58);
            this.txtRemarks.TabIndex = 16;
            this.txtRemarks.Tag = "";
            // 
            // lblRemarks
            // 
            this.lblRemarks.AutoSize = true;
            this.lblRemarks.Location = new System.Drawing.Point(426, 104);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Size = new System.Drawing.Size(55, 13);
            this.lblRemarks.TabIndex = 17;
            this.lblRemarks.Text = "ملاحظات :";
            // 
            // frmExpenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(542, 194);
            this.Name = "frmExpenses";
            this.Text = "مدير الأصناف - المصروفات";
            this.Load += new System.EventHandler(this.frmExpenses_Load);
            this.pnlControls.ResumeLayout(false);
            this.pnlControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errprvForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTypeID;
        private System.Windows.Forms.TextBox txtStatement;
        private System.Windows.Forms.Label lblExpenseType;
        private System.Windows.Forms.Label lblStatement;
        private CustomControls.NumericTextBox txtnValue;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Label lblRemarks;
    }
}
