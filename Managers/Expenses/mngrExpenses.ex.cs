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

        public static DataTable GetView_Expenses(int TypeID)
        {
            SqlParameter[] sqlparam = new SqlParameter[1];
            sqlparam[0] = new SqlParameter("@TypeID", TypeID);
            return SqlAdoWrapper.ExecuteQueryCommand("View_Expenses_SelectByID", sqlparam, false);
        }
        public static DataTable GetView_Expenses1()
        {
            return SqlAdoWrapper.ExecuteQueryCommand("View_Expenses1", null, false);
        }

        #endregion

    }
}
