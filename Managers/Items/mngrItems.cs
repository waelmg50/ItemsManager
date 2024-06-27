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
    public partial class mngrItems : BaseManager
    {

        #region Select Functions

        public static DataTable GetItems()
        {
            return SqlAdoWrapper.ExecuteQueryCommand("Items_Select", null, false);
        }

        #endregion

        #region Operation Functions

        public static int Insert(entItems entSave)
        {
            try
            {
                //Create the parameter collection of the table insert command.
                SqlParameter[] sqlprmComParam = new SqlParameter[7];
                sqlprmComParam[0] = new SqlParameter("@ID", entSave.ID);
                sqlprmComParam[0].Direction = ParameterDirection.Output;

                sqlprmComParam[1] = new SqlParameter("@BarCode", entSave.BarCode);
                sqlprmComParam[2] = new SqlParameter("@Name", entSave.Name);
                sqlprmComParam[3] = new SqlParameter("@Description", entSave.Description);
                sqlprmComParam[4] = new SqlParameter("@CategoryID", entSave.CategoryID);
                sqlprmComParam[5] = new SqlParameter("@EndDemand", 1);
                sqlprmComParam[6] = UserID;
                int iRes = SqlAdoWrapper.ExecuteNonQueryCommand("Items_Insert", sqlprmComParam, false);
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
        public static int Update(entItems entSave)
        {
            try
            {
                //Create the parameter collection of the table Update command.
                SqlParameter[] sqlprmComParam = new SqlParameter[7];
                sqlprmComParam[0] = new SqlParameter("@ID", entSave.ID);

                sqlprmComParam[1] = new SqlParameter("@BarCode", entSave.BarCode);
                sqlprmComParam[2] = new SqlParameter("@Name", entSave.Name);
                sqlprmComParam[3] = new SqlParameter("@Description", entSave.Description);
                sqlprmComParam[4] = new SqlParameter("@CategoryID", entSave.CategoryID);
                sqlprmComParam[5] = new SqlParameter("@EndDemand", 1);
                sqlprmComParam[6] = UserID;
                int iRes = SqlAdoWrapper.ExecuteNonQueryCommand("Items_Update", sqlprmComParam, false);
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
                return SqlAdoWrapper.ExecuteNonQueryCommand("Items_Delete", new SqlParameter[] { sqlprmID, UserID }, false);
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