namespace ItemsManager
{
    partial class frmRestore
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
            this.pnlControls = new System.Windows.Forms.Panel();
            this.chkbxIntegratedSecurity = new System.Windows.Forms.CheckBox();
            this.cbxDatabases = new System.Windows.Forms.ComboBox();
            this.btnGetDataBases = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtDatabase = new System.Windows.Forms.TextBox();
            this.rbRestoreDB = new System.Windows.Forms.RadioButton();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblDataBaseName = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlRestore = new System.Windows.Forms.Panel();
            this.txtRestoreToFolder = new System.Windows.Forms.TextBox();
            this.lblBrowseToFolder = new System.Windows.Forms.Label();
            this.btnBrowseToFolder = new System.Windows.Forms.Button();
            this.chkBlankPassword = new System.Windows.Forms.CheckBox();
            this.txtBackupPassword = new System.Windows.Forms.TextBox();
            this.txtBackupFilePath = new System.Windows.Forms.TextBox();
            this.lblBackupPassword = new System.Windows.Forms.Label();
            this.lblRestorePath = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.rbConnectToDB = new System.Windows.Forms.RadioButton();
            this.btnRestore = new System.Windows.Forms.Button();
            this.lblServerName = new System.Windows.Forms.Label();
            this.txtServerName = new System.Windows.Forms.TextBox();
            this.ofdDatabaseBackkupFile = new System.Windows.Forms.OpenFileDialog();
            this.fbdRestoreFolder = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.errprvForm)).BeginInit();
            this.pnlControls.SuspendLayout();
            this.pnlRestore.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlControls
            // 
            this.pnlControls.Controls.Add(this.chkbxIntegratedSecurity);
            this.pnlControls.Controls.Add(this.cbxDatabases);
            this.pnlControls.Controls.Add(this.btnGetDataBases);
            this.pnlControls.Controls.Add(this.btnConnect);
            this.pnlControls.Controls.Add(this.txtUserName);
            this.pnlControls.Controls.Add(this.txtPassword);
            this.pnlControls.Controls.Add(this.txtDatabase);
            this.pnlControls.Controls.Add(this.rbRestoreDB);
            this.pnlControls.Controls.Add(this.lblUserName);
            this.pnlControls.Controls.Add(this.lblPassword);
            this.pnlControls.Controls.Add(this.lblDataBaseName);
            this.pnlControls.Controls.Add(this.btnCancel);
            this.pnlControls.Controls.Add(this.pnlRestore);
            this.pnlControls.Controls.Add(this.rbConnectToDB);
            this.pnlControls.Controls.Add(this.btnRestore);
            this.pnlControls.Controls.Add(this.lblServerName);
            this.pnlControls.Controls.Add(this.txtServerName);
            this.pnlControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlControls.Location = new System.Drawing.Point(0, 0);
            this.pnlControls.Margin = new System.Windows.Forms.Padding(4);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(665, 391);
            this.pnlControls.TabIndex = 0;
            // 
            // chkbxIntegratedSecurity
            // 
            this.chkbxIntegratedSecurity.AutoSize = true;
            this.chkbxIntegratedSecurity.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chkbxIntegratedSecurity.Location = new System.Drawing.Point(65, 81);
            this.chkbxIntegratedSecurity.Margin = new System.Windows.Forms.Padding(4);
            this.chkbxIntegratedSecurity.Name = "chkbxIntegratedSecurity";
            this.chkbxIntegratedSecurity.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkbxIntegratedSecurity.Size = new System.Drawing.Size(109, 20);
            this.chkbxIntegratedSecurity.TabIndex = 43;
            this.chkbxIntegratedSecurity.Text = "الحماية المتكاملة";
            this.chkbxIntegratedSecurity.UseVisualStyleBackColor = true;
            this.chkbxIntegratedSecurity.CheckedChanged += new System.EventHandler(this.chkbxIntegratedSecurity_CheckedChanged);
            // 
            // cbxDatabases
            // 
            this.cbxDatabases.FormattingEnabled = true;
            this.cbxDatabases.Location = new System.Drawing.Point(200, 154);
            this.cbxDatabases.Margin = new System.Windows.Forms.Padding(4);
            this.cbxDatabases.Name = "cbxDatabases";
            this.cbxDatabases.Size = new System.Drawing.Size(248, 24);
            this.cbxDatabases.TabIndex = 42;
            // 
            // btnGetDataBases
            // 
            this.btnGetDataBases.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnGetDataBases.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetDataBases.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnGetDataBases.Location = new System.Drawing.Point(33, 115);
            this.btnGetDataBases.Margin = new System.Windows.Forms.Padding(4);
            this.btnGetDataBases.Name = "btnGetDataBases";
            this.btnGetDataBases.Size = new System.Drawing.Size(141, 30);
            this.btnGetDataBases.TabIndex = 38;
            this.btnGetDataBases.Text = "عرض قواعد البيانات";
            this.btnGetDataBases.UseVisualStyleBackColor = false;
            this.btnGetDataBases.Click += new System.EventHandler(this.btnGetDataBases_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnConnect.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnConnect.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnConnect.Location = new System.Drawing.Point(33, 151);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(4);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(141, 30);
            this.btnConnect.TabIndex = 38;
            this.btnConnect.Text = "اتصال";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.SystemColors.Window;
            this.txtUserName.Location = new System.Drawing.Point(200, 80);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtUserName.Size = new System.Drawing.Size(248, 22);
            this.txtUserName.TabIndex = 37;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.Window;
            this.txtPassword.Location = new System.Drawing.Point(200, 119);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPassword.Size = new System.Drawing.Size(248, 22);
            this.txtPassword.TabIndex = 37;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtDatabase
            // 
            this.txtDatabase.BackColor = System.Drawing.SystemColors.Window;
            this.txtDatabase.Location = new System.Drawing.Point(200, 154);
            this.txtDatabase.Margin = new System.Windows.Forms.Padding(4);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDatabase.Size = new System.Drawing.Size(248, 22);
            this.txtDatabase.TabIndex = 37;
            // 
            // rbRestoreDB
            // 
            this.rbRestoreDB.AutoSize = true;
            this.rbRestoreDB.BackColor = System.Drawing.Color.Transparent;
            this.rbRestoreDB.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rbRestoreDB.Location = new System.Drawing.Point(195, 16);
            this.rbRestoreDB.Margin = new System.Windows.Forms.Padding(4);
            this.rbRestoreDB.Name = "rbRestoreDB";
            this.rbRestoreDB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbRestoreDB.Size = new System.Drawing.Size(143, 20);
            this.rbRestoreDB.TabIndex = 32;
            this.rbRestoreDB.Text = "استرجاع قاعدة البيانات";
            this.rbRestoreDB.UseVisualStyleBackColor = false;
            this.rbRestoreDB.CheckedChanged += new System.EventHandler(this.rbRestoreDB_CheckedChanged);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.BackColor = System.Drawing.Color.Transparent;
            this.lblUserName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblUserName.Location = new System.Drawing.Point(505, 83);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblUserName.Size = new System.Drawing.Size(76, 16);
            this.lblUserName.TabIndex = 41;
            this.lblUserName.Text = "اسم المستخدم :";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPassword.Location = new System.Drawing.Point(513, 122);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPassword.Size = new System.Drawing.Size(68, 16);
            this.lblPassword.TabIndex = 41;
            this.lblPassword.Text = "كلمة المرور :";
            // 
            // lblDataBaseName
            // 
            this.lblDataBaseName.AutoSize = true;
            this.lblDataBaseName.BackColor = System.Drawing.Color.Transparent;
            this.lblDataBaseName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblDataBaseName.Location = new System.Drawing.Point(479, 158);
            this.lblDataBaseName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataBaseName.Name = "lblDataBaseName";
            this.lblDataBaseName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblDataBaseName.Size = new System.Drawing.Size(102, 16);
            this.lblDataBaseName.TabIndex = 41;
            this.lblDataBaseName.Text = "اسم قاعدة البيانات :";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCancel.Location = new System.Drawing.Point(23, 347);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(117, 30);
            this.btnCancel.TabIndex = 40;
            this.btnCancel.Text = "إلغاء";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pnlRestore
            // 
            this.pnlRestore.BackColor = System.Drawing.Color.Transparent;
            this.pnlRestore.Controls.Add(this.txtRestoreToFolder);
            this.pnlRestore.Controls.Add(this.lblBrowseToFolder);
            this.pnlRestore.Controls.Add(this.btnBrowseToFolder);
            this.pnlRestore.Controls.Add(this.chkBlankPassword);
            this.pnlRestore.Controls.Add(this.txtBackupPassword);
            this.pnlRestore.Controls.Add(this.txtBackupFilePath);
            this.pnlRestore.Controls.Add(this.lblBackupPassword);
            this.pnlRestore.Controls.Add(this.lblRestorePath);
            this.pnlRestore.Controls.Add(this.btnBrowse);
            this.pnlRestore.Enabled = false;
            this.pnlRestore.Location = new System.Drawing.Point(5, 193);
            this.pnlRestore.Margin = new System.Windows.Forms.Padding(4);
            this.pnlRestore.Name = "pnlRestore";
            this.pnlRestore.Size = new System.Drawing.Size(653, 146);
            this.pnlRestore.TabIndex = 28;
            // 
            // txtRestoreToFolder
            // 
            this.txtRestoreToFolder.BackColor = System.Drawing.Color.White;
            this.txtRestoreToFolder.Location = new System.Drawing.Point(136, 80);
            this.txtRestoreToFolder.Margin = new System.Windows.Forms.Padding(4);
            this.txtRestoreToFolder.Name = "txtRestoreToFolder";
            this.txtRestoreToFolder.ReadOnly = true;
            this.txtRestoreToFolder.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtRestoreToFolder.Size = new System.Drawing.Size(327, 22);
            this.txtRestoreToFolder.TabIndex = 12;
            this.txtRestoreToFolder.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblBrowseToFolder
            // 
            this.lblBrowseToFolder.AutoSize = true;
            this.lblBrowseToFolder.BackColor = System.Drawing.Color.Transparent;
            this.lblBrowseToFolder.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblBrowseToFolder.Location = new System.Drawing.Point(303, 58);
            this.lblBrowseToFolder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBrowseToFolder.Name = "lblBrowseToFolder";
            this.lblBrowseToFolder.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblBrowseToFolder.Size = new System.Drawing.Size(238, 16);
            this.lblBrowseToFolder.TabIndex = 11;
            this.lblBrowseToFolder.Text = "اختر المسار الذي سيتم إنشاء قاعدة البيانات فيه :";
            // 
            // btnBrowseToFolder
            // 
            this.btnBrowseToFolder.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnBrowseToFolder.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnBrowseToFolder.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBrowseToFolder.Location = new System.Drawing.Point(28, 78);
            this.btnBrowseToFolder.Margin = new System.Windows.Forms.Padding(4);
            this.btnBrowseToFolder.Name = "btnBrowseToFolder";
            this.btnBrowseToFolder.Size = new System.Drawing.Size(100, 28);
            this.btnBrowseToFolder.TabIndex = 13;
            this.btnBrowseToFolder.Text = "استعراض";
            this.btnBrowseToFolder.UseVisualStyleBackColor = false;
            this.btnBrowseToFolder.Click += new System.EventHandler(this.btnBrowseToFolder_Click);
            // 
            // chkBlankPassword
            // 
            this.chkBlankPassword.AutoSize = true;
            this.chkBlankPassword.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chkBlankPassword.Location = new System.Drawing.Point(28, 117);
            this.chkBlankPassword.Margin = new System.Windows.Forms.Padding(4);
            this.chkBlankPassword.Name = "chkBlankPassword";
            this.chkBlankPassword.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkBlankPassword.Size = new System.Drawing.Size(103, 20);
            this.chkBlankPassword.TabIndex = 10;
            this.chkBlankPassword.Text = "بدون كلمة مرور";
            this.chkBlankPassword.UseVisualStyleBackColor = true;
            this.chkBlankPassword.CheckedChanged += new System.EventHandler(this.chkBlankPassword_CheckedChanged);
            // 
            // txtBackupPassword
            // 
            this.txtBackupPassword.Location = new System.Drawing.Point(243, 116);
            this.txtBackupPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtBackupPassword.Name = "txtBackupPassword";
            this.txtBackupPassword.PasswordChar = '*';
            this.txtBackupPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBackupPassword.Size = new System.Drawing.Size(220, 22);
            this.txtBackupPassword.TabIndex = 9;
            this.txtBackupPassword.UseSystemPasswordChar = true;
            // 
            // txtBackupFilePath
            // 
            this.txtBackupFilePath.BackColor = System.Drawing.Color.White;
            this.txtBackupFilePath.Location = new System.Drawing.Point(136, 30);
            this.txtBackupFilePath.Margin = new System.Windows.Forms.Padding(4);
            this.txtBackupFilePath.Name = "txtBackupFilePath";
            this.txtBackupFilePath.ReadOnly = true;
            this.txtBackupFilePath.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBackupFilePath.Size = new System.Drawing.Size(327, 22);
            this.txtBackupFilePath.TabIndex = 0;
            this.txtBackupFilePath.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblBackupPassword
            // 
            this.lblBackupPassword.AutoSize = true;
            this.lblBackupPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblBackupPassword.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblBackupPassword.Location = new System.Drawing.Point(479, 114);
            this.lblBackupPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBackupPassword.Name = "lblBackupPassword";
            this.lblBackupPassword.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblBackupPassword.Size = new System.Drawing.Size(104, 16);
            this.lblBackupPassword.TabIndex = 0;
            this.lblBackupPassword.Text = "كلمة مرور الأرشيف :";
            // 
            // lblRestorePath
            // 
            this.lblRestorePath.AutoSize = true;
            this.lblRestorePath.BackColor = System.Drawing.Color.Transparent;
            this.lblRestorePath.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblRestorePath.Location = new System.Drawing.Point(407, 10);
            this.lblRestorePath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRestorePath.Name = "lblRestorePath";
            this.lblRestorePath.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblRestorePath.Size = new System.Drawing.Size(165, 16);
            this.lblRestorePath.TabIndex = 0;
            this.lblRestorePath.Text = "اختر ملف أرشيف قاعدة البيانات :";
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnBrowse.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnBrowse.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBrowse.Location = new System.Drawing.Point(28, 30);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(4);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(100, 28);
            this.btnBrowse.TabIndex = 8;
            this.btnBrowse.Text = "استعراض";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // rbConnectToDB
            // 
            this.rbConnectToDB.AutoSize = true;
            this.rbConnectToDB.BackColor = System.Drawing.Color.Transparent;
            this.rbConnectToDB.Checked = true;
            this.rbConnectToDB.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rbConnectToDB.Location = new System.Drawing.Point(480, 16);
            this.rbConnectToDB.Margin = new System.Windows.Forms.Padding(4);
            this.rbConnectToDB.Name = "rbConnectToDB";
            this.rbConnectToDB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbConnectToDB.Size = new System.Drawing.Size(126, 20);
            this.rbConnectToDB.TabIndex = 33;
            this.rbConnectToDB.TabStop = true;
            this.rbConnectToDB.Text = "اتصال بقاعدة بيانات";
            this.rbConnectToDB.UseVisualStyleBackColor = false;
            this.rbConnectToDB.CheckedChanged += new System.EventHandler(this.rbConnectToDB_CheckedChanged);
            // 
            // btnRestore
            // 
            this.btnRestore.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnRestore.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnRestore.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnRestore.Location = new System.Drawing.Point(156, 347);
            this.btnRestore.Margin = new System.Windows.Forms.Padding(4);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(117, 30);
            this.btnRestore.TabIndex = 39;
            this.btnRestore.Text = "استرجاع";
            this.btnRestore.UseVisualStyleBackColor = false;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // lblServerName
            // 
            this.lblServerName.AutoSize = true;
            this.lblServerName.BackColor = System.Drawing.Color.Transparent;
            this.lblServerName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblServerName.Location = new System.Drawing.Point(519, 47);
            this.lblServerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblServerName.Name = "lblServerName";
            this.lblServerName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblServerName.Size = new System.Drawing.Size(62, 16);
            this.lblServerName.TabIndex = 30;
            this.lblServerName.Text = "اسم الخادم :";
            // 
            // txtServerName
            // 
            this.txtServerName.BackColor = System.Drawing.SystemColors.Window;
            this.txtServerName.Location = new System.Drawing.Point(200, 44);
            this.txtServerName.Margin = new System.Windows.Forms.Padding(4);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtServerName.Size = new System.Drawing.Size(248, 22);
            this.txtServerName.TabIndex = 34;
            // 
            // frmRestore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(665, 391);
            this.Controls.Add(this.pnlControls);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "frmRestore";
            this.Text = "مدير الأصناف - بيانات قاعدة البيانات";
            this.Load += new System.EventHandler(this.frmRestore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errprvForm)).EndInit();
            this.pnlControls.ResumeLayout(false);
            this.pnlControls.PerformLayout();
            this.pnlRestore.ResumeLayout(false);
            this.pnlRestore.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlControls;
        public System.Windows.Forms.Button btnConnect;
        public System.Windows.Forms.TextBox txtDatabase;
        public System.Windows.Forms.RadioButton rbRestoreDB;
        private System.Windows.Forms.Label lblDataBaseName;
        public System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel pnlRestore;
        private System.Windows.Forms.TextBox txtRestoreToFolder;
        private System.Windows.Forms.Label lblBrowseToFolder;
        private System.Windows.Forms.Button btnBrowseToFolder;
        private System.Windows.Forms.CheckBox chkBlankPassword;
        private System.Windows.Forms.TextBox txtBackupPassword;
        private System.Windows.Forms.TextBox txtBackupFilePath;
        private System.Windows.Forms.Label lblBackupPassword;
        private System.Windows.Forms.Label lblRestorePath;
        private System.Windows.Forms.Button btnBrowse;
        public System.Windows.Forms.RadioButton rbConnectToDB;
        private System.Windows.Forms.Label lblServerName;
        public System.Windows.Forms.TextBox txtServerName;
        private System.Windows.Forms.OpenFileDialog ofdDatabaseBackkupFile;
        private System.Windows.Forms.FolderBrowserDialog fbdRestoreFolder;
        public System.Windows.Forms.TextBox txtUserName;
        public System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.ComboBox cbxDatabases;
        public System.Windows.Forms.Button btnGetDataBases;
        public System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.CheckBox chkbxIntegratedSecurity;
    }
}
