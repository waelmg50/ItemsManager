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
    partial class mngrUnits
    {

        #region Select Methods

        public static DataTable GetTypeUnits(int iTypeID)
        {
            try
            {
                return SqlAdoWrapper.ExecuteQueryCommand("Units_SelectByTypeID", new SqlParameter[] { new SqlParameter("@TypeID", iTypeID) },
                    false);
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
                return null;
            }
        }
        public static DataTable GetItemUnits(int iItemID)
        {
            try
            {
                SqlParameter[] sqlprmCmndPrmtrs = new SqlParameter[1];
                sqlprmCmndPrmtrs[0] = new SqlParameter("@ItemID", iItemID);
                return SqlAdoWrapper.ExecuteQueryCommand("Units_SelectByItemID", sqlprmCmndPrmtrs, false);
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
                return null;
            }
        }
        public static DataTable GetItemTypeUnits(int iTypeID, int iItemID)
        {
            try
            {
                SqlParameter[] sqlprmCmndPrmtrs = new SqlParameter[2];
                sqlprmCmndPrmtrs[0] = new SqlParameter("@ItemID", iItemID);
                sqlprmCmndPrmtrs[1] = new SqlParameter("@TypeID", iTypeID);
                return SqlAdoWrapper.ExecuteQueryCommand("Units_SelectByItemIDAndTypeID", sqlprmCmndPrmtrs, false);
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