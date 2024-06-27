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
    partial class mngrItemsInDetails_InvoiceDetails
    {

        #region Operation Methods

        public static int DeleteAllInvoiceDtailse(int iInvoiceDetailID, SqlTransaction sqltrSave)
        {
            try
            {
                SqlParameter sqlprmID = new SqlParameter("@InvoiceDetailID", iInvoiceDetailID);
                return SqlAdoWrapper.ExecuteNonQueryCommand("ItemsInDetails_InvoiceDetails_DeleteAllInvoiceDetails",
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
