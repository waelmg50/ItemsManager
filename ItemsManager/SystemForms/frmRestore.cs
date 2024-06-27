using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.IO;
using System.Windows.Forms;
using Utilities;

namespace ItemsManager
{
    public partial class frmRestore : BaseForms.frmBase
    {

        #region Constructor

        public frmRestore()
        {
            InitializeComponent();
        }

        #endregion

        #region Private Memebers

        string strServername, strDatabaseName, strUsername, strPassword;
        bool bConnectOnly = true, bIntegratedSecurity = false;

        #endregion

        #region Extra Form Properties

        public bool ConnectOnly
        {
            get { return bConnectOnly; }
            set { bConnectOnly = value; }
        }

        #endregion

        #region Event Handlers

        private void chkBlankPassword_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                txtBackupPassword.Enabled = !chkBlankPassword.Checked;
                if (chkBlankPassword.Checked)
                    txtBackupPassword.Clear();
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }
        private void rbRestoreDB_CheckedChanged(object sender, EventArgs e)
        {
            txtDatabase.Visible = btnRestore.Enabled = pnlRestore.Enabled = rbRestoreDB.Checked;
        }
        private void rbConnectToDB_CheckedChanged(object sender, EventArgs e)
        {
            btnConnect.Enabled = btnGetDataBases.Visible = cbxDatabases.Visible = rbConnectToDB.Checked;
        }
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                ofdDatabaseBackkupFile.ShowDialog(this);
                txtBackupFilePath.Text = ofdDatabaseBackkupFile.FileName;
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }
        private void btnRestore_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckError())
                {
                    string strCommandText;
                    Cursor.Current = Cursors.WaitCursor;
                    if (File.Exists(ofdDatabaseBackkupFile.FileName))
                    {
                        strCommandText = "RESTORE FILELISTONLY from disk = @path";
                        SqlParameter[] sqlprmarrRestFileList = new SqlParameter[1];
                        if (!chkBlankPassword.Checked)
                        {
                            sqlprmarrRestFileList = new SqlParameter[2];
                            strCommandText += " with Password = @Password";
                            sqlprmarrRestFileList[1] = new SqlParameter("@Password", txtBackupPassword.Text);
                        }
                        sqlprmarrRestFileList[0] = new SqlParameter("@path", ofdDatabaseBackkupFile.FileName);
                        DBConnection.Connect(txtServerName.Text, "master", txtUserName.Text, txtPassword.Text, chkbxIntegratedSecurity.Checked);
                        DataTable dtUsers = new DataTable();
                        dtUsers = SqlAdoWrapper.ExecuteQueryCommand(strCommandText, sqlprmarrRestFileList,
                            true);
                        int iInitialRowIndex = 1;
                        SqlParameter[] sqlprmarrRestoreDB;
                        if (dtUsers == null || dtUsers.Rows.Count == 0)
                            return;
                        else
                        {
                            strCommandText = "RESTORE DATABASE @DatabaseName FROM DISK = @path with ";
                            sqlprmarrRestoreDB = new SqlParameter[2 + dtUsers.Rows.Count];
                            if (!chkBlankPassword.Checked)
                            {
                                sqlprmarrRestoreDB = new SqlParameter[3 + dtUsers.Rows.Count];
                                strCommandText += "Password = @Password, ";
                                sqlprmarrRestoreDB[2] = new SqlParameter("@Password", txtBackupPassword.Text);
                                iInitialRowIndex = 2;
                            }
                            sqlprmarrRestoreDB[0] = new SqlParameter("@path", ofdDatabaseBackkupFile.FileName);
                            sqlprmarrRestoreDB[1] = new SqlParameter("@DatabaseName", txtDatabase.Text);
                        }
                        int iDataRowCounter = 0, iLogRowCounter = 0;
                        foreach (DataRow drLogicalFile in dtUsers.Rows)
                        {
                            int iRowIndex = iDataRowCounter + iLogRowCounter + 1;
                            string strLogicalFilePath = "_Data" + iRowIndex.ToString() + ".mdf";
                            string strLogicalFileParameter = "@DataFilePath" + iRowIndex.ToString();
                            if (drLogicalFile["Type"].ToString() == "L")
                            {
                                //iRowIndex = ++iLogRowCounter;
                                iLogRowCounter++;
                                strLogicalFilePath = "_Log" + iLogRowCounter.ToString() + ".ldf";
                                strLogicalFileParameter = "@LogFilePath" + iLogRowCounter.ToString();
                            }
                            else
                                iDataRowCounter++;
                            strCommandText += "Move '" + drLogicalFile["LogicalName"].ToString()
                                + "' TO " + strLogicalFileParameter + ",";
                            sqlprmarrRestoreDB[iRowIndex + iInitialRowIndex]
                                = new SqlParameter(strLogicalFileParameter, txtRestoreToFolder.Text + @"\"
                                    + txtDatabase.Text + strLogicalFilePath);
                        }
                        strCommandText = strCommandText.Substring(0, strCommandText.Length - 1);
                        SqlAdoWrapper.ExecuteNonQueryCommand(strCommandText, sqlprmarrRestoreDB, true);
                        ConfigurationManager.DataBaseName = txtDatabase.Text;
                        Helper.ShowMessage(Resources.ProgramMessages.MesRestoreSuccessfull);
                        Application.Restart();
                    }
                    Cursor.Current = Cursors.Default;
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
                LoadOldValues();
            }
        }
        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                DBConnection.Disconnect();
                if (DBConnection.Connect(txtServerName.Text, cbxDatabases.Text, txtUserName.Text,
                    txtPassword.Text, chkbxIntegratedSecurity.Checked))
                {
                    Helper.ShowMessage(Resources.ProgramMessages.MesConnectSuccessfull);
                    Application.Restart();
                }
                else
                    LoadOldValues();
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }
        private void frmRestore_Load(object sender, EventArgs e)
        {
            try
            {
                strDatabaseName = ConfigurationManager.DataBaseName;
                strUsername = ConfigurationManager.Username;
                strServername = ConfigurationManager.ServerName;
                strPassword = ConfigurationManager.Password;
                bIntegratedSecurity = ConfigurationManager.IntegratedSecurity;
                rbRestoreDB.Enabled = !bConnectOnly;
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnBrowseToFolder_Click(object sender, EventArgs e)
        {
            try
            {
                fbdRestoreFolder.ShowDialog(this);
                if (fbdRestoreFolder.SelectedPath.Length > 0 && Directory.Exists(fbdRestoreFolder.SelectedPath))
                {
                    if (File.Exists(txtRestoreToFolder.Text + txtDatabase.Text + "_Data.mdf") ||
                        File.Exists(txtRestoreToFolder.Text + txtDatabase.Text + "_Log.ldf"))
                        Helper.ShowMessage(Resources.ProgramMessages.ErrMesDBFilesExit);
                    else
                        txtRestoreToFolder.Text = fbdRestoreFolder.SelectedPath;
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }
        private void btnGetDataBases_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                cbxDatabases.Tag = null;
                if (ValidateForm() && DBConnection.Connect(txtServerName.Text, "master", txtUserName.Text, txtPassword.Text, chkbxIntegratedSecurity.Checked))
                {
                    cbxDatabases.DataSource = SqlAdoWrapper.SelectServerDatabases(false);
                    cbxDatabases.DisplayMember = cbxDatabases.ValueMember = "DataBaseName";
                    cbxDatabases.Tag = 1;
                }
                else
                    LoadOldValues();
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
        private void chkbxIntegratedSecurity_CheckedChanged(object sender, EventArgs e)
        {
            if(chkbxIntegratedSecurity.Checked)
            {
                txtPassword.Enabled = txtUserName.Enabled = false;
                txtPassword.Text = txtUserName.Text = string.Empty;
                btnGetDataBases.Focus();
            }
            else
            {
                txtPassword.Enabled = txtUserName.Enabled = true;
                txtUserName.Focus();
            }
        }

        #endregion

        #region Private Methods

        bool CheckError()
        {
            try
            {
                bool Result = true;
                errprvForm.Clear();
                if (txtServerName.Text.Trim().Length == 0)
                {
                    errprvForm.SetIconAlignment(txtServerName, ErrorIconAlignment.MiddleLeft);
                    errprvForm.SetError(txtServerName, Resources.ProgramMessages.ErrMesEnterServerName);
                    Result = false;
                }
                if (txtDatabase.Text.Trim().Length == 0)
                {
                    errprvForm.SetIconAlignment(txtDatabase, ErrorIconAlignment.MiddleLeft);
                    errprvForm.SetError(txtDatabase, Resources.ProgramMessages.ErrMesEnterDBName);
                    Result = false;
                }
                if (rbRestoreDB.Checked && txtBackupFilePath.Text.Trim().Length == 0)
                {
                    errprvForm.SetIconAlignment(btnBrowse, ErrorIconAlignment.MiddleLeft);
                    errprvForm.SetError(btnBrowse, Resources.ProgramMessages.ErrMesChooseBackupFile);
                    Result = false;
                }
                if (rbRestoreDB.Checked && !(chkBlankPassword.Checked) && txtBackupPassword.Text.Trim().Length == 0)
                {
                    errprvForm.SetIconAlignment(txtBackupPassword, ErrorIconAlignment.MiddleLeft);
                    errprvForm.SetError(txtBackupPassword, Resources.ProgramMessages.ErrMesEnterBackupFilePassword);
                    Result = false;
                }
                if (rbRestoreDB.Checked && txtRestoreToFolder.Text.Length == 0)
                {
                    errprvForm.SetIconAlignment(btnBrowseToFolder, ErrorIconAlignment.MiddleLeft);
                    errprvForm.SetError(btnBrowseToFolder, Resources.ProgramMessages.ErrMesEnterBackupPath);
                    Result = false;
                }
                if (rbRestoreDB.Checked && (File.Exists(txtRestoreToFolder.Text + txtDatabase.Text + "_Data.mdf") ||
                        File.Exists(txtRestoreToFolder.Text + txtDatabase.Text + "_Log.ldf")))
                {
                    errprvForm.SetIconAlignment(btnBrowseToFolder, ErrorIconAlignment.MiddleLeft);
                    errprvForm.SetError(btnBrowseToFolder, Resources.ProgramMessages.ErrMesDBFilesExit);
                    Result = false;
                }
                return Result;
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
                return false;
            }
        }
        void LoadOldValues()
        {
            try
            {
                ConfigurationManager.DataBaseName = strDatabaseName;
                ConfigurationManager.Password = strPassword;
                ConfigurationManager.ServerName = strServername;
                ConfigurationManager.Username = strUsername;
                ConfigurationManager.IntegratedSecurity = bIntegratedSecurity;
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }

        #endregion

    }
}
