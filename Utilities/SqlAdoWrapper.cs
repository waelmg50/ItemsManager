using System;
using System.Data;
using System.Data.SqlClient;

namespace Utilities
{
    /// <summary>
    /// Manage and exectute SQL Commands.
    /// </summary>
    public class SqlAdoWrapper
    {

        #region SQL Commands Functions

        /// <summary>
        /// Execute an sql command that dosen't return any data.
        /// </summary>
        /// <param name="strStoredProcdureName">The name of the stored procedure to execute.</param>
        /// <param name="sqlprmParameters">The Parameter collection of the SQL  command.</param>
        /// <param name="bTextCommand">Determines whether the command is text or Stored procedure.</param>
        /// <returns>Returns -1 if error occured otherwise it returns the number of affected rows in the Database
        /// by this command.</returns>
        public static int ExecuteNonQueryCommand(string strStoredProcdureName,
            SqlParameter[] sqlprmParameters, bool bTextCommand)
        {
            try
            {
                if (DBConnection.Connect())
                {
                    SqlCommand cmdCommand = DBConnection.Connection.CreateCommand();
                    cmdCommand.CommandText = strStoredProcdureName;
                    cmdCommand.CommandType = bTextCommand ? CommandType.Text : CommandType.StoredProcedure;
                    if (sqlprmParameters != null && sqlprmParameters.Length > 0)
                        cmdCommand.Parameters.AddRange(sqlprmParameters);
                    return cmdCommand.ExecuteNonQuery();
                }
                else
                    return -1;
            }
            catch (Exception e)
            {
                ErrorHandler.LogError(e, strStoredProcdureName);
                return -1;
            }
        }
        /// <summary>
        /// Execute an SQL command that returns data.
        /// </summary>
        /// <param name="strStoredProcdureName">The name of the stored procedure to execute.</param>
        /// <param name="sqlprmParameters">The Parameter collection of the SQL  command.</param>
        /// <param name="bTextCommand">Determines whether the command is text or Stored procedure. True = txt command ,False = Stored procedure</param>
        /// <returns>Returns null if error occured otherwise it returns the data table that will carry the returned
        /// data from the command.</returns>
        public static DataTable ExecuteQueryCommand(string strStoredProcdureName,
            SqlParameter[] sqlprmParameters, bool bTextCommand)
        {
            if (DBConnection.Connect())
            {
                SqlCommand cmdSelect = DBConnection.Connection.CreateCommand();
                cmdSelect.CommandType = bTextCommand ? CommandType.Text : CommandType.StoredProcedure;
                cmdSelect.CommandText = strStoredProcdureName;
                if (sqlprmParameters != null && sqlprmParameters.Length > 0)
                    cmdSelect.Parameters.AddRange(sqlprmParameters);
                SqlDataAdapter daSelect = new SqlDataAdapter(cmdSelect);
                DataTable dtResult = new DataTable();
                try
                {
                    if (DBConnection.Connect())
                    {
                        daSelect.Fill(dtResult);
                        return dtResult;
                    }
                    else
                        return null;
                }
                catch (SqlException e)
                {
                    ErrorHandler.LogError(e, strStoredProcdureName);
                    return null;
                }
                catch (Exception e)
                {
                    ErrorHandler.LogError(e, strStoredProcdureName);
                    return null;
                }
                finally
                {
                    if (daSelect != null)
                    {
                        daSelect.Dispose();
                        daSelect = null;
                    }
                    GC.Collect();
                }
            }
            else
                return null;
        }
        /// <summary>
        /// Execute an SQL command that returns data.
        /// </summary>
        /// <param name="strStoredProcdureName">The name of the stored procedure to execute.</param>
        /// <param name="sqlprmParameters">The Parameter collection of the SQL  command.</param>
        /// <param name="trTrans">The transaction that the SQL Command will run in.</param>
        /// <param name="bTextCommand">Determines whether the command is text or Stored procedure.
        /// True = txt command ,False = Stored procedure</param>
        /// <returns>Returns null if error occured otherwise it returns the data table that will carry the returned
        /// data from the command.</returns>
        public static DataTable ExecuteQueryCommand(string strStoredProcdureName,
            SqlParameter[] sqlprmParameters, SqlTransaction trTrans, bool bTextCommand)
        {
            if (DBConnection.Connect())
            {
                SqlCommand cmdSelect = DBConnection.Connection.CreateCommand();
                cmdSelect.CommandType = bTextCommand ? CommandType.Text : CommandType.StoredProcedure;
                cmdSelect.CommandText = strStoredProcdureName;
                if (sqlprmParameters != null && sqlprmParameters.Length > 0)
                    cmdSelect.Parameters.AddRange(sqlprmParameters);
                if (trTrans != null)
                    cmdSelect.Transaction = trTrans;
                SqlDataAdapter daSelect = new SqlDataAdapter(cmdSelect);
                DataTable dtResult = new DataTable();
                try
                {
                    if (DBConnection.Connect())
                    {
                        daSelect.Fill(dtResult);
                        return dtResult;
                    }
                    else
                        return null;
                }
                catch (SqlException e)
                {
                    ErrorHandler.LogError(e, strStoredProcdureName);
                    return null;
                }
                catch (Exception e)
                {
                    ErrorHandler.LogError(e, strStoredProcdureName);
                    return null;
                }
                finally
                {
                    if (daSelect != null)
                    {
                        daSelect.Dispose();
                        daSelect = null;
                    }
                    GC.Collect();
                }
            }
            else
                return null;
        }
        /// <summary>
        /// Execute an SQL command that returns one value only.
        /// </summary>
        /// <param name="cmdCommand">The SQL command that will return the result.</param>
        /// <param name="Result">The value returned from the command.</param>
        /// <param name="bTextCommand">Determines whether the command is text or Stored procedure.</param>
        /// <returns>Returns false if error occured otherwise it returns true.</returns>
        public static object ExecuteScalarCommand(string strStoredProcdureName,
            SqlParameter[] sqlprmParameters, bool bTextCommand)
        {
            try
            {
                if (DBConnection.Connect())
                {
                    SqlCommand cmdCommand = DBConnection.Connection.CreateCommand();
                    cmdCommand.CommandText = strStoredProcdureName;
                    cmdCommand.CommandType = bTextCommand ? CommandType.Text : CommandType.StoredProcedure;
                    if (sqlprmParameters != null && sqlprmParameters.Length > 0)
                        cmdCommand.Parameters.AddRange(sqlprmParameters);
                    return cmdCommand.ExecuteScalar();
                }
                else
                    return null;
            }
            catch (SqlException e)
            {
                ErrorHandler.LogError(e, strStoredProcdureName);
                return null;
            }
            catch (Exception e)
            {
                ErrorHandler.LogError(e, strStoredProcdureName);
                return null;
            }
        }
        /// <summary>
        /// Execute an SQL command that returns one value only.
        /// </summary>
        /// <param name="cmdCommand">The SQL command that will return the result.</param>
        /// <param name="Result">The value returned from the command.</param>
        /// <param name="trTrans">The transaction that the SQL Command will run in.</param>
        /// <param name="bTextCommand">Determines whether the command is text or Stored procedure.</param>
        /// <returns>Returns false if error occured otherwise it returns true.</returns>
        public static object ExecuteScalarCommand(string strStoredProcdureName,
            SqlParameter[] sqlprmParameters, SqlTransaction trTrans, bool bTextCommand)
        {
            try
            {
                if (DBConnection.Connect())
                {
                    SqlCommand cmdCommand = DBConnection.Connection.CreateCommand();
                    cmdCommand.CommandText = strStoredProcdureName;
                    cmdCommand.CommandType = bTextCommand ? CommandType.Text : CommandType.StoredProcedure;
                    if (sqlprmParameters != null && sqlprmParameters.Length > 0)
                        cmdCommand.Parameters.AddRange(sqlprmParameters);
                    if (trTrans != null)
                        cmdCommand.Transaction = trTrans;
                    return cmdCommand.ExecuteScalar();
                }
                else
                    return null;
            }
            catch (SqlException e)
            {
                ErrorHandler.LogError(e, strStoredProcdureName);
                return null;
            }
            catch (Exception e)
            {
                ErrorHandler.LogError(e, strStoredProcdureName);
                return null;
            }
        }
        /// <summary>
        /// Execute an sql command that dosen't return any data.
        /// </summary>
        /// <param name="strStoredProcdureName">The name of the stored procedure to execute.</param>
        /// <param name="sqlprmParameters">The Parameter collection of the SQL  command.</param>
        /// <param name="trTrans">The transaction that the SQL Command will run in.</param>
        /// <param name="bTextCommand">Determines whether the command is text or Stored procedure.</param>
        /// <returns>Returns -1 if error occured otherwise it returns the number of affected rows in the Database
        /// by this command.</returns>
        public static int ExecuteNonQueryCommand(string strStoredProcdureName,
            SqlParameter[] sqlprmParameters, SqlTransaction trTrans, bool bTextCommand)
        {
            try
            {
                if (DBConnection.Connect())
                {
                    SqlCommand cmdCommand = DBConnection.Connection.CreateCommand();
                    cmdCommand.CommandText = strStoredProcdureName;
                    cmdCommand.CommandType = bTextCommand ? CommandType.Text : CommandType.StoredProcedure;
                    if (sqlprmParameters != null && sqlprmParameters.Length > 0)
                        cmdCommand.Parameters.AddRange(sqlprmParameters);
                    if (trTrans != null)
                        cmdCommand.Transaction = trTrans;
                    return cmdCommand.ExecuteNonQuery();
                }
                else
                    return -1;
            }
            catch (Exception e)
            {
                ErrorHandler.LogError(e, strStoredProcdureName);
                return -1;
            }
        }
        /// <summary>
        /// Gets the databases exsit on the server.
        /// </summary>
        /// <param name="bSelectMaster">A value to indicate whether to select the master data base or not.</param>
        /// <param name="bConnectToServer">A value to indicate whether to connect to the server or to the company (true: Server; false: Company).</param>
        /// <returns>Returns a data table that have the database names in it.</returns>
        public static DataTable SelectServerDatabases(bool bSelectMaster)
        {
            try
            {
                DataTable tblDatabases = new DataTable();
                SqlCommand cmdSelectDBs = new SqlCommand();
                if (DBConnection.Connection.State == ConnectionState.Open)
                    cmdSelectDBs = DBConnection.Connection.CreateCommand();
                cmdSelectDBs.CommandType = CommandType.Text;
                string strMaster = string.Empty;
                if (!bSelectMaster)
                    strMaster = "'master', ";
                cmdSelectDBs.CommandText = "select db_name(dbid) as DataBaseName from master.dbo.sysdatabases"
                    + " where has_dbaccess(db_name(dbid)) = 1 and db_name(dbid) not in(" + strMaster + "'tempdb', 'model'"
                    + ",'msdb', 'ReportServer', 'ReportServerTempDB') order by name";
                SqlDataAdapter daDatabases = new SqlDataAdapter();
                daDatabases.SelectCommand = cmdSelectDBs;
                DBConnection.Connect();
                daDatabases.Fill(tblDatabases);
                return tblDatabases;
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
                return null;
            }
        }

