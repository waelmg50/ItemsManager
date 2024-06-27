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
    partial class mngrItemsUnits
    {

        #region Select Functions

        public static DataTable GetItemsUnitsByItemID(int iItemID)
        {
            try
            {
                return SqlAdoWrapper.ExecuteQueryCommand("ItemsUnits_SelectByItemID",
                    new SqlParameter[] { new SqlParameter("@ItemID", iItemID) }, false);
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
