using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Utilities
{
    /// <summary>
    /// Manages the login to the program for the user.
    /// </summary>
    public class UserLogin
    {

        #region Class members

        static int iLoggedUserID;
        static bool bIsAdmin;
        static int iCurrentShiftID;

        #endregion

        #region Class Properties

        /// <summary>
        /// The ID of the current logged user.
        /// </summary>
        public static int LoggedUserID
        {
            get
            {
                return iLoggedUserID;
            }
            set
            {
                iLoggedUserID = value;
            }
        }
        public static bool IsAdmin
        {
            get { return UserLogin.bIsAdmin; }
            set { UserLogin.bIsAdmin = value; }
        }
        public static int CurrentShiftID
        {
            get { return iCurrentShiftID; }
            set { iCurrentShiftID = value; }
        }

        #endregion

        #region Public Functions

        /// <summary>
        /// Checks if there is a user with this username and password.
        /// </summary>
        /// <param name="UserName">The user name of the logged user.</param>
        /// <param name="Password">The Password of the logged user.</param>
        /// <returns>Returns true if the user exists otherwise it returns false.</returns>
        public static bool CheckUser(string UserName, string Password)
        {
            try
            {
                SqlParameter[] sqlprmCheckUser = new SqlParameter[2];
                sqlprmCheckUser[0] = new SqlParameter("@UserName", UserName);
                sqlprmCheckUser[1] = new SqlParameter("@Password", Password);
                
                object objUserID = SqlAdoWrapper.ExecuteScalarCommand("Users_SelectCheck", sqlprmCheckUser, false);
                if (objUserID != null)
                {
                    iLoggedUserID = Convert.ToInt32(objUserID);
                    string strIsAdmin = RecordsFunctions.GetNameUsingID("Users", "IsAdmin", iLoggedUserID);
                    bIsAdmin = Convert.ToBoolean(strIsAdmin);
                }
                return objUserID != null;
            }
            catch (Exception e)
            {
                ErrorHandler.LogError(e);
                return false;
            }
            finally
            {
                GC.Collect();
            }
        }
        
        #endregion

    }
}
