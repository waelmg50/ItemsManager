using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utilities;
using System.Data;
using System.Data.SqlClient;

namespace Entities
{
    public class entUsers : BaseEntity
    {

        #region Table Fields and properties

string _Username;
public string Username
{

get { return _Username;}
set {_Username = value;}

}
string _Password;
public string Password
{

get { return _Password;}
set {_Password = value;}

}
string _FullName;
public string FullName
{

get { return _FullName;}
set {_FullName = value;}

}
bool _IsAdmin;
public bool IsAdmin
{

get { return _IsAdmin;}
set {_IsAdmin = value;}

}
bool _IsActive;
public bool IsActive
{

get { return _IsActive;}
set {_IsActive = value;}

}


        #endregion

        #region Private Methods
        /// <summary>
        /// Set the defualt values of the class members
        /// </summary>
        protected override void SetDefaults()
        {
            base.SetDefaults();
            ID= 0;
_Username= string.Empty;
_Password= string.Empty;
_FullName= string.Empty;
_IsAdmin= false;
_IsActive= false;

        }
        #endregion

        #region Constructor

        /// <summary>
        /// Initializes all members with the defualt values.
        /// </summary>
        public entUsers()
        {
            SetDefaults();
        }
        /// <summary>
        /// Initializes all members with the supplied values.
        /// </summary>
        /// <param name="iID">The ID of the record to load its values to the class memebrs.</param>
        public entUsers(int iID)
            : base(iID)
        {
            try
            {
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@ID", iID);
                DataTable tblRow = SqlAdoWrapper.ExecuteQueryCommand("Users_SelectByID", param,
                    false);
                if (tblRow != null && tblRow.Rows.Count > 0)
                {
                    DataRow rowCurr = tblRow.Rows[0];
                    ID= rowCurr["ID"] == DBNull.Value ?0: Convert.ToInt32(rowCurr["ID"]);
_Username= rowCurr["Username"] == DBNull.Value ?string.Empty: Convert.ToString(rowCurr["Username"]);
_Password= rowCurr["Password"] == DBNull.Value ?string.Empty: Convert.ToString(rowCurr["Password"]);
_FullName= rowCurr["FullName"] == DBNull.Value ?string.Empty: Convert.ToString(rowCurr["FullName"]);
_IsAdmin= rowCurr["IsAdmin"] == DBNull.Value ?false: Convert.ToBoolean(rowCurr["IsAdmin"]);
_IsActive= rowCurr["IsActive"] == DBNull.Value ?false: Convert.ToBoolean(rowCurr["IsActive"]);

                }
                else
                    SetDefaults();
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }
        #endregion

        #region Comparison Functions

        public static bool operator ==(entUsers lhs, entUsers rhs)
        {
            if (
                lhs.ID == rhs.ID
&& lhs._Username == rhs._Username
&& lhs._Password == rhs._Password
&& lhs._FullName == rhs._FullName
&& lhs._IsAdmin == rhs._IsAdmin
&& lhs._IsActive == rhs._IsActive

                )
                return true;
            else
                return false;
        }
        public static bool operator !=(entUsers lhs, entUsers rhs)
        {
            return !(lhs == rhs);
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        #endregion

    }
}