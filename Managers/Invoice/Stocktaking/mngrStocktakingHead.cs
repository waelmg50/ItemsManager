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
    public partial class mngrStocktakingHead : BaseManager
    {

        #region Select Functions

        public static DataTable GetStocktakingHead()
        {
            return SqlAdoWrapper.ExecuteQueryCommand("StocktakingHead_Select", null, false);
        }

        #endregion

        #region Operation Functions

        public static int Insert(entStocktakingHead entSave, SqlTransaction sqltrSaveStocktakingHead)
        {
            try
            {
                //Create the parameter collection of the table insert command.
                SqlParameter[] sqlprmComParam = new SqlParameter[4];
                sqlprmComParam[0] = new SqlParameter("@ID", entSave.ID);
                sqlprmComParam[0].Direction = ParameterDirection.Output;

                sqlprmComParam[1] = new SqlParameter("@StockTakingDate", entSave.StockTakingDate);
                sqlprmComParam[2] = new SqlParameter("@UserID", entSave.UserID);
                sqlprmComParam[3] = new SqlParameter("@ShiftID", entSave.ShiftID);

                // sqlprmComParam[4] = UserID;
                int iRes = SqlAdoWrapper.ExecuteNonQueryCommand("StocktakingHead_Insert", sqlprmComParam, sqltrSaveStocktakingHead, false);
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
        public static int Update(entStocktakingHead entSave, SqlTransaction sqltrSaveStocktakingHead)
        {
            try
            {
                //Create the parameter collection of the table Update command.
                SqlParameter[] sqlprmComParam = new SqlParameter[4];
                sqlprmComParam[0] = new SqlParameter("@ID", entSave.ID);

                sqlprmComParam[1] = new SqlParameter("@StockTakingDate", entSave.StockTakingDate);
                sqlprmComParam[2] = new SqlParameter("@UserID", entSave.UserID);
                sqlprmComParam[3] = new SqlParameter("@ShiftID", entSave.ShiftID);

                //sqlprmComParam[4] = UserID;
                int iRes = SqlAdoWrapper.ExecuteNonQueryCommand("StocktakingHead_Update", sqlprmComParam, sqltrSaveStocktakingHead, false);
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
                return SqlAdoWrapper.ExecuteNonQueryCommand("StocktakingHead_Delete",
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