using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Utilities;

namespace ItemsManager
{
	public class frmLogin : BaseForms.frmBase
    {

        #region Private Members

        short siLoginStatus = 0;
        int iOldUserID = UserLogin.LoggedUserID;

        #endregion

        private Panel pnlControls;
        private TextBox txtUserName;
        private Label lblPassword;
        private Button btnCancel;
        private Button btnLogin;
        private TextBox txtPassword;
        private Label lblUserName;

        #region Properties

        /// <summary>
        /// Gets and sets the login status of the application as follows:
        /// 0: First Login.
        /// 1: Log Out.
        /// 3: Temp Close.
        /// </summary>
        public short LoginStatus
        {
            get
            {
                return siLoginStatus;
            }
            set
            {
                siLoginStatus = value;
            }
        }

        #endregion

        #region Auto Generated Code

        private System.ComponentModel.IContainer components = null;

		public frmLogin()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitializeComponent call
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.pnlControls = new System.Windows.Forms.Panel();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errprvForm)).BeginInit();
            this.pnlControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlControls
            // 
            this.pnlControls.BackColor = System.Drawing.Color.Transparent;
            this.pnlControls.Controls.Add(this.txtUserName);
            this.pnlControls.Controls.Add(this.lblPassword);
            this.pnlControls.Controls.Add(this.btnCancel);
            this.pnlControls.Controls.Add(this.btnLogin);
            this.pnlControls.Controls.Add(this.txtPassword);
            this.pnlControls.Controls.Add(this.lblUserName);
            this.pnlControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlControls.Location = new System.Drawing.Point(0, 0);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlControls.Size = new System.Drawing.Size(355, 151);
            this.pnlControls.TabIndex = 6;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(81, 20);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(100, 22);
            this.txtUserName.TabIndex = 1;
            this.txtUserName.Tag = "1";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPassword.Location = new System.Drawing.Point(206, 58);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(68, 16);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "كلمة المرور :";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCancel.Location = new System.Drawing.Point(81, 100);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 30);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "إلغاء";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnLogin.Location = new System.Drawing.Point(188, 100);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(86, 30);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "تسجيل الدخول";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(81, 55);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 22);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.Tag = "1";
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblUserName.Location = new System.Drawing.Point(198, 23);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(76, 16);
            this.lblUserName.TabIndex = 5;
            this.lblUserName.Text = "اسم المستخدم :";
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(355, 151);
            this.Controls.Add(this.pnlControls);
            this.Font = this.Font;
            this.Icon = this.Icon;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.Text = "مدير الأصناف - تسجيل الدخول";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLogin_FormClosing);
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errprvForm)).EndInit();
            this.pnlControls.ResumeLayout(false);
            this.pnlControls.PerformLayout();
            this.ResumeLayout(false);

		}
		#endregion
        #endregion

        #region Event Handlers

        private void frmLogin_Load(object sender, EventArgs e)
        {
            
        }
        private void btnCancel_Click(object sender, System.EventArgs e)
		{
            if (siLoginStatus == 3)
            {
                return;
            }
			Application.Exit();
		}
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (UserLogin.CheckUser(txtUserName.Text, txtPassword.Text))
                {
                    if (siLoginStatus == 3 && iOldUserID != UserLogin.LoggedUserID)
                    {
                        Helper.ShowMessage(Resources.ProgramMessages.MesInvalidUser);
                        UserLogin.LoggedUserID = iOldUserID;
                        return;
                    }
                    Close();
                }
                else
                {
                    Helper.ShowMessage(Resources.ProgramMessages.MesInvalidLogin);
                    return;
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }
        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (siLoginStatus != 3 && UserLogin.LoggedUserID <= 0)
                    Application.Exit();
                if (UserLogin.CheckUser(txtUserName.Text, txtPassword.Text))
                {
                    if (siLoginStatus == 3 && iOldUserID != UserLogin.LoggedUserID)
                    {
                        Helper.ShowMessage(Resources.ProgramMessages.MesInvalidUser);
                        e.Cancel = true;
                    }
                }
                else
                {
                    if (siLoginStatus == 3)
                    {
                        Helper.ShowMessage(Resources.ProgramMessages.MesInvalidUser);
                        e.Cancel = true;
                    }
                    else
                        Application.Exit();
                }
                if (UserLogin.LoggedUserID <= 0)
                    Application.Exit();
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }

        #endregion
        
    }
}

