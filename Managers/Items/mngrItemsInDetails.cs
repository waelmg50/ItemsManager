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
    public partial class mngrItemsInDetails : BaseManager
    {

        #region Select Functions

        public static DataTable GetItemsInDetails()
        {
            return SqlAdoWrapper.ExecuteQueryCommand("ItemsInDetails_Select", null, false);
        }

        #endregion

        #region Operation Functions

        public static int Insert(entItemsInDetails entSave, SqlTransaction sqltrSaveItemsInDetails)
        {
            try
            {
                //Create the parameter collection of the table insert command.
                SqlParameter[] sqlprmComParam = new SqlParameter[7];
                sqlprmComParam[0] = new SqlParameter("@ID", entSave.ID);
                sqlprmComParam[0].Direction = ParameterDirection.Output;

                sqlprmComParam[1] = new SqlParameter("@ItemID", entSave.ItemID);
                sqlprmComParam[2] = new SqlParameter("@Quantity", entSave.Quantity);
                sqlprmComParam[3] = new SqlParameter("@UnitID", entSave.UnitID);
                sqlprmComParam[4] = new SqlParameter("@ItemsInHeadID", entSave.ItemsInHeadID);
                sqlprmComParam[5] = new SqlParameter("@PurchasePrice", entSave.PurchasePrice);

                sqlprmComParam[6] = UserID;
                int iRes = SqlAdoWrapper.ExecuteNonQueryCommand("ItemsInDetails_Insert", sqlprmComParam, sqltrSaveItemsInDetails, false);
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
        public static int Update(entItemsInDetails entSave, SqlTransaction sqltrSaveItemsInDetails)
        {
            try
            {
                //Create the parameter collection of the table Update command.
                SqlParameter[] sqlprmComParam = new SqlParameter[7];
                sqlprmComParam[0] = new SqlParameter("@ID", entSave.ID);
                sqlprmComParam[1] = new SqlParameter("@ItemID", entSave.ItemID);
                sqlprmComParam[2] = new SqlParameter("@Quantity", entSave.Quantity);
                sqlprmComParam[3] = new SqlParameter("@UnitID", entSave.UnitID);
                sqlprmComParam[4] = new SqlParameter("@ItemsInHeadID", entSave.ItemsInHeadID);
                sqlprmComParam[5] = new SqlParameter("@PurchasePrice", entSave.PurchasePrice);

                sqlprmComParam[6] = UserID;
                int iRes = SqlAdoWrapper.ExecuteNonQueryCommand("ItemsInDetails_Update", sqlprmComParam, sqltrSaveItemsInDetails, false);
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
        public static int Delete(int iID,SqlTransaction sqltrDeleteItemsInDetails)
        {
            try
            {
                SqlParameter sqlprmID = new SqlParameter("@ID", iID);
                return SqlAdoWrapper.ExecuteNonQueryCommand("ItemsInDetails_Delete",
                    new SqlParameter[] { sqlprmID, UserID },sqltrDeleteItemsInDetails, false);
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