namespace ItemsManager.Shifts
{
    partial class frmShiftIn
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
            this.components = new System.ComponentModel.Container();
            this.pnlControls = new System.Windows.Forms.Panel();
            this.txtnCashIn = new CustomControls.NumericTextBox();
            this.lblCashIn = new System.Windows.Forms.Label();
            this.dtpDateIn = new System.Windows.Forms.DateTimePicker();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblDateIn = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.tmrTime = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errprvForm)).BeginInit();
            this.pnlControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlControls
            // 
            this.pnlControls.BackColor = System.Drawing.Color.Transparent;
            this.pnlControls.Controls.Add(this.txtnCashIn);
            this.pnlControls.Controls.Add(this.lblCashIn);
            this.pnlControls.Controls.Add(this.dtpDateIn);
            this.pnlControls.Controls.Add(this.txtUserName);
            this.pnlControls.Controls.Add(this.lblDateIn);
            this.pnlControls.Controls.Add(this.lblPassword);
            this.pnlControls.Controls.Add(this.btnCancel);
            this.pnlControls.Controls.Add(this.btnLogin);
            this.pnlControls.Controls.Add(this.txtPassword);
            this.pnlControls.Controls.Add(this.lblUserName);
            this.pnlControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlControls.Location = new System.Drawing.Point(0, 0);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(332, 141);
            this.pnlControls.TabIndex = 7;
            // 
            // txtnCashIn
            // 
            this.txtnCashIn.IsInt = false;
            this.txtnCashIn.Location = new System.Drawing.Point(138, 83);
            this.txtnCashIn.MaxLength = 7;
            this.txtnCashIn.Name = "txtnCashIn";
            this.txtnCashIn.Size = new System.Drawing.Size(74, 20);
            this.txtnCashIn.TabIndex = 32;
            this.txtnCashIn.Tag = "1";
            // 
            // lblCashIn
            // 
            this.lblCashIn.AutoSize = true;
            this.lblCashIn.Location = new System.Drawing.Point(236, 83);
            this.lblCashIn.Name = "lblCashIn";
            this.lblCashIn.Size = new System.Drawing.Size(72, 13);
            this.lblCashIn.TabIndex = 31;
            this.lblCashIn.Text = "قيمة الصندوق";
            // 
            // dtpDateIn
            // 
            this.dtpDateIn.CustomFormat = "dddd dd/MM/yyyy -- t ss:mm:hh";
            this.dtpDateIn.Enabled = false;
            this.dtpDateIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateIn.Location = new System.Drawing.Point(16, 59);
            this.dtpDateIn.Name = "dtpDateIn";
            this.dtpDateIn.RightToLeftLayout = true;
            this.dtpDateIn.Size = new System.Drawing.Size(196, 20);
            this.dtpDateIn.TabIndex = 6;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(112, 11);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(100, 20);
            this.txtUserName.TabIndex = 1;
            this.txtUserName.Tag = "1";
            // 
            // lblDateIn
            // 
            this.lblDateIn.AutoSize = true;
            this.lblDateIn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblDateIn.Location = new System.Drawing.Point(218, 59);
            this.lblDateIn.Name = "lblDateIn";
            this.lblDateIn.Size = new System.Drawing.Size(90, 13);
            this.lblDateIn.TabIndex = 1;
            this.lblDateIn.Text = "تاريخ ووقت الدخول";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPassword.Location = new System.Drawing.Point(249, 35);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(59, 13);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "كلمة المرور";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCancel.Location = new System.Drawing.Point(75, 107);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "إلغاء";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnLogin.Location = new System.Drawing.Point(189, 107);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(90, 23);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "تسجيل الدخول";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(112, 35);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.Tag = "1";
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblUserName.Location = new System.Drawing.Point(227, 11);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(81, 13);
            this.lblUserName.TabIndex = 5;
            this.lblUserName.Text = "اسم المستخدم";
            // 
            // tmrTime
            // 
            this.tmrTime.Enabled = true;
            this.tmrTime.Interval = 1000;
            this.tmrTime.Tick += new System.EventHandler(this.tmrTime_Tick);
            // 
            // frmShiftIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(332, 141);
            this.Controls.Add(this.pnlControls);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmShiftIn";
            this.Text = "مدير الأصناف - بداية وردية";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmShiftIn_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.errprvForm)).EndInit();
            this.pnlControls.ResumeLayout(false);
            this.pnlControls.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.DateTimePicker dtpDateIn;
        private System.Windows.Forms.Timer tmrTime;
        private System.Windows.Forms.Label lblDateIn;
        private CustomControls.NumericTextBox txtnCashIn;
        private System.Windows.Forms.Label lblCashIn;
    }
}
