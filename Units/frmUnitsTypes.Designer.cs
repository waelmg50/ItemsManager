namespace ItemsManager.Units
{
    partial class frmUnitsTypes
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.pnlControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errprvForm)).BeginInit();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(240, 19);
            this.txtID.MaxLength = 7;
            // 
            // pnlControls
            // 
            this.pnlControls.Controls.Add(this.txtName);
            this.pnlControls.Controls.Add(this.lblName);
            this.pnlControls.Size = new System.Drawing.Size(390, 94);
            this.pnlControls.Controls.SetChildIndex(this.lblName, 0);
            this.pnlControls.Controls.SetChildIndex(this.txtName, 0);
            this.pnlControls.Controls.SetChildIndex(this.txtID, 0);
            this.pnlControls.Controls.SetChildIndex(this.lblID, 0);
            // 
            // lblID
            // 
            this.lblID.Location = new System.Drawing.Point(313, 19);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(15, 55);
            this.txtName.MaxLength = 50;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(279, 20);
            this.txtName.TabIndex = 2;
            this.txtName.Tag = "1";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(333, 55);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(43, 13);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "الاسم :";
            // 
            // frmUnitsTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(390, 119);
            this.Name = "frmUnitsTypes";
            this.Text = "مدير الأصناف - أنواع الوحدات";
            this.pnlControls.ResumeLayout(false);
            this.pnlControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errprvForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
    }
}
