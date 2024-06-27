using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Utilities;
using Entities;
using Managers;

namespace Managers
{
    public partial class mngrInvoiceDetails
    {

        #region Select Functions

        public static DataTable GetInvoiceDetails(int iItemInHeadID)
        {
            try
            {
                return SqlAdoWrapper.ExecuteQueryCommand("InvoiceDetails_SelectByInvoiceHeadID",
                    new SqlParameter[] { new SqlParameter("@InvoiceHeadID", iItemInHeadID) }, false);
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
                return null;
            }
        }
        public static DataTable GetInvoiceDetails1()
        {
            return SqlAdoWrapper.ExecuteQueryCommand("View_InvoiceDetails1", null, false);
        }
        public static DataTable GetView_InvoiceDetails1byInvoiceHeadID(int InvoiceHeadID)
        {
            SqlParameter[] sqlparam = new SqlParameter[1];
            sqlparam[0] = new SqlParameter("@InvoiceHeadID", InvoiceHeadID);
            return SqlAdoWrapper.ExecuteQueryCommand("View_InvoiceDetails1byInvoiceHeadID", sqlparam, false);
        }

        #endregion

    }
}
