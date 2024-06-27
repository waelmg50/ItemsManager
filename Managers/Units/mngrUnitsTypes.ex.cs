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
    public partial class mngrUnitsTypes
    {

        #region Select Functions

        public static DataTable GetUnitsTypesHaveUnits()
        {
            try
            {
                return SqlAdoWrapper.ExecuteQueryCommand("UnitsTypes_SelectHaveUnits", null, false);
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
                return null;
            }
        }
        public static DataTable GetUnitsTypesHaveItemUnits(int iItemID)
        {
            try
            {
                return SqlAdoWrapper.ExecuteQueryCommand("UnitsTypes_SelectHaveItemUnits", new SqlParameter[] { new SqlParameter("@ItemID",
                    iItemID)}, false);
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