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
            this.txtID.Location = new System.Drawing.Point(475, 9);
            this.txtID.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
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
            this.pnlControls.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pnlControls.Size = new System.Drawing.Size(723, 212);
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
            this.lblID.Location = new System.Drawing.Point(557, 9);
            this.lblID.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            // 
            // txtStatement
            // 
            this.txtStatement.Location = new System.Drawing.Point(175, 38);
            this.txtStatement.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtStatement.MaxLength = 50;
            this.txtStatement.Name = "txtStatement";
            this.txtStatement.Size = new System.Drawing.Size(371, 22);
            this.txtStatement.TabIndex = 4;
            this.txtStatement.Tag = "";
            // 
            // lblStatement
            // 
            this.lblStatement.AutoSize = true;
            this.lblStatement.Location = new System.Drawing.Point(591, 38);
            this.lblStatement.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatement.Name = "lblStatement";
            this.lblStatement.Size = new System.Drawing.Size(39, 16);
            this.lblStatement.TabIndex = 5;
            this.lblStatement.Text = "البيان :";
            // 
            // lblExpenseType
            // 
            this.lblExpenseType.AutoSize = true;
            this.lblExpenseType.Location = new System.Drawing.Point(593, 68);
            this.lblExpenseType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExpenseType.Name = "lblExpenseType";
            this.lblExpenseType.Size = new System.Drawing.Size(37, 16);
            this.lblExpenseType.TabIndex = 5;
            this.lblExpenseType.Text = "النوع :";
            // 
            // cmbTypeID
            // 
            this.cmbTypeID.FormattingEnabled = true;
            this.cmbTypeID.Location = new System.Drawing.Point(175, 68);
            this.cmbTypeID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbTypeID.Name = "cmbTypeID";
            this.cmbTypeID.Size = new System.Drawing.Size(371, 24);
            this.cmbTypeID.TabIndex = 6;
            this.cmbTypeID.Tag = "1";
            // 
            // txtnValue
            // 
            this.txtnValue.IsInt = false;
            this.txtnValue.Location = new System.Drawing.Point(328, 98);
            this.txtnValue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtnValue.Name = "txtnValue";
            this.txtnValue.Size = new System.Drawing.Size(217, 22);
            this.txtnValue.TabIndex = 15;
            this.txtnValue.Tag = "1";
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(584, 98);
            this.lblValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(39, 16);
            this.lblValue.TabIndex = 14;
            this.lblValue.Text = "القيمة :";
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(81, 128);
            this.txtRemarks.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRemarks.MaxLength = 150;
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(464, 70);
            this.txtRemarks.TabIndex = 16;
            this.txtRemarks.Tag = "";
            // 
            // lblRemarks
            // 
            this.lblRemarks.AutoSize = true;
            this.lblRemarks.Location = new System.Drawing.Point(568, 128);
            this.lblRemarks.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Size = new System.Drawing.Size(56, 16);
            this.lblRemarks.TabIndex = 17;
            this.lblRemarks.Text = "ملاحظات :";
            // 
            // frmExpenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(723, 239);
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
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
