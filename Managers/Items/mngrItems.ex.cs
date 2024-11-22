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
    partial class mngrItems
    {

        #region Select Functions

        public static DataTable GetItemsByCategoryID(int iCategoryID)
        {
            return SqlAdoWrapper.ExecuteQueryCommand("Items_SelectByCategoryID",
                new SqlParameter[] { new SqlParameter("@CategoryID", iCategoryID) }, false);
        }
        public static DataTable GetItemsByKeyWord(string KeyWord)
        {
            return SqlAdoWrapper.ExecuteQueryCommand("Items_SelectByKeyWord", new SqlParameter[] { new SqlParameter("@KeyWord", KeyWord) }, false);
        }
        public static decimal GetItemUnitPrice(int iItemID, int iUnitID)
        {
            try
            {
                SqlParameter[] sqlprmItemUnit = new SqlParameter[2];
                sqlprmItemUnit[0] = new SqlParameter("@ItemID", iItemID);
                sqlprmItemUnit[1] = new SqlParameter("@UnitID", iUnitID);
                object objItemUnitPrice = SqlAdoWrapper.ExecuteScalarCommand("ItemsUnits_SelectByItemIDAndUnitID",
                    sqlprmItemUnit, false);
                return Helper.CheckNumberDouble(objItemUnitPrice) ? Convert.ToDecimal(objItemUnitPrice) : 0m;
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
                return 0m;
            }
        }
        public static decimal GetItemCurrentQuantity(int iItemID, int iUnitID)
        {
            return GetItemCurrentQuantity(iItemID, iUnitID, null);
        }
        public static decimal GetItemCurrentQuantity(int iItemID, int iUnitID, SqlTransaction sqltrnSave)
        {
            try
            {
                if (iItemID <= 0 || iUnitID <= 0)
                    return 0m;
                SqlParameter[] sqlprmItemStock = new SqlParameter[2];
                sqlprmItemStock[0] = new SqlParameter("@ItemID", iItemID);
                sqlprmItemStock[1] = new SqlParameter("@UnitID", iUnitID);
                object objRes = SqlAdoWrapper.ExecuteScalarCommand("Items_SelectCurrentStock", sqlprmItemStock, sqltrnSave, false);
                return Helper.CheckNumberDouble(objRes) ? Convert.ToDecimal(objRes) : 0m;
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
                return 0;
            }
        }
        #endregion

    }
}
