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
    partial class mngrInvoiceHead
    {

        #region Select Functions

        public static bool IsInvoiceValidToDelete(int iInvoiceID)
        {
            try
            {
               object objRes =  SqlAdoWrapper.ExecuteScalarCommand("InvoiceHead_SelectIsValidToDelete",
                   new SqlParameter[] { new SqlParameter("@InvoiceID", iInvoiceID) }, false);
               return Helper.CheckNumberInt(objRes) ? Convert.ToBoolean(objRes) : true;
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
                return true;
            }
        }
        public static DataTable GetInvoicesReport(DateTime dtInvoiceDateFrom, DateTime dtInvoiceDateTo, int iInvoiceIDFrom, int iInvoiceIDTo, int iSupplierTypeID, int iSupplierID, bool bWithDetails)
        {
            SqlParameter[] sqlprmInvoiceReport = new SqlParameter[6];
            sqlprmInvoiceReport[0] = new SqlParameter("@InvoiceDateFrom", dtInvoiceDateFrom);
            sqlprmInvoiceReport[1] = new SqlParameter("@InvoiceDateTo", dtInvoiceDateTo);
            if (iInvoiceIDFrom > 0)
                sqlprmInvoiceReport[2] = new SqlParameter("@InvoiceIDFrom", iInvoiceIDFrom);
            else
                sqlprmInvoiceReport[2] = new SqlParameter("@InvoiceIDFrom", DBNull.Value);
            if (iInvoiceIDTo > 0)
                sqlprmInvoiceReport[3] = new SqlParameter("@InvoiceIDTo", iInvoiceIDTo);
            else
                sqlprmInvoiceReport[3] = new SqlParameter("@InvoiceIDTo", DBNull.Value);
            if (iSupplierTypeID > 0)
                sqlprmInvoiceReport[4] = new SqlParameter("@SupplierTypeID", iSupplierTypeID);
            else
                sqlprmInvoiceReport[4] = new SqlParameter("@SupplierTypeID", DBNull.Value);
            if (iSupplierID > 0)
                sqlprmInvoiceReport[5] = new SqlParameter("@SupplierID", iSupplierID);
            else
                sqlprmInvoiceReport[5] = new SqlParameter("@SupplierID", DBNull.Value);
            string strProcedureName = "Invoice_SelectReport";
            if(bWithDetails)
                strProcedureName = "InvoiceWithDetails_SelectReport";
            return SqlAdoWrapper.ExecuteQueryCommand(strProcedureName, sqlprmInvoiceReport, false);
        }

        #endregion

    }
}