        #endregion

        #region Data Table Functions

        /// <summary>
        /// Checks if a set of strings is the names of columns in a data table.
        /// </summary>
        /// <param name="dtCheck">The datatable to check the columns in it.</param>
        /// <param name="Columns">The set of strings to check in the datatable.</param>
        /// <returns>Returns true if all columns names exist in the datatable.</returns>
        public static bool CheckColumns(DataTable dtCheck, string[] Columns)
        {
            if (dtCheck == null) return true;
            foreach (string Column in Columns)
            {
                if (dtCheck.Columns.Contains(Column))
                    continue;
                else
                    return false;
            }
            return true;
        }
        /// <summary>
        /// Filters a datatable by the supplied value and gets the results in a new datatable.
        /// </summary>
        /// <param name="dtWholeChild">The datatable that will be filtered.</param>
        /// <param name="ParentID">The value to filter the table by.</param>
        /// <param name="RelationColumn">The Column that holds the filtering value.</param>
        /// <returns>Returns a datatable that holds the filtered data.</returns>
        public static DataTable GetChildTable(DataTable dtWholeChild, object ParentID, string RelationColumn)
        {
            DataTable dtResult = new DataTable();
            if (ParentID == null) return dtResult;
            foreach (DataColumn dc in dtWholeChild.Columns)
                dtResult.Columns.Add(dc.ColumnName, dc.DataType);

            if (dtWholeChild.Columns.Contains(RelationColumn))
            {
                foreach (DataRow drChild in dtWholeChild.Rows)
                {
                    if (drChild[RelationColumn].ToString() == ParentID.ToString())
                    {
                        dtResult.ImportRow(drChild);
                    }
                }
            }
            else
                return null;
            return dtResult;
        }
        /// <summary>
        /// Checks if the table name exists in the current database or not.
        /// </summary>
        /// <param name="strTableName">The table name to check.</param>
        /// <returns>Returns true if the table name exists in the current database otherwise ot returns false.</returns>
        public static bool CheckTableName(string strTableName)
        {
            try
            {
                SqlParameter[] sqlprm = new SqlParameter[1];
                sqlprm[0] = new SqlParameter("@Name", strTableName);
                object objRes = SqlAdoWrapper.ExecuteScalarCommand("select Count(Name) from sys.Tables where Name =@Name", sqlprm, true);
                return objRes == DBNull.Value ? false : Convert.ToInt32(objRes) > 0;
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
                return false;
            }
        }
        /// <summary>
        /// Get all the Table names in the current database.
        /// </summary>
        /// <returns>Returns a datatable that contains the names of the tables in the current database.</returns>
        public static DataTable GetTableNames()
        {
            return SqlAdoWrapper.ExecuteQueryCommand("select Name from sys.Tables", null, true);
        }
        /// <summary>
        /// Gets the column names of the supplied data table.
        /// </summary>
        /// <param name="strTableName">The data table to get its culumn names.</param>
        /// <param name="bSelectStringColumnsOnly">A value to determine whether to get the string fields only or not.</param>
        /// <returns>Returns a data table that contains the strings of the required columns.</returns>
        public static DataTable GetTableColumnNames(string strTableName, bool bSelectStringColumnsOnly)
        {
            try
            {
                if (!CheckTableName(strTableName))
                    return null;
                SqlParameter[] sqlprm = new SqlParameter[1];
                sqlprm[0] = new SqlParameter("@TableName", strTableName);
                string strCommandtext = "SELECT DISTINCT ColumnsNames.DBName, ColumnsNames.DisplayName FROM sys.types INNER JOIN "
                    + "sys.columns INNER JOIN  sys.tables ON sys.columns.object_id = sys.tables.object_id ON sys.types.system_type_id = "
                    + "sys.columns.system_type_id INNER JOIN ColumnsNames ON sys.columns.name = ColumnsNames.DBName "
                    + "WHERE (sys.types.name <> 'sysname') AND (sys.tables.name = @TableName)";
                if (bSelectStringColumnsOnly)
                    strCommandtext += " and sys.types.name in ('nvarchar','varchar','char','nchar')";
                strCommandtext += " ORDER BY DBName";
                return SqlAdoWrapper.ExecuteQueryCommand(strCommandtext, sqlprm, true);
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
                return null;
            }
        }

        #endregion

    }
}