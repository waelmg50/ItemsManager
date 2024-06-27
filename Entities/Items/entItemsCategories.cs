using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utilities;
using System.Data;
using System.Data.SqlClient;

namespace Entities
{
    public class entItemsCategories : BaseEntity
    {

        #region Table Fields and properties

string _Name;
public string Name
{

get { return _Name;}
set {_Name = value;}

}
int _ParentID;
public int ParentID
{

get { return _ParentID;}
set {_ParentID = value;}

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
_Name= string.Empty;
_ParentID= 0;

        }
        #endregion

        #region Constructor

        /// <summary>
        /// Initializes all members with the defualt values.
        /// </summary>
        public entItemsCategories()
        {
            SetDefaults();
        }
        /// <summary>
        /// Initializes all members with the supplied values.
        /// </summary>
        /// <param name="iID">The ID of the record to load its values to the class memebrs.</param>
        public entItemsCategories(int iID)
            : base(iID)
        {
            try
            {
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@ID", iID);
                DataTable tblRow = SqlAdoWrapper.ExecuteQueryCommand("ItemsCategories_SelectByID", param,
                    false);
                if (tblRow != null && tblRow.Rows.Count > 0)
                {
                    DataRow rowCurr = tblRow.Rows[0];
                    ID= rowCurr["ID"] == DBNull.Value ?0: Convert.ToInt32(rowCurr["ID"]);
_Name= rowCurr["Name"] == DBNull.Value ?string.Empty: Convert.ToString(rowCurr["Name"]);
_ParentID= rowCurr["ParentID"] == DBNull.Value ?0: Convert.ToInt32(rowCurr["ParentID"]);

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

        public static bool operator ==(entItemsCategories lhs, entItemsCategories rhs)
        {
            if (
                lhs.ID == rhs.ID
&& lhs._Name == rhs._Name
&& lhs._ParentID == rhs._ParentID

                )
                return true;
            else
                return false;
        }
        public static bool operator !=(entItemsCategories lhs, entItemsCategories rhs)
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