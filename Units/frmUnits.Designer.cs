namespace ItemsManager.Units
{
    partial class frmUnits
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
            this.lblUnitType = new System.Windows.Forms.Label();
            this.cmbTypeID = new System.Windows.Forms.ComboBox();
            this.pnlControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errprvForm)).BeginInit();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(241, 22);
            // 
            // pnlControls
            // 
            this.pnlControls.Controls.Add(this.cmbTypeID);
            this.pnlControls.Controls.Add(this.txtName);
            this.pnlControls.Controls.Add(this.lblUnitType);
            this.pnlControls.Controls.Add(this.lblName);
            this.pnlControls.Size = new System.Drawing.Size(387, 132);
            this.pnlControls.Controls.SetChildIndex(this.txtID, 0);
            this.pnlControls.Controls.SetChildIndex(this.lblID, 0);
            this.pnlControls.Controls.SetChildIndex(this.lblName, 0);
            this.pnlControls.Controls.SetChildIndex(this.lblUnitType, 0);
            this.pnlControls.Controls.SetChildIndex(this.txtName, 0);
            this.pnlControls.Controls.SetChildIndex(this.cmbTypeID, 0);
            // 
            // lblID
            // 
            this.lblID.Location = new System.Drawing.Point(307, 22);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(16, 56);
            this.txtName.MaxLength = 50;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(279, 20);
            this.txtName.TabIndex = 4;
            this.txtName.Tag = "1";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(327, 56);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(43, 13);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "الاسم :";
            // 
            // lblUnitType
            // 
            this.lblUnitType.AutoSize = true;
            this.lblUnitType.Location = new System.Drawing.Point(334, 90);
            this.lblUnitType.Name = "lblUnitType";
            this.lblUnitType.Size = new System.Drawing.Size(36, 13);
            this.lblUnitType.TabIndex = 5;
            this.lblUnitType.Text = "النوع :";
            // 
            // cmbTypeID
            // 
            this.cmbTypeID.FormattingEnabled = true;
            this.cmbTypeID.Location = new System.Drawing.Point(16, 90);
            this.cmbTypeID.Name = "cmbTypeID";
            this.cmbTypeID.Size = new System.Drawing.Size(279, 21);
            this.cmbTypeID.TabIndex = 6;
            this.cmbTypeID.Tag = "1";
            // 
            // frmUnits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(387, 157);
            this.Name = "frmUnits";
            this.Text = "مدير الأصناف - الوحدات";
            this.Load += new System.EventHandler(this.frmUnits_Load);
            this.pnlControls.ResumeLayout(false);
            this.pnlControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errprvForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTypeID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblUnitType;
        private System.Windows.Forms.Label lblName;
    }
}
