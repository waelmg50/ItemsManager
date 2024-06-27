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
    public partial class mngrStocktakingDetails
    {

        #region Select Functions

        public static DataTable GetStocktakingDetails(int iStocktakingHeadID)
        {
            return SqlAdoWrapper.ExecuteQueryCommand("StocktakingDetails_SelectByStocktakingHeadID",
                    new SqlParameter[] { new SqlParameter("@StocktakingHeadID", iStocktakingHeadID) }, false);
        }

        #endregion

    }
}