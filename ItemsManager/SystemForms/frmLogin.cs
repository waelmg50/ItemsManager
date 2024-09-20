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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
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
            resources.ApplyResources(this.pnlControls, "pnlControls");
            this.pnlControls.Name = "pnlControls";
            // 
            // txtUserName
            // 
            resources.ApplyResources(this.txtUserName, "txtUserName");
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Tag = "1";
            // 
            // lblPassword
            // 
            resources.ApplyResources(this.lblPassword, "lblPassword");
            this.lblPassword.Name = "lblPassword";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnLogin
            // 
            resources.ApplyResources(this.btnLogin, "btnLogin");
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPassword
            // 
            resources.ApplyResources(this.txtPassword, "txtPassword");
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Tag = "1";
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // lblUserName
            // 
            resources.ApplyResources(this.lblUserName, "lblUserName");
            this.lblUserName.Name = "lblUserName";
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btnLogin;
            resources.ApplyResources(this, "$this");
            this.CancelButton = this.btnCancel;
            this.Controls.Add(this.pnlControls);
            this.Font = this.Font;
            this.Icon = this.Icon;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
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

