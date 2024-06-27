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
    partial class mngrItemsCategories
    {

        #region Select Methods

        public static DataTable GetItemsCategoriesHaveItems()
        {
            try
            {
                return SqlAdoWrapper.ExecuteQueryCommand("ItemsCategories_SelectHaveItems", null, false);
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
                return null;
            }
        }
        public static DataTable GetItemsCategoriesHaveNumericItems()
        {
            try
            {
                return SqlAdoWrapper.ExecuteQueryCommand("ItemsCategories_SelectHaveNumericItems", null, false);
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
