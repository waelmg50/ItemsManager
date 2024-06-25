namespace ItemsManager.SystemForms
{
    partial class frmUsers
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
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.chkIsAdmin = new System.Windows.Forms.CheckBox();
            this.chkIsActive = new System.Windows.Forms.CheckBox();
            this.lblPasswordConfirmation = new System.Windows.Forms.Label();
            this.txtPasswordConfirmation = new System.Windows.Forms.TextBox();
            this.pnlControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errprvForm)).BeginInit();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(242, 13);
            // 
            // pnlControls
            // 
            this.pnlControls.Controls.Add(this.chkIsActive);
            this.pnlControls.Controls.Add(this.chkIsAdmin);
            this.pnlControls.Controls.Add(this.txtPasswordConfirmation);
            this.pnlControls.Controls.Add(this.txtPassword);
            this.pnlControls.Controls.Add(this.txtFullName);
            this.pnlControls.Controls.Add(this.lblPasswordConfirmation);
            this.pnlControls.Controls.Add(this.txtUsername);
            this.pnlControls.Controls.Add(this.lblPassword);
            this.pnlControls.Controls.Add(this.lblFullName);
            this.pnlControls.Controls.Add(this.lblName);
            this.pnlControls.Size = new System.Drawing.Size(407, 190);
            this.pnlControls.Controls.SetChildIndex(this.txtID, 0);
            this.pnlControls.Controls.SetChildIndex(this.lblID, 0);
            this.pnlControls.Controls.SetChildIndex(this.lblName, 0);
            this.pnlControls.Controls.SetChildIndex(this.lblFullName, 0);
            this.pnlControls.Controls.SetChildIndex(this.lblPassword, 0);
            this.pnlControls.Controls.SetChildIndex(this.txtUsername, 0);
            this.pnlControls.Controls.SetChildIndex(this.lblPasswordConfirmation, 0);
            this.pnlControls.Controls.SetChildIndex(this.txtFullName, 0);
            this.pnlControls.Controls.SetChildIndex(this.txtPassword, 0);
            this.pnlControls.Controls.SetChildIndex(this.txtPasswordConfirmation, 0);
            this.pnlControls.Controls.SetChildIndex(this.chkIsAdmin, 0);
            this.pnlControls.Controls.SetChildIndex(this.chkIsActive, 0);
            // 
            // lblID
            // 
            this.lblID.Location = new System.Drawing.Point(327, 13);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(17, 38);
            this.txtUsername.MaxLength = 50;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(279, 20);
            this.txtUsername.TabIndex = 6;
            this.txtUsername.Tag = "1";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(302, 38);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(88, 13);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "اسم المستخدم :";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(324, 63);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(66, 13);
            this.lblPassword.TabIndex = 7;
            this.lblPassword.Text = "كلمة المرور :";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(17, 63);
            this.txtPassword.MaxLength = 50;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(279, 20);
            this.txtPassword.TabIndex = 6;
            this.txtPassword.Tag = "1";
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(312, 113);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(78, 13);
            this.lblFullName.TabIndex = 7;
            this.lblFullName.Text = "الاسم بالكامل :";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(17, 113);
            this.txtFullName.MaxLength = 50;
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(279, 20);
            this.txtFullName.TabIndex = 6;
            this.txtFullName.Tag = "1";
            // 
            // chkIsAdmin
            // 
            this.chkIsAdmin.AutoSize = true;
            this.chkIsAdmin.Location = new System.Drawing.Point(250, 138);
            this.chkIsAdmin.Name = "chkIsAdmin";
            this.chkIsAdmin.Size = new System.Drawing.Size(46, 17);
            this.chkIsAdmin.TabIndex = 21;
            this.chkIsAdmin.Text = "مدير";
            this.chkIsAdmin.UseVisualStyleBackColor = true;
            // 
            // chkIsActive
            // 
            this.chkIsActive.AutoSize = true;
            this.chkIsActive.Location = new System.Drawing.Point(247, 160);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Size = new System.Drawing.Size(49, 17);
            this.chkIsActive.TabIndex = 22;
            this.chkIsActive.Text = "نشط";
            this.chkIsActive.UseVisualStyleBackColor = true;
            // 
            // lblPasswordConfirmation
            // 
            this.lblPasswordConfirmation.AutoSize = true;
            this.lblPasswordConfirmation.Location = new System.Drawing.Point(300, 88);
            this.lblPasswordConfirmation.Name = "lblPasswordConfirmation";
            this.lblPasswordConfirmation.Size = new System.Drawing.Size(90, 13);
            this.lblPasswordConfirmation.TabIndex = 7;
            this.lblPasswordConfirmation.Text = "تأكيد كلمة المرور :";
            // 
            // txtPasswordConfirmation
            // 
            this.txtPasswordConfirmation.Location = new System.Drawing.Point(17, 88);
            this.txtPasswordConfirmation.MaxLength = 50;
            this.txtPasswordConfirmation.Name = "txtPasswordConfirmation";
            this.txtPasswordConfirmation.Size = new System.Drawing.Size(279, 20);
            this.txtPasswordConfirmation.TabIndex = 6;
            this.txtPasswordConfirmation.Tag = "1";
            this.txtPasswordConfirmation.UseSystemPasswordChar = true;
            // 
            // frmUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(407, 215);
            this.Name = "frmUsers";
            this.Text = "مدير الأصناف - المستخدمون";
            this.pnlControls.ResumeLayout(false);
            this.pnlControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errprvForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.CheckBox chkIsActive;
        private System.Windows.Forms.CheckBox chkIsAdmin;
        private System.Windows.Forms.TextBox txtPasswordConfirmation;
        private System.Windows.Forms.Label lblPasswordConfirmation;
    }
}
