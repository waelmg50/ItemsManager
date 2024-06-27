namespace ItemsManager
{
    partial class frmBackup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBackup));
            this.pnlControls = new System.Windows.Forms.Panel();
            this.lblEnterFilePath = new System.Windows.Forms.Label();
            this.chkBlankPassword = new System.Windows.Forms.CheckBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtBackupPath = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.lblBackupPassword = new System.Windows.Forms.Label();
            this.btnBackup = new System.Windows.Forms.Button();
            this.fbdBackup = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.errprvForm)).BeginInit();
            this.pnlControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlControls
            // 
            this.pnlControls.Controls.Add(this.lblEnterFilePath);
            this.pnlControls.Controls.Add(this.chkBlankPassword);
            this.pnlControls.Controls.Add(this.txtPassword);
            this.pnlControls.Controls.Add(this.txtBackupPath);
            this.pnlControls.Controls.Add(this.btnBrowse);
            this.pnlControls.Controls.Add(this.lblBackupPassword);
            this.pnlControls.Controls.Add(this.btnBackup);
            this.pnlControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlControls.Location = new System.Drawing.Point(0, 0);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(471, 187);
            this.pnlControls.TabIndex = 0;
            // 
            // lblEnterFilePath
            // 
            this.lblEnterFilePath.AutoSize = true;
            this.lblEnterFilePath.BackColor = System.Drawing.Color.Transparent;
            this.lblEnterFilePath.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblEnterFilePath.Location = new System.Drawing.Point(368, 16);
            this.lblEnterFilePath.Name = "lblEnterFilePath";
            this.lblEnterFilePath.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblEnterFilePath.Size = new System.Drawing.Size(98, 13);
            this.lblEnterFilePath.TabIndex = 19;
            this.lblEnterFilePath.Text = "أدخل مسار  الملف :";
            // 
            // chkBlankPassword
            // 
            this.chkBlankPassword.AutoSize = true;
            this.chkBlankPassword.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chkBlankPassword.Location = new System.Drawing.Point(148, 99);
            this.chkBlankPassword.Name = "chkBlankPassword";
            this.chkBlankPassword.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkBlankPassword.Size = new System.Drawing.Size(95, 17);
            this.chkBlankPassword.TabIndex = 18;
            this.chkBlankPassword.Text = "بدون كلمة مرور";
            this.chkBlankPassword.UseVisualStyleBackColor = true;
            this.chkBlankPassword.CheckedChanged += new System.EventHandler(this.chkBlankPassword_CheckedChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(266, 96);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(122, 20);
            this.txtPassword.TabIndex = 14;
            // 
            // txtBackupPath
            // 
            this.txtBackupPath.Location = new System.Drawing.Point(97, 34);
            this.txtBackupPath.Name = "txtBackupPath";
            this.txtBackupPath.Size = new System.Drawing.Size(291, 20);
            this.txtBackupPath.TabIndex = 15;
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnBrowse.Image = ((System.Drawing.Image)(resources.GetObject("btnBrowse.Image")));
            this.btnBrowse.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBrowse.Location = new System.Drawing.Point(5, 61);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 16;
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // lblBackupPassword
            // 
            this.lblBackupPassword.AutoSize = true;
            this.lblBackupPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblBackupPassword.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblBackupPassword.Location = new System.Drawing.Point(372, 69);
            this.lblBackupPassword.Name = "lblBackupPassword";
            this.lblBackupPassword.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblBackupPassword.Size = new System.Drawing.Size(89, 13);
            this.lblBackupPassword.TabIndex = 13;
            this.lblBackupPassword.Text = "كلمة مرور الملف :";
            // 
            // btnBackup
            // 
            this.btnBackup.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnBackup.Image = ((System.Drawing.Image)(resources.GetObject("btnBackup.Image")));
            this.btnBackup.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBackup.Location = new System.Drawing.Point(154, 141);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(97, 29);
            this.btnBackup.TabIndex = 17;
            this.btnBackup.UseVisualStyleBackColor = false;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // frmBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(471, 187);
            this.Controls.Add(this.pnlControls);
            this.Name = "frmBackup";
            this.Text = "نسخ احتياطي لقاعدة البيانات";
            ((System.ComponentModel.ISupportInitialize)(this.errprvForm)).EndInit();
            this.pnlControls.ResumeLayout(false);
            this.pnlControls.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.Label lblEnterFilePath;
        private System.Windows.Forms.CheckBox chkBlankPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtBackupPath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label lblBackupPassword;
        private System.Windows.Forms.Button btnBackup;
        public System.Windows.Forms.FolderBrowserDialog fbdBackup;

    }
}
