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

        #endregion

    }
}
