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
    public partial class mngrItemsUnitsConversions : BaseManager
    {

        #region Select Functions

        public static DataTable GetItemsUnitsConversions()
        {
            return SqlAdoWrapper.ExecuteQueryCommand("ItemsUnitsConversions_Select", null, false);
        }

        #endregion

        #region Operation Functions

        public static int Insert(entItemsUnitsConversions entSave)
        {
            try
            {
                //Create the parameter collection of the table insert command.
                SqlParameter[] sqlprmComParam = new SqlParameter[6];
                sqlprmComParam[0] = new SqlParameter("@ID", entSave.ID);
                sqlprmComParam[0].Direction = ParameterDirection.Output;

		sqlprmComParam[1] = new SqlParameter("@ItemID", entSave.ItemID);
		sqlprmComParam[2] = new SqlParameter("@FromUnitID", entSave.FromUnitID);
		sqlprmComParam[3] = new SqlParameter("@ToUnitID", entSave.ToUnitID);
		sqlprmComParam[4] = new SqlParameter("@Quantity", entSave.Quantity);

                sqlprmComParam[5] = UserID;
                int iRes = SqlAdoWrapper.ExecuteNonQueryCommand("ItemsUnitsConversions_Insert", sqlprmComParam,false);
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
        public static int Update(entItemsUnitsConversions entSave)
        {
            try
            {
                //Create the parameter collection of the table Update command.
                SqlParameter[] sqlprmComParam = new SqlParameter[6];
                sqlprmComParam[0] = new SqlParameter("@ID", entSave.ID);

		sqlprmComParam[1] = new SqlParameter("@ItemID", entSave.ItemID);
		sqlprmComParam[2] = new SqlParameter("@FromUnitID", entSave.FromUnitID);
		sqlprmComParam[3] = new SqlParameter("@ToUnitID", entSave.ToUnitID);
		sqlprmComParam[4] = new SqlParameter("@Quantity", entSave.Quantity);

                sqlprmComParam[5] = UserID;
                int iRes = SqlAdoWrapper.ExecuteNonQueryCommand("ItemsUnitsConversions_Update", sqlprmComParam, false);
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
                return SqlAdoWrapper.ExecuteNonQueryCommand("ItemsUnitsConversions_Delete",
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