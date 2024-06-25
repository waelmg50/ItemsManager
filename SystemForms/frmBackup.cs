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
    public partial class frmBackup : BaseForms.frmBase
    {

        #region Constructor

        public frmBackup()
        {
            InitializeComponent();
        }

        #endregion

        #region Event Handlers

        private void btnBrowse_Click(object sender, System.EventArgs e)
        {
            fbdBackup.ShowDialog(this);
            txtBackupPath.Text = fbdBackup.SelectedPath;
        }
        private void btnBackup_Click(object sender, System.EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                string strPath = txtBackupPath.Text;
                if (!Directory.Exists(strPath))
                {
                    Helper.ShowMessage(Resources.ProgramMessages.MesPath + strPath
                        + Resources.ProgramMessages.MesDosntExist);
                    txtBackupPath.SelectAll();
                    txtBackupPath.Focus();
                }
                else
                {
                    string date = DateTime.Now.ToShortDateString();
                    date = date.Replace('/', '-');
                    strPath += @"\" + ConfigurationManager.DataBaseName + " Backup " + date + ".bak";
                    if (File.Exists(strPath))
                    {
                        if (Helper.ShowMessage("Over write existing backup file?", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question) == DialogResult.No)
                            return;
                    }
                    SqlParameter[] sqlprmarrBackup = new SqlParameter[1];
                    string strBackupCommand = "BACKUP DATABASE " + ConfigurationManager.DataBaseName + " TO DISK =@path with format";
                    if (chkBlankPassword.Checked)
                    {
                        if (Helper.ShowMessage(Resources.ProgramMessages.MesEmptyBackupPwd,
                            MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                        {
                            txtPassword.Focus();
                            return;
                        }
                    }
                    else
                    {
                        sqlprmarrBackup = new SqlParameter[2];
                        strBackupCommand += ", Password = @Password";
                        sqlprmarrBackup[1] = new SqlParameter("@Password", txtPassword.Text);
                    }
                    sqlprmarrBackup[0] = new SqlParameter("@path", strPath);
                    DBConnection.Connect();
                    SqlAdoWrapper.ExecuteNonQueryCommand(strBackupCommand, sqlprmarrBackup, true);
                    Helper.ShowMessage(Resources.ProgramMessages.MesBackupSuccessfull + strPath);
                    txtBackupPath.Clear();
                    txtPassword.Clear();
                }
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
        private void chkBlankPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.Enabled = !chkBlankPassword.Checked;
            if (chkBlankPassword.Checked)
                txtPassword.Clear();
        }

        #endregion

    }
}
