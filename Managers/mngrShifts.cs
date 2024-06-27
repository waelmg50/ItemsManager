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
    public partial class mngrShifts : BaseManager
    {

        #region Select Functions

        public static DataTable GetShifts()
        {
            return SqlAdoWrapper.ExecuteQueryCommand("Shifts_Select", null, false);
        }

        #endregion

        #region Operation Functions

        public static int Insert(entShifts entSave)
        {
            try
            {
                //Create the parameter collection of the table insert command.
                SqlParameter[] sqlprmComParam = new SqlParameter[8];
                sqlprmComParam[0] = new SqlParameter("@ID", entSave.ID);
                sqlprmComParam[0].Direction = ParameterDirection.Output;

                sqlprmComParam[1] = new SqlParameter("@DateIn", entSave.DateIn);
                if (entSave.DateOut == DateTime.MinValue)
                    sqlprmComParam[2] = new SqlParameter("@DateOut", DBNull.Value);
                else
                    sqlprmComParam[2] = new SqlParameter("@DateOut", entSave.DateOut);
                sqlprmComParam[3] = new SqlParameter("@UserInID", entSave.UserInID);
                if (entSave.UserOutID == 0)
                    sqlprmComParam[4] = new SqlParameter("@UserOutID", DBNull.Value);
                else
                    sqlprmComParam[4] = new SqlParameter("@UserOutID", entSave.UserOutID);
                sqlprmComParam[5] = new SqlParameter("@CashIn", entSave.CashIn);
                if (entSave.CashOut == 0)
                    sqlprmComParam[6] = new SqlParameter("@CashOut", DBNull.Value);
                else
                    sqlprmComParam[6] = new SqlParameter("@CashOut", entSave.CashOut);

                sqlprmComParam[7] = UserID;
                int iRes = SqlAdoWrapper.ExecuteNonQueryCommand("Shifts_Insert", sqlprmComParam, false);
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
        public static int Update(entShifts entSave)
        {
            try
            {
                //Create the parameter collection of the table Update command.
                SqlParameter[] sqlprmComParam = new SqlParameter[8];
                sqlprmComParam[0] = new SqlParameter("@ID", entSave.ID);

                sqlprmComParam[1] = new SqlParameter("@DateIn", entSave.DateIn);
                if (entSave.DateOut == DateTime.MinValue)
                    sqlprmComParam[2] = new SqlParameter("@DateOut", DBNull.Value);
                else
                    sqlprmComParam[2] = new SqlParameter("@DateOut", entSave.DateOut);
                sqlprmComParam[3] = new SqlParameter("@UserInID", entSave.UserInID);
                if (entSave.UserOutID == 0)
                    sqlprmComParam[4] = new SqlParameter("@UserOutID", DBNull.Value);
                else
                    sqlprmComParam[4] = new SqlParameter("@UserOutID", entSave.UserOutID);
                sqlprmComParam[5] = new SqlParameter("@CashIn", entSave.CashIn);
                if (entSave.CashOut == 0)
                    sqlprmComParam[6] = new SqlParameter("@CashOut", DBNull.Value);
                else
                    sqlprmComParam[6] = new SqlParameter("@CashOut", entSave.CashOut);

                sqlprmComParam[7] = UserID;
                int iRes = SqlAdoWrapper.ExecuteNonQueryCommand("Shifts_Update", sqlprmComParam, false);
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
                return SqlAdoWrapper.ExecuteNonQueryCommand("Shifts_Delete",
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