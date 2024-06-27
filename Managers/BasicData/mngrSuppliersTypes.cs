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
    public class mngrSuppliersTypes : BaseManager
    {

        #region Select Functions

        public static DataTable GetSuppliersTypes()
        {
            return SqlAdoWrapper.ExecuteQueryCommand("SuppliersTypes_Select", null, false);
        }

        #endregion

        #region Operation Functions

        public static int Insert(entSuppliersTypes entSave)
        {
            try
            {
                //Create the parameter collection of the table insert command.
                SqlParameter[] sqlprmComParam = new SqlParameter[3];
                sqlprmComParam[0] = new SqlParameter("@ID", entSave.ID);
                sqlprmComParam[0].Direction = ParameterDirection.Output;

		sqlprmComParam[1] = new SqlParameter("@Name", entSave.Name);

                sqlprmComParam[2] = UserID;
                int iRes = SqlAdoWrapper.ExecuteNonQueryCommand("SuppliersTypes_Insert", sqlprmComParam,false);
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
        public static int Update(entSuppliersTypes entSave)
        {
            try
            {
                //Create the parameter collection of the table Update command.
                SqlParameter[] sqlprmComParam = new SqlParameter[3];
                sqlprmComParam[0] = new SqlParameter("@ID", entSave.ID);

		sqlprmComParam[1] = new SqlParameter("@Name", entSave.Name);

                sqlprmComParam[2] = UserID;
                int iRes = SqlAdoWrapper.ExecuteNonQueryCommand("SuppliersTypes_Update", sqlprmComParam, false);
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
                return SqlAdoWrapper.ExecuteNonQueryCommand("SuppliersTypes_Delete",
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