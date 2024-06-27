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
    partial class mngrStocktakingHead
    {

        #region Select Functions

        public static DataTable GetEmptyStocktaking()
        {
            return SqlAdoWrapper.ExecuteQueryCommand("StocktakingHead_SelectExistingQuantities", null, false);
        }

        #endregion

    }
}
