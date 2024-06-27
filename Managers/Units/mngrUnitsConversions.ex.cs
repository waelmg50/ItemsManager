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
    public partial class mngrUnitsConversions
    {

        #region Select Methods

        public static DataTable GetNonNumericUnits()
        {
            try
            {
                return SqlAdoWrapper.ExecuteQueryCommand("Units_SelectNonNumeric", null, false);
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
                return null;
            }
        }
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
        public static decimal GetUnitsRelation(int iFromUnitID, int iToUnitID, int iItemID, SqlTransaction sqltrnSave)
        {
            try
            {
                if(iFromUnitID == iToUnitID)
                    return 1m;
                entUnits entUnt = new entUnits(iFromUnitID, sqltrnSave);
                if (entUnt.TypeID == 2)
                    return mngrItemsUnitsConversions.GetUnitsRelation(iFromUnitID, iToUnitID, iItemID, sqltrnSave);
                else
                {
                    SqlParameter[] sqlprmConv = new SqlParameter[2];
                    sqlprmConv[0] = new SqlParameter("@FromUnitID", iFromUnitID);
                    sqlprmConv[1] = new SqlParameter("@ToUnitID", iToUnitID);
                    object objRes = SqlAdoWrapper.ExecuteScalarCommand("UnitsConversions_SelectUnitsConversion", sqlprmConv, sqltrnSave, false);
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