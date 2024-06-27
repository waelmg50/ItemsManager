using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utilities;
using System.Data;
using System.Data.SqlClient;

namespace Entities
{
    public class entUnits : BaseEntity
    {

        #region Table Fields and properties

        string _Name;
        public string Name
        {

            get { return _Name; }
            set { _Name = value; }

        }
        int _TypeID;
        public int TypeID
        {

            get { return _TypeID; }
            set { _TypeID = value; }

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
            _Name = string.Empty;
            _TypeID = 0;

        }
        #endregion

        #region Constructor

        /// <summary>
        /// Initializes all members with the defualt values.
        /// </summary>
        public entUnits()
        {
            SetDefaults();
        }
        /// <summary>
        /// Initializes all members with the supplied values.
        /// </summary>
        /// <param name="iID">The ID of the record to load its values to the class memebrs.</param>
        public entUnits(int iID)
            : base(iID)
        {
            try
            {
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@ID", iID);
                DataTable tblRow = SqlAdoWrapper.ExecuteQueryCommand("Units_SelectByID", param,
                    false);
                if (tblRow != null && tblRow.Rows.Count > 0)
                {
                    DataRow rowCurr = tblRow.Rows[0];
                    ID = rowCurr["ID"] == DBNull.Value ? 0 : Convert.ToInt32(rowCurr["ID"]);
                    _Name = rowCurr["Name"] == DBNull.Value ? string.Empty : Convert.ToString(rowCurr["Name"]);
                    _TypeID = rowCurr["TypeID"] == DBNull.Value ? 0 : Convert.ToInt32(rowCurr["TypeID"]);

                }
                else
                    SetDefaults();
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }
        public entUnits(int iID, SqlTransaction sqltrnSave)
            : base(iID)
        {
            try
            {
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@ID", iID);
                DataTable tblRow = SqlAdoWrapper.ExecuteQueryCommand("Units_SelectByID", param, sqltrnSave, false);
                if (tblRow != null && tblRow.Rows.Count > 0)
                {
                    DataRow rowCurr = tblRow.Rows[0];
                    ID = rowCurr["ID"] == DBNull.Value ? 0 : Convert.ToInt32(rowCurr["ID"]);
                    _Name = rowCurr["Name"] == DBNull.Value ? string.Empty : Convert.ToString(rowCurr["Name"]);
                    _TypeID = rowCurr["TypeID"] == DBNull.Value ? 0 : Convert.ToInt32(rowCurr["TypeID"]);

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

        public static bool operator ==(entUnits lhs, entUnits rhs)
        {
            if (
                lhs.ID == rhs.ID
&& lhs._Name == rhs._Name
&& lhs._TypeID == rhs._TypeID

                )
                return true;
            else
                return false;
        }
        public static bool operator !=(entUnits lhs, entUnits rhs)
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