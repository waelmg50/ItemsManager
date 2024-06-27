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
    public partial class mngrItemsInDetails_StocktakingDetails : BaseManager
    {

        #region Operation Methods

        public static int DeleteAllStocktakingDetails(int iStocktakindgDetailID, SqlTransaction sqltrSave)
        {
            try
            {
                SqlParameter sqlprmID = new SqlParameter("@StocktakingDetailID", iStocktakindgDetailID);
                return SqlAdoWrapper.ExecuteNonQueryCommand("ItemsInDetails_StocktakindgDetails_DeleteAllStocktakindgDetails",
                    new SqlParameter[] { sqlprmID, UserID }, sqltrSave, false);
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
                return -1;
            }
        }

        #endregion


    }
}