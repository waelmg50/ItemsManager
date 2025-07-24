using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Utilities;

namespace ItemsManager
{
    public partial class frmSearch : BaseForms.frmBase
    {

        #region Private Members

        string strTableName = string.Empty;
        int iSelectedRowID = 0;

        #endregion

        #region Properties

        public int SelectedRowID
        {
            get { return iSelectedRowID; }
        }

        #endregion

        #region Constructor

        public frmSearch(string TableName)
        {
            try
            {
                if (!SqlAdoWrapper.CheckTableName(TableName))
                {
                    Helper.ShowMessage(Resources.ProgramMessages.ErrMesInvldTblName);
                    return;
                }
                InitializeComponent();
                strTableName = TableName;
                CreateGridColumns();
                AddSerachColumns();
                lblTableName.Text = Managers.mngrTableNames.GetDisplayNameByDBName(TableName);
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }

        #endregion

        #region Private Methods

        void CreateGridColumns()
        {
            try
            {
                if (dgvSearchRes.Columns.Count > 0)
                    dgvSearchRes.Columns.Clear();
                DataTable tblSearchColummns = SqlAdoWrapper.GetTableColumnNames(strTableName, false);
                if (tblSearchColummns != null && tblSearchColummns.Rows.Count > 0)
                    foreach (DataRow drowColumn in tblSearchColummns.Rows)
                    {
                        DataGridViewTextBoxColumn dgvcSearchColumn = new DataGridViewTextBoxColumn();
                        dgvcSearchColumn.HeaderText = drowColumn["DisplayName"].ToString();
                        dgvcSearchColumn.DataPropertyName = drowColumn["DBName"].ToString();
                        dgvcSearchColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        dgvcSearchColumn.ValueType = typeof(string);
                        dgvcSearchColumn.Name = "dgvtbxc" + drowColumn["DBName"].ToString();
                        dgvSearchRes.Columns.Add(dgvcSearchColumn);
                    }
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }
        void AddSerachColumns()
        {
            try
            {
                if (cbxSearchIn.Items.Count > 0)
                    cbxSearchIn.Items.Clear();
                DataTable tblSearchInColumns = SqlAdoWrapper.GetTableColumnNames(strTableName, true);
                //DataTable tblSearchInColumnsSource = new DataTable();
                //tblSearchInColumnsSource.Columns.Add("DBName");
                //tblSearchInColumnsSource.Columns.Add(Resources.ProgramMessages.MesNameField);
                //foreach (DataRow drowColumns in tblSearchInColumns.Rows)
                //{
                //    DataRow drowSource = tblSearchInColumnsSource.NewRow();
                //    drowSource["DBName"] = drowColumns["DBName"];
                //    drowSource["ColumnDisplayName"] = GetDisplayName(drowColumns["ColumnName"].ToString());
                //    tblSearchInColumnsSource.Rows.Add(drowSource);
                //}
                cbxSearchIn.DataSource = tblSearchInColumns;
                cbxSearchIn.DisplayMember = "DisplayName";
                cbxSearchIn.ValueMember = "DBName";
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }
        string GetDisplayName(string strKeyName)
        {
            try
            {
                return Managers.mngrColumnNames.GetDisplayNameByDBName(strKeyName);
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
                return "Error";
            }
        }
        string GetCondition(string strSearchWay, string strCondition)
        {
            switch (strSearchWay)
            {
                case "الحقل بالكامل":
                    return "'" + strCondition + "'";
                case "أي جزء من الحقل":
                    return "'%" + strCondition.Replace("%", "[%]").Replace("*", "[*]") + "%'";
                case "من أول الحقل":
                    return "'" + strCondition.Replace("%", "[%]").Replace("*", "[*]") + "%'";
                case "آخر الحقل":
                    return "'%" + strCondition.Replace("%", "[%]").Replace("*", "[*]") + "'";
                case "Whole Field":
                    return "'" + strCondition + "'";
                case "Any Part of Field":
                    return "'%" + strCondition.Replace("%", "[%]").Replace("*", "[*]") + "%'";
                case "From the begining of field":
                    return "'" + strCondition.Replace("%", "[%]").Replace("*", "[*]") + "%'";
                case "At the last of the field":
                    return "'%" + strCondition.Replace("%", "[%]").Replace("*", "[*]") + "'";
                default:
                    return "'" + strCondition + "'";
            }
        }
        string GetConditionOperator(string strSearchWay)
        {
            if (strSearchWay == "الحقل بالكامل" || strSearchWay == "Whole Field")
                return " = ";
            else
                return " like ";
        }
        bool ValidateSearch()
        {
            try
            {
                bool Res = true;
                errprvForm.Clear();
                if (tbxSearchFor.Text.Length == 0)
                {
                    errprvForm.SetError(tbxSearchFor, Resources.ProgramMessages.MesEnterField);
                    Res = false;
                }
                if (cbxSearchIn.Text.Length == 0 || cbxSearchIn.SelectedIndex == -1)
                {
                    errprvForm.SetError(cbxSearchIn, Resources.ProgramMessages.MesEnterField);
                    Res = false;
                }
                if (cbxSearchWay.Text.Length == 0 || cbxSearchWay.SelectedIndex == -1)
                {
                    errprvForm.SetError(cbxSearchWay, Resources.ProgramMessages.MesEnterField);
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

        #region Event Handlers

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateSearch())
                {
                    string strCommand = "select * from " + strTableName + " where " + cbxSearchIn.SelectedValue.ToString() +
                        GetConditionOperator(cbxSearchWay.Text) + "("
                        + GetCondition(cbxSearchWay.Text, tbxSearchFor.Text) + ")";
                    //SqlParameter[] prmSearch = new SqlParameter[1];
                    //prmSearch[0] = new SqlParameter("@SearchValue", GetCondition(cbxSearchWay.Text, tbxSearchFor.Text));
                    DataTable tblSearchResult = SqlAdoWrapper.ExecuteQueryCommand(strCommand, null, true);
                    if (tblSearchResult.Rows.Count > 0)
                        dgvSearchRes.DataSource = tblSearchResult;
                    else
                        Helper.ShowMessage(Resources.ProgramMessages.MesNoResultsFound);
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }
        private void tbxSearchFor_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (chkbxInstantSearch.Checked)
                    btnSearch_Click(null, null);
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }
        private void dgvSearchRes_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dgvSearchRes.Columns.Contains("dgvtbxcID") && dgvSearchRes.SelectedRows.Count > 0)
                {
                    if (Helper.CheckNumberInt(dgvSearchRes.SelectedRows[0].Cells["dgvtbxcID"].Value))
                    {
                        iSelectedRowID = Convert.ToInt32(dgvSearchRes.SelectedRows[0].Cells["dgvtbxcID"].Value);
                        if (iSelectedRowID > 0)
                            Close();
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }

        #endregion

    }
}
