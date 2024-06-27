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
    public class mngrSuppliers : BaseManager
    {

        #region Select Functions

        public static DataTable GetSuppliers()
        {
            return SqlAdoWrapper.ExecuteQueryCommand("Suppliers_Select", null, false);
        }
        public static DataTable GetSuppliersByIsSupplier(bool bIsSupplier)
        {
            return SqlAdoWrapper.ExecuteQueryCommand("Suppliers_SelectByIsSupplier", new SqlParameter[] { new SqlParameter("@IsSupplier", bIsSupplier) },
                false);
        }

        #endregion

        #region Operation Functions

        public static int Insert(entSuppliers entSave)
        {
            try
            {
                //Create the parameter collection of the table insert command.
                SqlParameter[] sqlprmComParam = new SqlParameter[6];
                sqlprmComParam[0] = new SqlParameter("@ID", entSave.ID);
                sqlprmComParam[0].Direction = ParameterDirection.Output;
                sqlprmComParam[1] = new SqlParameter("@Name", entSave.Name);
                sqlprmComParam[2] = new SqlParameter("@Address", entSave.Address);
                sqlprmComParam[3] = new SqlParameter("@TypeID", entSave.TypeID);
                sqlprmComParam[4] = new SqlParameter("@IsSupplier", entSave.IsSupplier);
                sqlprmComParam[5] = UserID;
                int iRes = SqlAdoWrapper.ExecuteNonQueryCommand("Suppliers_Insert", sqlprmComParam, false);
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
        public static int Update(entSuppliers entSave)
        {
            try
            {
                //Create the parameter collection of the table Update command.
                SqlParameter[] sqlprmComParam = new SqlParameter[6];
                sqlprmComParam[0] = new SqlParameter("@ID", entSave.ID);
                sqlprmComParam[1] = new SqlParameter("@Name", entSave.Name);
                sqlprmComParam[2] = new SqlParameter("@Address", entSave.Address);
                sqlprmComParam[3] = new SqlParameter("@TypeID", entSave.TypeID);
                sqlprmComParam[4] = new SqlParameter("@IsSupplier", entSave.IsSupplier);
                sqlprmComParam[5] = UserID;
                int iRes = SqlAdoWrapper.ExecuteNonQueryCommand("Suppliers_Update", sqlprmComParam, false);
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
        public static int Delete(int iID)
        {
            try
            {
                SqlParameter sqlprmID = new SqlParameter("@ID", iID);
                return SqlAdoWrapper.ExecuteNonQueryCommand("Suppliers_Delete",
                    new SqlParameter[] { sqlprmID, UserID }, false);
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