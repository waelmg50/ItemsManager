using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Utilities;

namespace Managers
{
    public partial class mngrExpenses
    {

        #region Select Methods

        public static DataTable GetView_Expenses(int TypeID, int ShiftID)
        {
            SqlParameter[] sqlparam = new SqlParameter[1];
            sqlparam[0] = new SqlParameter("@TypeID", TypeID);
            sqlparam[1] = new SqlParameter("@ShiftID", ShiftID);
            return SqlAdoWrapper.ExecuteQueryCommand("View_Expenses_SelectByID", sqlparam, false);
        }
        public static DataTable GetView_Expenses1(int ShiftID)
        {
            return SqlAdoWrapper.ExecuteQueryCommand("View_Expenses1", new SqlParameter[] { new SqlParameter("@ShiftID", ShiftID) }, false);
        }
        public static DataTable GetExpencesReport(DateTime dtExpensesFrom, DateTime dtExpensesTo, int iExpenceType, string strStatement, string strRemarks)
        {
            SqlParameter[] sqlprmExpenseReport = new SqlParameter[5];
            sqlprmExpenseReport[0] = new SqlParameter("@ExpenseDateFrom", dtExpensesFrom);
            sqlprmExpenseReport[1] = new SqlParameter("@ExpenseDateTo", dtExpensesTo);
            if (iExpenceType > 0)
                sqlprmExpenseReport[2] = new SqlParameter("@ExpenseTypeID", iExpenceType);
            else
                sqlprmExpenseReport[2] = new SqlParameter("@ExpenseTypeID", DBNull.Value);
            if (string.IsNullOrWhiteSpace(strStatement))
                sqlprmExpenseReport[3] = new SqlParameter("@Statement", strStatement);
            else
                sqlprmExpenseReport[3] = new SqlParameter("@Statement", DBNull.Value);
            if (string.IsNullOrWhiteSpace(strRemarks))
                sqlprmExpenseReport[4] = new SqlParameter("@Remarks", strRemarks);
            else
                sqlprmExpenseReport[4] = new SqlParameter("@Remarks", DBNull.Value);

            return SqlAdoWrapper.ExecuteQueryCommand("Expenses_SelectReport", sqlprmExpenseReport, false);
        }

        #endregion

    }
}
