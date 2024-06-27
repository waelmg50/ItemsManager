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
    public partial class mngrShifts
    {

        #region Select Functions

        public static int GetCurrentShiftID()
        {
            try
            {
                object objRes = SqlAdoWrapper.ExecuteScalarCommand("Shifts_SelectUnFinishedID", null, false);
                return Helper.CheckNumberInt(objRes) ? Convert.ToInt32(objRes) : 0;
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
                return -1;
            }
        }
        public static DataTable GetShiftExpenses(int iShiftID)
        {
            try
            {
                return SqlAdoWrapper.ExecuteQueryCommand("Expenses_SelectByShiftID", new SqlParameter[] {new SqlParameter("@ShiftID",
                    iShiftID)}, false);
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
                return null;
            }
        }
        public static DataTable GetShiftInvoices(int iShiftID)
        {
            try
            {
                return SqlAdoWrapper.ExecuteQueryCommand("InvoiceHead_SelectByShiftID", new SqlParameter[] {new SqlParameter("@ShiftID",
                    iShiftID)}, false);
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
                return null;
            }
        }
        public static DataTable GetShiftItemsIn(int iShiftID)
        {
            try
            {
                return SqlAdoWrapper.ExecuteQueryCommand("ItemsInHead_SelectByShiftID", new SqlParameter[] {new SqlParameter("@ShiftID",
                    iShiftID)}, false);
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
                return null;
            }
        }
        public static DataTable GetShiftStocktaking(int iShiftID)
        {
            try
            {
                return SqlAdoWrapper.ExecuteQueryCommand("StocktakingHead_SelectByShiftID", new SqlParameter[] {new SqlParameter("@ShiftID",
                    iShiftID)}, false);
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
                return null;
            }
        }
        public static DataTable GetShiftWithExternalData(int iShiftID)
        {
            try
            {
                return SqlAdoWrapper.ExecuteQueryCommand("vwShiftsData_SelectByShiftID", new SqlParameter[] {new SqlParameter("@ShiftID",
                    iShiftID)}, false);
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
