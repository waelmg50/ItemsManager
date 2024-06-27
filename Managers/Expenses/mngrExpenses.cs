using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Utilities;
using Entities;

namespace Managers
{
    public partial class mngrExpenses : BaseManager
    {

        #region Select Functions

        public static DataTable GetExpenses()
        {
            return SqlAdoWrapper.ExecuteQueryCommand("Expenses_Select", null, false);
        }

        #endregion

        #region Operation Functions

        public static int Insert(entExpenses entSave)
        {
            try
            {
                //Create the parameter collection of the table insert command.
                SqlParameter[] sqlprmComParam = new SqlParameter[8];
                sqlprmComParam[0] = new SqlParameter("@ID", entSave.ID);
                sqlprmComParam[0].Direction = ParameterDirection.Output;

                sqlprmComParam[1] = new SqlParameter("@TypeID", entSave.TypeID);
                if (entSave.Statement == string.Empty)
                    sqlprmComParam[2] = new SqlParameter("@Statement", DBNull.Value);
                else
                    sqlprmComParam[2] = new SqlParameter("@Statement", entSave.Statement);
                sqlprmComParam[3] = new SqlParameter("@Value", entSave.Value);
                if (entSave.Remarks == string.Empty)
                    sqlprmComParam[4] = new SqlParameter("@Remarks", DBNull.Value);
                else
                    sqlprmComParam[4] = new SqlParameter("@Remarks", entSave.Remarks);
                sqlprmComParam[5] = new SqlParameter("@ShiftID", entSave.ShiftID);

                sqlprmComParam[6] = UserID;
                sqlprmComParam[7] = new SqlParameter("@ExpDate", DateTime.Now);
                int iRes = SqlAdoWrapper.ExecuteNonQueryCommand("Expenses_Insert", sqlprmComParam, false);
                if (iRes > 0 && sqlprmComParam[0].Value != null && sqlprmComParam[0].Value != DBNull.Value)
                    return Convert.ToInt32(sqlprmComParam[0].Value);
                return -1;
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
                return -1;
            }
        }
        public static int Update(entExpenses entSave)
        {
            try
            {
                //Create the parameter collection of the table Update command.
                SqlParameter[] sqlprmComParam = new SqlParameter[8];
                sqlprmComParam[0] = new SqlParameter("@ID", entSave.ID);

                sqlprmComParam[1] = new SqlParameter("@TypeID", entSave.TypeID);
                if (entSave.Statement == string.Empty)
                    sqlprmComParam[2] = new SqlParameter("@Statement", DBNull.Value);
                else
                    sqlprmComParam[2] = new SqlParameter("@Statement", entSave.Statement);
                sqlprmComParam[3] = new SqlParameter("@Value", entSave.Value);
                if (entSave.Remarks == string.Empty)
                    sqlprmComParam[4] = new SqlParameter("@Remarks", DBNull.Value);
                else
                    sqlprmComParam[4] = new SqlParameter("@Remarks", entSave.Remarks);
                sqlprmComParam[5] = new SqlParameter("@ShiftID", entSave.ShiftID);

                sqlprmComParam[6] = UserID;
                sqlprmComParam[7] = new SqlParameter("@ExpDate", DateTime.Now);
                int iRes = SqlAdoWrapper.ExecuteNonQueryCommand("Expenses_Update", sqlprmComParam, false);
                if (iRes > 0)
                    return iRes;
                return -1;
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
                return -1;
            }
        }
        public static int Delete(int iID)
        {
            try
            {
                SqlParameter sqlprmID = new SqlParameter("@ID", iID);
                return SqlAdoWrapper.ExecuteNonQueryCommand("Expenses_Delete",
                    new SqlParameter[] { sqlprmID, UserID }, false);
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
                return -1;
            }
        }

        #endregion

    }
}