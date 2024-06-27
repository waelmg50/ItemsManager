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
    public partial class mngrItemsInDetails
    {

        #region Select Functions

        public static DataTable GetItemsInDetails(int iItemInHeadID)
        {
            try
            {
                return SqlAdoWrapper.ExecuteQueryCommand("ItemsInDetails_SelectByItemInHeadID",
                    new SqlParameter[] { new SqlParameter("@ItemsInHeadID", iItemInHeadID) }, false);
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
                return null;
            }
        }
        public static DataTable GetItemsInUnfinished(int iItemID)
        {
            try
            {
                return SqlAdoWrapper.ExecuteQueryCommand("ItemsInDetails_SelectUnfinished",
                    new SqlParameter[] { new SqlParameter("@ItemID", iItemID) }, false);
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
                return null;
            }
        }
        public static DataTable GetItemsInOldestUnfinished(int iItemID)
        {
            try
            {
                return SqlAdoWrapper.ExecuteQueryCommand("ItemsInDetails_SelectOldestUnfinished",
                    new SqlParameter[] { new SqlParameter("@ItemID", iItemID) }, false);
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
                return null;
            }
        }
        public static DataTable GetItemsInOldestUnfinished(int iItemID, SqlTransaction sqltrnSave)
        {
            try
            {
                return SqlAdoWrapper.ExecuteQueryCommand("ItemsInDetails_SelectOldestUnfinished",
                    new SqlParameter[] { new SqlParameter("@ItemID", iItemID) }, sqltrnSave, false);
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
