using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Utilities;

namespace Managers
{
    public partial class mngrColumnNames : BaseManager
    {

        #region Select Functions

        public static string GetDisplayNameByDBName(string strDBName)
        {
            try
            {
                SqlParameter[] sqlprmSelectParameters = new SqlParameter[1];
                sqlprmSelectParameters[0] = new SqlParameter("@DBName", strDBName);
                object objRes = SqlAdoWrapper.ExecuteScalarCommand("ColumnsNames_SelectByDBName", sqlprmSelectParameters, false);
                return objRes == null ? string.Empty : objRes.ToString();
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
                return string.Empty;
            }
        }

        #endregion

    }
}
