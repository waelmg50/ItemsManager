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
    public partial class mngrItemsInDetails_InvoiceDetails : BaseManager
    {

        #region Select Functions

        public static DataTable GetItemsInDetails_InvoiceDetails()
        {
            return SqlAdoWrapper.ExecuteQueryCommand("ItemsInDetails_InvoiceDetails_Select", null, false);
        }

        #endregion

        #region Operation Functions

        public static int Insert(entItemsInDetails_InvoiceDetails entSave, SqlTransaction sqltrnSave)
        {
            try
            {
                //Create the parameter collection of the table insert command.
                SqlParameter[] sqlprmComParam = new SqlParameter[5];
                sqlprmComParam[0] = new SqlParameter("@ID", entSave.ID);
                sqlprmComParam[0].Direction = ParameterDirection.Output;

                sqlprmComParam[1] = new SqlParameter("@ItemInID", entSave.ItemInID);
                sqlprmComParam[2] = new SqlParameter("@InvoiceDetailsID", entSave.InvoiceDetailsID);
                sqlprmComParam[3] = new SqlParameter("@Quantity", entSave.Quantity);

                sqlprmComParam[4] = UserID;
                int iRes = SqlAdoWrapper.ExecuteNonQueryCommand("ItemsInDetails_InvoiceDetails_Insert", sqlprmComParam, sqltrnSave, false);
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
        public static int Update(entItemsInDetails_InvoiceDetails entSave, SqlTransaction sqltrnSave)
        {
            try
            {
                //Create the parameter collection of the table Update command.
                SqlParameter[] sqlprmComParam = new SqlParameter[5];
                sqlprmComParam[0] = new SqlParameter("@ID", entSave.ID);

		sqlprmComParam[1] = new SqlParameter("@ItemInID", entSave.ItemInID);
		sqlprmComParam[2] = new SqlParameter("@InvoiceDetailsID", entSave.InvoiceDetailsID);
		sqlprmComParam[3] = new SqlParameter("@Quantity", entSave.Quantity);

                sqlprmComParam[4] = UserID;
                int iRes = SqlAdoWrapper.ExecuteNonQueryCommand("ItemsInDetails_InvoiceDetails_Update", sqlprmComParam, sqltrnSave, false);
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
        public static int Delete(int iID, SqlTransaction sqltrDeleteItemsInDetails_InvoiceDetails)
        {
            try
            {
                SqlParameter sqlprmID = new SqlParameter("@ID", iID);
                return SqlAdoWrapper.ExecuteNonQueryCommand("ItemsInDetails_InvoiceDetails_Delete",
                    new SqlParameter[] { sqlprmID, UserID },sqltrDeleteItemsInDetails_InvoiceDetails, false);
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