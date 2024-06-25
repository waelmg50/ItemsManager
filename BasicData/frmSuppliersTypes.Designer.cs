namespace ItemsManager.BasicData
{
    partial class frmSuppliersTypes
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
            this.tbxName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.pnlControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errprvForm)).BeginInit();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(240, 21);
            // 
            // pnlControls
            // 
            this.pnlControls.Controls.Add(this.tbxName);
            this.pnlControls.Controls.Add(this.lblName);
            this.pnlControls.Size = new System.Drawing.Size(390, 94);
            this.pnlControls.Controls.SetChildIndex(this.txtID, 0);
            this.pnlControls.Controls.SetChildIndex(this.lblID, 0);
            this.pnlControls.Controls.SetChildIndex(this.lblName, 0);
            this.pnlControls.Controls.SetChildIndex(this.tbxName, 0);
            // 
            // lblID
            // 
            this.lblID.Location = new System.Drawing.Point(313, 21);
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(15, 54);
            this.tbxName.MaxLength = 50;
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(279, 20);
            this.tbxName.TabIndex = 4;
            this.tbxName.Tag = "1";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(333, 54);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(43, 13);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "الاسم :";
            // 
            // frmSuppliersTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(390, 119);
            this.Name = "frmSuppliersTypes";
            this.Text = "مدير الأصناف - أنواع الموردين / العملاء";
            this.pnlControls.ResumeLayout(false);
            this.pnlControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errprvForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label lblName;
    }
}
