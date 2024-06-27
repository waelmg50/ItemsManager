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
    partial class mngrItemsUnitsConversions
    {

        #region Select Functions

        public static DataTable GetItemsUnitsConversionsByItemID(int iItemID)
        {
            try
            {
                return SqlAdoWrapper.ExecuteQueryCommand("ItemsUnitsConversions_SelectByItemID",
                    new SqlParameter[] { new SqlParameter("@ItemID", iItemID) }, false);
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
                return null;
            }
        }
        public static decimal GetUnitsRelation(int iFromUnitID, int iToUnitID, int iItemID, SqlTransaction sqltrnSave)
        {
            try
            {
                if (iFromUnitID == iToUnitID)
                    return 1m;
                entUnits entUnt = new entUnits(iFromUnitID, sqltrnSave);
                if (entUnt.TypeID != 2)
                    return mngrUnitsConversions.GetUnitsRelation(iFromUnitID, iToUnitID, iItemID, sqltrnSave);
                else
                {
                    SqlParameter[] sqlprmConv = new SqlParameter[3];
                    sqlprmConv[0] = new SqlParameter("@FromUnitID", iFromUnitID);
                    sqlprmConv[1] = new SqlParameter("@ToUnitID", iToUnitID);
                    sqlprmConv[2] = new SqlParameter("@ItemID", iItemID);
                    object objRes = SqlAdoWrapper.ExecuteScalarCommand("ItemsUnitsConversions_SelectUnitsConversion", sqlprmConv, sqltrnSave, false);
                    return Helper.CheckNumberDouble(objRes) ? Convert.ToDecimal(objRes) : 0m;
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
                return 0m;
            }
        }

        #endregion

    }
}
