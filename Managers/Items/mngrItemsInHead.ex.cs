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
    partial class mngrItemsInHead
    {

        #region Select Functions

        public static bool IsItemInValidToDelete(int iItemsInID)
        {
            try
            {
                object objRes = SqlAdoWrapper.ExecuteScalarCommand("ItemsInHead_SelectIsValidToDelete",
                   new SqlParameter[] { new SqlParameter("@ItemsInID", iItemsInID) }, false);
               return Helper.CheckNumberInt(objRes) ? Convert.ToBoolean(objRes) : true;
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
                return true;
            }
        }
        public static DataTable GetItemsInReport(DateTime dtItemsInDateFrom, DateTime dtItemsInDateTo, int iItemsInIDFrom, int iItemsInIDTo,
            int iSupplierTypeID, int iSupplierID, bool bWithDetails)
        {
            SqlParameter[] sqlprmItemsInReport = new SqlParameter[6];
            sqlprmItemsInReport[0] = new SqlParameter("@ItemsInDateFrom", dtItemsInDateFrom);
            sqlprmItemsInReport[1] = new SqlParameter("@ItemsInDateTo", dtItemsInDateTo);
            if (iItemsInIDFrom > 0)
                sqlprmItemsInReport[2] = new SqlParameter("@ItemsInIDFrom", iItemsInIDFrom);
            else
                sqlprmItemsInReport[2] = new SqlParameter("@ItemsInIDFrom", DBNull.Value);
            if (iItemsInIDTo > 0)
                sqlprmItemsInReport[3] = new SqlParameter("@ItemsInIDTo", iItemsInIDTo);
            else
                sqlprmItemsInReport[3] = new SqlParameter("@ItemsInIDTo", DBNull.Value);
            if (iSupplierTypeID > 0)
                sqlprmItemsInReport[4] = new SqlParameter("@SupplierTypeID", iSupplierTypeID);
            else
                sqlprmItemsInReport[4] = new SqlParameter("@SupplierTypeID", DBNull.Value);
            if (iSupplierID > 0)
                sqlprmItemsInReport[5] = new SqlParameter("@SupplierID", iSupplierID);
            else
                sqlprmItemsInReport[5] = new SqlParameter("@SupplierID", DBNull.Value);
            string strProcedureName = "ItemsIn_SelectReport";
            if (bWithDetails)
                strProcedureName = "ItemsInWithDetails_SelectReport";
            return SqlAdoWrapper.ExecuteQueryCommand(strProcedureName, sqlprmItemsInReport, false);
        }

        #endregion

    }
}
