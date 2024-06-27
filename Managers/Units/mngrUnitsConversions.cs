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
    public partial class mngrUnitsConversions : BaseManager
    {

        #region Select Functions

        public static DataTable GetUnitsConversions()
        {
            return SqlAdoWrapper.ExecuteQueryCommand("UnitsConversions_Select", null, false);
        }

        #endregion

        #region Operation Functions

        public static int Insert(entUnitsConversions entSave)
        {
            try
            {
                //Create the parameter collection of the table insert command.
                SqlParameter[] sqlprmComParam = new SqlParameter[5];
                sqlprmComParam[0] = new SqlParameter("@ID", entSave.ID);
                sqlprmComParam[0].Direction = ParameterDirection.Output;

		sqlprmComParam[1] = new SqlParameter("@FromUnitID", entSave.FromUnitID);
		sqlprmComParam[2] = new SqlParameter("@ToUnitID", entSave.ToUnitID);
		sqlprmComParam[3] = new SqlParameter("@Quantity", entSave.Quantity);

                sqlprmComParam[4] = UserID;
                int iRes = SqlAdoWrapper.ExecuteNonQueryCommand("UnitsConversions_Insert", sqlprmComParam,false);
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
        public static int Update(entUnitsConversions entSave)
        {
            try
            {
                //Create the parameter collection of the table Update command.
                SqlParameter[] sqlprmComParam = new SqlParameter[5];
                sqlprmComParam[0] = new SqlParameter("@ID", entSave.ID);

		sqlprmComParam[1] = new SqlParameter("@FromUnitID", entSave.FromUnitID);
		sqlprmComParam[2] = new SqlParameter("@ToUnitID", entSave.ToUnitID);
		sqlprmComParam[3] = new SqlParameter("@Quantity", entSave.Quantity);

                sqlprmComParam[4] = UserID;
                int iRes = SqlAdoWrapper.ExecuteNonQueryCommand("UnitsConversions_Update", sqlprmComParam, false);
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
                return SqlAdoWrapper.ExecuteNonQueryCommand("UnitsConversions_Delete",
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