using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Utilities;
using Entities;
using Managers;

namespace ItemsManager.SystemForms
{
    public partial class frmUsers : ItemsManager.BaseForms.frmActionBase
    {
        
        #region Constructor

        public frmUsers()
        {
            strTableName = "Users";
            InitializeComponent();
        }

        #endregion

        #region Members

        entUsers Crrnt = new entUsers();

        #endregion

        #region Overrided Methods

        protected override int InsertData()
        {
            try
            {
                base.InsertData();
                return mngrUsers.Insert(Crrnt);
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
                return -1;
            }
        }
        protected override int UpdateData()
        {
            try
            {
                base.UpdateData();
                return mngrUsers.Update(Crrnt);
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
                return -1;
            }
        }
        protected override int Delete()
        {
            try
            {
                base.Delete();
                return mngrUsers.Delete(iRecordID);
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
                return 0;
            }
        }
        protected override void DisplayObject()
        {
            try
            {
                base.DisplayObject();
                if (iRecordID > 0)
                {
                    Crrnt = new entUsers(iRecordID);
                    txtUsername.Text = Crrnt.Username;
                    txtPasswordConfirmation.Text = txtPassword.Text = Crrnt.Password;
                    txtFullName.Text = Crrnt.FullName;
                    chkIsActive.Checked = Crrnt.IsActive;
                    chkIsAdmin.Checked = Crrnt.IsAdmin;
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }
        protected override void GetObject()
        {
            try
            {
                base.GetObject();
                ReInitialize();
                if (iRecordID > 0)
                    Crrnt.ID = iRecordID;
                Crrnt.Username = txtUsername.Text;
                Crrnt.Password = txtPassword.Text;
                Crrnt.FullName = txtFullName.Text;
                Crrnt.IsActive = chkIsActive.Checked;
                Crrnt.IsAdmin = chkIsAdmin.Checked;
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }
        protected override bool IsFormModified()
        {
            bool Res = base.IsFormModified();
            if (frmstsStatus == SystemClasses.Enumerations.FormStatus.New)
                return Res || txtUsername.Text.Length > 0 || txtPassword.Text.Length > 0 || txtFullName.Text.Length > 0 || chkIsAdmin.Checked
                    || chkIsActive.Checked;
            else
            {
                GetObject();
                return Crrnt != new entUsers (iRecordID);
            }
        }
        protected override void SetFocus()
        {
            try
            {
                base.SetFocus();
                txtUsername.Focus();
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }
        protected override void ReInitialize()
        {
            base.ReInitialize();
            Crrnt = new entUsers();
        }
        protected override bool ValidateForm()
        {
            try
            {
                bool Res = base.ValidateForm();
                if (RecordsFunctions.IsDataExists(strTableName, "Username", txtUsername.Text, iRecordID))
                {
                    errprvForm.SetError(txtUsername, Resources.ProgramMessages.ErrMesUserNameExist);
                    Res = false;
                }
                if (txtUsername.Text.Length < 4 && txtUsername.Text.Length > 0)
                {
                    errprvForm.SetError(txtUsername, Resources.ProgramMessages.MesUsrNameNotLess4Char);
                    Res = false;
                }
                if (txtPassword.Text.Length < 4 && txtPassword.Text.Length > 0)
                {
                    errprvForm.SetError(txtPassword, Resources.ProgramMessages.MesPassrdNotLess4Char);
                    Res = false;
                }
                if (txtPassword.Text.Length > 4 && txtPassword.Text.Length > 0 && txtPasswordConfirmation.Text != txtPassword.Text)
                {
                    errprvForm.SetError(txtPassword, Resources.ProgramMessages.MesInvalidPassConf);
                    errprvForm.SetError(txtPasswordConfirmation, Resources.ProgramMessages.MesInvalidPassConf);
                    Res = false;
                }
                return Res;
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
                return false;
            }
        }

        #endregion

    }
}