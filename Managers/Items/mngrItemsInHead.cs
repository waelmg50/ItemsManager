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
    public partial class mngrItemsInHead : BaseManager
    {

        #region Select Functions

        public static DataTable GetItemsInHead()
        {
            return SqlAdoWrapper.ExecuteQueryCommand("ItemsInHead_Select", null, false);
        }

        #endregion

        #region Operation Functions

        public static int Insert(entItemsInHead entSave, SqlTransaction sqltrSaveItemsInHead)
        {
            try
            {
                //Create the parameter collection of the table insert command.
                SqlParameter[] sqlprmComParam = new SqlParameter[6];
                sqlprmComParam[0] = new SqlParameter("@ID", entSave.ID);
                sqlprmComParam[0].Direction = ParameterDirection.Output;

                sqlprmComParam[1] = new SqlParameter("@ShiftID", entSave.ShiftID);
                sqlprmComParam[2] = new SqlParameter("@InDate", entSave.InDate);
                sqlprmComParam[3] = new SqlParameter("@InsertUserID", entSave.InsertUserID);
                sqlprmComParam[4] = new SqlParameter("@SupplierID", entSave.SupplierID);
                sqlprmComParam[5] = UserID;
                int iRes = SqlAdoWrapper.ExecuteNonQueryCommand("ItemsInHead_Insert", sqlprmComParam, sqltrSaveItemsInHead, false);
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
        public static int Update(entItemsInHead entSave, SqlTransaction sqltrSaveItemsInHead)
        {
            try
            {
                //Create the parameter collection of the table Update command.
                SqlParameter[] sqlprmComParam = new SqlParameter[6];
                sqlprmComParam[0] = new SqlParameter("@ID", entSave.ID);

                sqlprmComParam[1] = new SqlParameter("@ShiftID", entSave.ShiftID);
                sqlprmComParam[2] = new SqlParameter("@InDate", entSave.InDate);
                sqlprmComParam[3] = new SqlParameter("@InsertUserID", entSave.InsertUserID);
                sqlprmComParam[4] = new SqlParameter("@SupplierID", entSave.SupplierID);
                sqlprmComParam[5] = UserID;
                int iRes = SqlAdoWrapper.ExecuteNonQueryCommand("ItemsInHead_Update", sqlprmComParam, sqltrSaveItemsInHead, false);
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
                return SqlAdoWrapper.ExecuteNonQueryCommand("ItemsInHead_Delete", new SqlParameter[] { sqlprmID, UserID }, false);
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