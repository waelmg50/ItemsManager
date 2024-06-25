namespace ItemsManager.BasicData
{
    partial class frmSuppliersAndCustomers
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
            this.lblAddress = new System.Windows.Forms.Label();
            this.tbxAddress = new System.Windows.Forms.TextBox();
            this.chkbxIsSupplier = new System.Windows.Forms.CheckBox();
            this.lblType = new System.Windows.Forms.Label();
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.pnlControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errprvForm)).BeginInit();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtID.Location = new System.Drawing.Point(333, 9);
            // 
            // pnlControls
            // 
            this.pnlControls.Controls.Add(this.lblType);
            this.pnlControls.Controls.Add(this.cbxType);
            this.pnlControls.Controls.Add(this.chkbxIsSupplier);
            this.pnlControls.Controls.Add(this.tbxAddress);
            this.pnlControls.Controls.Add(this.tbxName);
            this.pnlControls.Controls.Add(this.lblAddress);
            this.pnlControls.Controls.Add(this.lblName);
            this.pnlControls.Size = new System.Drawing.Size(470, 192);
            this.pnlControls.Controls.SetChildIndex(this.txtID, 0);
            this.pnlControls.Controls.SetChildIndex(this.lblName, 0);
            this.pnlControls.Controls.SetChildIndex(this.lblAddress, 0);
            this.pnlControls.Controls.SetChildIndex(this.lblID, 0);
            this.pnlControls.Controls.SetChildIndex(this.tbxName, 0);
            this.pnlControls.Controls.SetChildIndex(this.tbxAddress, 0);
            this.pnlControls.Controls.SetChildIndex(this.chkbxIsSupplier, 0);
            this.pnlControls.Controls.SetChildIndex(this.cbxType, 0);
            this.pnlControls.Controls.SetChildIndex(this.lblType, 0);
            // 
            // lblID
            // 
            this.lblID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblID.Location = new System.Drawing.Point(395, 12);
            // 
            // tbxName
            // 
            this.tbxName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxName.Location = new System.Drawing.Point(108, 37);
            this.tbxName.MaxLength = 50;
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(279, 20);
            this.tbxName.TabIndex = 6;
            this.tbxName.Tag = "1";
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(415, 40);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(43, 13);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "الاسم :";
            // 
            // lblAddress
            // 
            this.lblAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(413, 67);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(45, 13);
            this.lblAddress.TabIndex = 7;
            this.lblAddress.Text = "العنوان :";
            // 
            // tbxAddress
            // 
            this.tbxAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxAddress.Location = new System.Drawing.Point(21, 64);
            this.tbxAddress.MaxLength = 50;
            this.tbxAddress.Multiline = true;
            this.tbxAddress.Name = "tbxAddress";
            this.tbxAddress.Size = new System.Drawing.Size(366, 60);
            this.tbxAddress.TabIndex = 6;
            this.tbxAddress.Tag = "1";
            // 
            // chkbxIsSupplier
            // 
            this.chkbxIsSupplier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkbxIsSupplier.AutoSize = true;
            this.chkbxIsSupplier.Location = new System.Drawing.Point(412, 164);
            this.chkbxIsSupplier.Name = "chkbxIsSupplier";
            this.chkbxIsSupplier.Size = new System.Drawing.Size(46, 17);
            this.chkbxIsSupplier.TabIndex = 8;
            this.chkbxIsSupplier.Text = "مورد";
            this.chkbxIsSupplier.UseVisualStyleBackColor = true;
            // 
            // lblType
            // 
            this.lblType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(422, 134);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(36, 13);
            this.lblType.TabIndex = 33;
            this.lblType.Text = "النوع :";
            // 
            // cbxType
            // 
            this.cbxType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxType.FormattingEnabled = true;
            this.cbxType.Location = new System.Drawing.Point(237, 131);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(150, 21);
            this.cbxType.TabIndex = 34;
            this.cbxType.Tag = "1";
            // 
            // frmSuppliersAndCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 217);
            this.Name = "frmSuppliersAndCustomers";
            this.Text = "مدير الأصناف - المورد / العميل";
            this.Load += new System.EventHandler(this.frmSuppliersAndCustomers_Load);
            this.pnlControls.ResumeLayout(false);
            this.pnlControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errprvForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbxAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.CheckBox chkbxIsSupplier;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cbxType;

    }
}