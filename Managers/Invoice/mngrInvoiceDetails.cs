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
    public partial class mngrInvoiceDetails : BaseManager
    {

        #region Select Functions

        public static DataTable GetInvoiceDetails()
        {
            return SqlAdoWrapper.ExecuteQueryCommand("InvoiceDetails_Select", null, false);
        }

        #endregion

        #region Operation Functions

        public static int Insert(entInvoiceDetails entSave, SqlTransaction sqltrSaveInvoiceDetails)
        {
            try
            {
                //Create the parameter collection of the table insert command.
                SqlParameter[] sqlprmComParam = new SqlParameter[7];
                sqlprmComParam[0] = new SqlParameter("@ID", entSave.ID);
                sqlprmComParam[0].Direction = ParameterDirection.Output;

                sqlprmComParam[1] = new SqlParameter("@InvoiceHeadID", entSave.InvoiceHeadID);
                sqlprmComParam[2] = new SqlParameter("@ItemID", entSave.ItemID);
                sqlprmComParam[3] = new SqlParameter("@UnitID", entSave.UnitID);
                sqlprmComParam[4] = new SqlParameter("@Quantity", entSave.Quantity);
                sqlprmComParam[5] = new SqlParameter("@UnitPrice", entSave.UnitPrice);

                sqlprmComParam[6] = UserID;
                int iRes = SqlAdoWrapper.ExecuteNonQueryCommand("InvoiceDetails_Insert", sqlprmComParam, sqltrSaveInvoiceDetails, false);
                if (iRes > 0 && sqlprmComParam[0].Value != null && sqlprmComParam[0].Value != DBNull.Value)
                    return Convert.ToInt32(sqlprmComParam[0].Value);
                return -1;
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
                return -1;
            }
        }
        public static int Update(entInvoiceDetails entSave, SqlTransaction sqltrSaveInvoiceDetails)
        {
            try
            {
                //Create the parameter collection of the table Update command.
                SqlParameter[] sqlprmComParam = new SqlParameter[7];
                sqlprmComParam[0] = new SqlParameter("@ID", entSave.ID);

                sqlprmComParam[1] = new SqlParameter("@InvoiceHeadID", entSave.InvoiceHeadID);
                sqlprmComParam[2] = new SqlParameter("@ItemID", entSave.ItemID);
                sqlprmComParam[3] = new SqlParameter("@UnitID", entSave.UnitID);
                sqlprmComParam[4] = new SqlParameter("@Quantity", entSave.Quantity);
                sqlprmComParam[5] = new SqlParameter("@UnitPrice", entSave.UnitPrice);

                sqlprmComParam[6] = UserID;
                int iRes = SqlAdoWrapper.ExecuteNonQueryCommand("InvoiceDetails_Update", sqlprmComParam, sqltrSaveInvoiceDetails, false);
                if (iRes > 0)
                    return iRes;
                return -1;
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
                return -1;
            }
        }
        public static int Delete(int iID, SqlTransaction sqltrDeleteInvoiceDetails)
        {
            try
            {
                SqlParameter sqlprmID = new SqlParameter("@ID", iID);
                return SqlAdoWrapper.ExecuteNonQueryCommand("InvoiceDetails_Delete",
                    new SqlParameter[] { sqlprmID, UserID }, sqltrDeleteInvoiceDetails, false);
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