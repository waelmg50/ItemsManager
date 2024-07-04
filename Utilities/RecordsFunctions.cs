using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using Utilities;

namespace Utilities
{
    public class RecordsFunctions
    {

        #region Members
        object query = "";
        #endregion

        #region Navegations

        /// <summary>
        /// Te navigation directions of the record sets.
        /// </summary>
        public enum Navegations
        {
            Next = 0,
            Previous = 1,
            First = 2,
            Last = 3
        }
        /// <summary>
        /// Navigate to the subsequent record of the supplied record id in the supplied table according to the supplied navigation.
        /// </summary>
        /// <param name="Navigate_">The navigation method to get the subsequent record.</param>
        /// <param name="TableName">The name of the table that contains the record set.</param>
        /// <param name="iCurrentID">The record id to get its subsequent record id.</param>
        /// <param name="Condition">The condition to filter the record set of the supplied table.</param>
        /// <returns>Returns the subsequent ID of the supplied record ID.</returns>
        public static int Navigate(Navegations Navigate_, string TableName, int iCurrentID, string Condition)
        {
            try
            {
                SqlParameter[] sqlGenerateParmaters = new SqlParameter[5];
                sqlGenerateParmaters[0] = new SqlParameter("@TableName", TableName);
                sqlGenerateParmaters[1] = new SqlParameter("@CoumnName", "ID");
                sqlGenerateParmaters[3] = new SqlParameter("@IDs", iCurrentID);

                switch (Navigate_)
                {
                    case Navegations.Next:
                        sqlGenerateParmaters[2] = new SqlParameter("@NavegationType", "Next");
                        break;
                    case Navegations.Previous:
                        sqlGenerateParmaters[2] = new SqlParameter("@NavegationType", "Previous");
                        break;
                    case Navegations.First:
                        sqlGenerateParmaters[2] = new SqlParameter("@NavegationType", "First");
                        break;
                    case Navegations.Last:
                        sqlGenerateParmaters[2] = new SqlParameter("@NavegationType", "Last");
                        break;
                }

                if (Condition != string.Empty)
                    sqlGenerateParmaters[4] = new SqlParameter("@Condition", Condition);
                else
                    sqlGenerateParmaters[4] = new SqlParameter("@Condition", DBNull.Value);

                object MyReturnedValue = SqlAdoWrapper.ExecuteScalarCommand("Lib_Navegate", sqlGenerateParmaters, false);

                if (MyReturnedValue != null)
                {
                    if (Helper.CheckNumberInt(MyReturnedValue))
                    {
                        if (Convert.ToInt32(MyReturnedValue) == 0)
                        {
                            switch (Navigate_)
                            {
                                case Navegations.Last:
                                    Helper.ShowMessage(Resources.ProgramMessages.MsgLastRecord, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    break;
                                case Navegations.Next:
                                    Helper.ShowMessage(Resources.ProgramMessages.MsgFirtsRecord, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    break;
                                case Navegations.First:
                                    Helper.ShowMessage(Resources.ProgramMessages.MsgFirtsRecord, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    break;
                                case Navegations.Previous:
                                    Helper.ShowMessage(Resources.ProgramMessages.MsgLastRecord, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    break;
                            }
                        }
                        else if (Helper.CheckNumberInt(MyReturnedValue))
                            return Convert.ToInt32(MyReturnedValue);
                    }
                }
                else
                {
                    return 0;
                }
                return 0;
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
                return 0;
            }

        }

        #endregion

        #region AutoComplete

        /// <summary>
        /// Perform AutoComplete For Control
        /// </summary>
        /// <param name="TableName"> The Table From Which we Get Data </param>
        /// <param name="ColumnName"></param>
        /// <param name="FormControl">TextBox or ComboBox</param>
        public static void AutoComplete(string TableName, string ColumnName, TextBox txtAutoComplete)
        {
            try
            {
                txtAutoComplete.AutoCompleteCustomSource.Clear();
                txtAutoComplete.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtAutoComplete.AutoCompleteSource = AutoCompleteSource.CustomSource;
                SqlParameter[] sqlGenerateParmaters = new SqlParameter[2];
                sqlGenerateParmaters[0] = new SqlParameter("@TableName", TableName);
                sqlGenerateParmaters[1] = new SqlParameter("@ColumnName", ColumnName);
                DataTable AutoCompleteDataSource
                    = SqlAdoWrapper.ExecuteQueryCommand("Lib_AutoComplete", sqlGenerateParmaters, false);
                foreach (DataRow drow in AutoCompleteDataSource.Rows)
                    txtAutoComplete.AutoCompleteCustomSource.Add(drow[ColumnName].ToString());
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }

        #endregion

        #region PublicVariables

        /// <summary>
        /// The code of the selected record in the auto complete process.
        /// </summary>
        public static string SelectedCode;
        /// <summary>
        /// The string filed of the selected record in the auto complete process. 
        /// </summary>
        public static string SelectedName;
        /// <summary>
        ///  The ID of the selected record in the auto complete process.
        /// </summary>
        public static int SelectedID;

        #endregion

        #region Common Functions

        /// <summary>
        /// Get ID based on Name
        /// </summary>
        /// <param name="TableName">TableName</param>
        /// <param name="ColumnName">NameAr</param>
        /// <param name="Name">ID</param>
        /// <returns></returns>
        public static int GetIDUsingName(string TableName, string ColumnName, string Name)
        {
            try
            {
                return GetIDUsingName(TableName, ColumnName, Name, null);
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
                return 0;
            }
        }
        /// <summary>
        /// Get ID based on Name
        /// </summary>
        /// <param name="TableName">TableName</param>
        /// <param name="ColumnName">NameAr</param>
        /// <param name="Name">ID</param>
        /// <param name="sqltran">A transaction for consequent commands.</param>
        /// <returns></returns>
        public static int GetIDUsingName(string TableName, string ColumnName, string Name, SqlTransaction sqltran)
        {
            try
            {
                SqlParameter[] sqlGenerateParmaters = new SqlParameter[3];
                sqlGenerateParmaters[0] = new SqlParameter("@TableName", TableName);
                sqlGenerateParmaters[1] = new SqlParameter("@Name_column", ColumnName);
                sqlGenerateParmaters[2] = new SqlParameter("@Name_Value", Name);
                object MyReturnedValue = SqlAdoWrapper.ExecuteScalarCommand("Lib_GetIDUsingName", sqlGenerateParmaters, sqltran, false);
                if (MyReturnedValue == null)
                    return 0;
                else
                    if (Helper.CheckNumberInt(MyReturnedValue))
                    return (Convert.ToInt32(MyReturnedValue));
                else
                    return 0;
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
                return 0;
            }
        }
        /// <summary>
        /// Get The Name Value Using ID 
        /// </summary>
        /// <param name="TableName">TableName</param>
        /// <param name="ColumnName">ColumnName</param>
        /// <param name="ID">ID</param>
        /// <returns></returns>
        public static string GetNameUsingID(string TableName, string ColumnName, int ID)
        {
            try
            {
                return GetNameUsingID(TableName, ColumnName, ID, null);
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
                return string.Empty;
            }
        }
        /// <summary>
        /// Get The Name Value Using ID 
        /// </summary>
        /// <param name="TableName">TableName</param>
        /// <param name="ColumnName">ColumnName</param>
        /// <param name="ID">ID</param>
        /// <returns></returns>
        public static string GetNameUsingID(string TableName, string ColumnName, int ID, SqlTransaction sqltrnSave)
        {
            try
            {
                SqlParameter[] sqlGenerateParmaters = new SqlParameter[3];
                sqlGenerateParmaters[0] = new SqlParameter("@TableName", TableName);
                sqlGenerateParmaters[1] = new SqlParameter("@Name_column", ColumnName);
                sqlGenerateParmaters[2] = new SqlParameter("@ID_Value", ID);
                object MyReturnedValue = SqlAdoWrapper.ExecuteScalarCommand("Lib_GetNameUsingID", sqlGenerateParmaters, sqltrnSave, false);
                if (MyReturnedValue == null)
                    return string.Empty;
                else
                    return MyReturnedValue.ToString();
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
                return string.Empty;
            }
        }
        /// <summary>
        /// Check If Value is Entered IN Database Field Before
        /// </summary>
        /// <param name="tblName"> Table Name</param>
        /// <param name="columnName"> Column Name</param>
        /// <param name="value">Value to check</param>
        /// <param name="ID"> Crrnt.ID </param>
        /// <returns></returns>
        public static bool IsDataExists(string tblName, string columnName, string value, int ID)
        {
            try
            {
                return IsDataExists(tblName, columnName, value, ID, null);
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
                return false;
            }
        }
        /// <summary>
        /// Check If Value is Entered IN Database Field Before
        /// </summary>
        /// <param name="tblName"> Table Name</param>
        /// <param name="columnName"> Column Name</param>
        /// <param name="value">Value to check</param>
        /// <param name="ID"> Crrnt.ID </param>
        /// <returns></returns>
        public static bool IsDataExists(string tblName, string columnName, string value, int ID, string Condition)
        {
            try
            {
                if (value != null && value.Length == 0)
                    return false;
                //Create the parameter collection of the table insert command.
                SqlParameter[] sqlprmComParam = new SqlParameter[5];
                sqlprmComParam[0] = new SqlParameter("@TableName", tblName);
                if (string.IsNullOrWhiteSpace(columnName))
                    sqlprmComParam[1] = new SqlParameter("@ColumnName", DBNull.Value);
                else
                    sqlprmComParam[1] = new SqlParameter("@ColumnName", columnName);
                if (string.IsNullOrWhiteSpace(value))
                    sqlprmComParam[2] = new SqlParameter("@Value", DBNull.Value);
                else
                    sqlprmComParam[2] = new SqlParameter("@Value", value);
                if (ID <= 0)
                    sqlprmComParam[3] = new SqlParameter("@ID", DBNull.Value);
                else
                    sqlprmComParam[3] = new SqlParameter("@ID", ID);
                if (Condition == null)
                    sqlprmComParam[4] = new SqlParameter("@Condition", DBNull.Value);
                else
                    sqlprmComParam[4] = new SqlParameter("@Condition", Condition);
                object objRes = SqlAdoWrapper.ExecuteScalarCommand("Lib_IsDataExists", sqlprmComParam, false);
                return objRes != null && objRes != DBNull.Value && Convert.ToBoolean(objRes);
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
                return false;
            }
        }

        #endregion

        #region Filter Data Table


        public static DataTable FilltblFilterd(DataTable OrginalDataTable, string Condition)
        {
            try
            {
                DataRow[] MyDrow = OrginalDataTable.Select(Condition);
                DataTable mytbl = new DataTable();
                foreach (DataColumn dcRes in OrginalDataTable.Columns)
                    mytbl.Columns.Add(dcRes.ColumnName, dcRes.DataType);
                for (int i = 0; i < MyDrow.Length; i++)
                    mytbl.ImportRow(MyDrow[i]);
                return mytbl;
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);

                return OrginalDataTable;
            }
        }

        #endregion

    }
}