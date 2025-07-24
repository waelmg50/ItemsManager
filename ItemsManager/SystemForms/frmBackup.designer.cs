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
            this.pnlControls.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(628, 230);
            this.pnlControls.TabIndex = 0;
            // 
            // lblEnterFilePath
            // 
            this.lblEnterFilePath.AutoSize = true;
            this.lblEnterFilePath.BackColor = System.Drawing.Color.Transparent;
            this.lblEnterFilePath.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblEnterFilePath.Location = new System.Drawing.Point(491, 20);
            this.lblEnterFilePath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnterFilePath.Name = "lblEnterFilePath";
            this.lblEnterFilePath.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblEnterFilePath.Size = new System.Drawing.Size(98, 16);
            this.lblEnterFilePath.TabIndex = 19;
            this.lblEnterFilePath.Text = "أدخل مسار  الملف :";
            // 
            // chkBlankPassword
            // 
            this.chkBlankPassword.AutoSize = true;
            this.chkBlankPassword.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chkBlankPassword.Location = new System.Drawing.Point(197, 122);
            this.chkBlankPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkBlankPassword.Name = "chkBlankPassword";
            this.chkBlankPassword.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkBlankPassword.Size = new System.Drawing.Size(103, 20);
            this.chkBlankPassword.TabIndex = 18;
            this.chkBlankPassword.Text = "بدون كلمة مرور";
            this.chkBlankPassword.UseVisualStyleBackColor = true;
            this.chkBlankPassword.Visible = false;
            this.chkBlankPassword.CheckedChanged += new System.EventHandler(this.chkBlankPassword_CheckedChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(355, 118);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(161, 22);
            this.txtPassword.TabIndex = 14;
            this.txtPassword.Visible = false;
            // 
            // txtBackupPath
            // 
            this.txtBackupPath.Location = new System.Drawing.Point(129, 42);
            this.txtBackupPath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBackupPath.Name = "txtBackupPath";
            this.txtBackupPath.Size = new System.Drawing.Size(387, 22);
            this.txtBackupPath.TabIndex = 15;
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnBrowse.Image = ((System.Drawing.Image)(resources.GetObject("btnBrowse.Image")));
            this.btnBrowse.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBrowse.Location = new System.Drawing.Point(7, 75);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(100, 28);
            this.btnBrowse.TabIndex = 16;
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // lblBackupPassword
            // 
            this.lblBackupPassword.AutoSize = true;
            this.lblBackupPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblBackupPassword.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblBackupPassword.Location = new System.Drawing.Point(496, 85);
            this.lblBackupPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBackupPassword.Name = "lblBackupPassword";
            this.lblBackupPassword.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblBackupPassword.Size = new System.Drawing.Size(90, 16);
            this.lblBackupPassword.TabIndex = 13;
            this.lblBackupPassword.Text = "كلمة مرور الملف :";
            this.lblBackupPassword.Visible = false;
            // 
            // btnBackup
            // 
            this.btnBackup.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnBackup.Image = ((System.Drawing.Image)(resources.GetObject("btnBackup.Image")));
            this.btnBackup.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBackup.Location = new System.Drawing.Point(205, 174);
            this.btnBackup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(129, 36);
            this.btnBackup.TabIndex = 17;
            this.btnBackup.UseVisualStyleBackColor = false;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // frmBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(628, 230);
            this.Controls.Add(this.pnlControls);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
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
