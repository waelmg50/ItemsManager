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
    public partial class mngrItemsInDetails_StocktakingDetails : BaseManager
    {

        #region Select Functions

        public static DataTable GetItemsInDetails_StocktakingDetails()
        {
            return SqlAdoWrapper.ExecuteQueryCommand("ItemsInDetails_StocktakingDetails_Select", null, false);
        }

        #endregion

        #region Operation Functions

        public static int Insert(entItemsInDetails_StocktakingDetails entSave, SqlTransaction sqltrSaveItemsInDetails_StocktakingDetails)
        {
            try
            {
                //Create the parameter collection of the table insert command.
                SqlParameter[] sqlprmComParam = new SqlParameter[5];
                sqlprmComParam[0] = new SqlParameter("@ID", entSave.ID);
                sqlprmComParam[0].Direction = ParameterDirection.Output;

		sqlprmComParam[1] = new SqlParameter("@ItemInID", entSave.ItemInID);
		sqlprmComParam[2] = new SqlParameter("@StocktakingDetailsID", entSave.StocktakingDetailsID);
		sqlprmComParam[3] = new SqlParameter("@Quantity", entSave.Quantity);

                sqlprmComParam[4] = UserID;
                int iRes = SqlAdoWrapper.ExecuteNonQueryCommand("ItemsInDetails_StocktakingDetails_Insert", sqlprmComParam, sqltrSaveItemsInDetails_StocktakingDetails,false);
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
        public static int Update(entItemsInDetails_StocktakingDetails entSave, SqlTransaction sqltrSaveItemsInDetails_StocktakingDetails)
        {
            try
            {
                //Create the parameter collection of the table Update command.
                SqlParameter[] sqlprmComParam = new SqlParameter[5];
                sqlprmComParam[0] = new SqlParameter("@ID", entSave.ID);

		sqlprmComParam[1] = new SqlParameter("@ItemInID", entSave.ItemInID);
		sqlprmComParam[2] = new SqlParameter("@StocktakingDetailsID", entSave.StocktakingDetailsID);
		sqlprmComParam[3] = new SqlParameter("@Quantity", entSave.Quantity);

                sqlprmComParam[4] = UserID;
                int iRes = SqlAdoWrapper.ExecuteNonQueryCommand("ItemsInDetails_StocktakingDetails_Update", sqlprmComParam, sqltrSaveItemsInDetails_StocktakingDetails, false);
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
        public static int Delete(int iID,SqlTransaction sqltrDeleteItemsInDetails_StocktakingDetails)
        {
            try
            {
                SqlParameter sqlprmID = new SqlParameter("@ID", iID);
                return SqlAdoWrapper.ExecuteNonQueryCommand("ItemsInDetails_StocktakingDetails_Delete",
                    new SqlParameter[] { sqlprmID, UserID },sqltrDeleteItemsInDetails_StocktakingDetails, false);
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