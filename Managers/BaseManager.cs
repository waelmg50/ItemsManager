using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Utilities;

namespace Managers
{
    public class BaseManager
    {

        #region Public Properties
        
        /// <summary>
        /// Gets the SQL parameter that have the current user interface language.
        /// </summary>
        public static SqlParameter Language
        {
            get
            {
                return new SqlParameter("@Lang", ConfigurationManager.Language);
            }
        }
        /// <summary>
        /// Gets the SQL parameter that have the current logged user id.
        /// </summary>
        public static SqlParameter UserID
        {
            get
            {
                return new SqlParameter("@UserID", UserLogin.LoggedUserID);
            }
        }

        #endregion

    }
}
