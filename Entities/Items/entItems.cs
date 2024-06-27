using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utilities;
using System.Data;
using System.Data.SqlClient;

namespace Entities
{
    public class entItems : BaseEntity
    {

        #region Table Fields and properties

        string _BarCode;
        public string BarCode
        {

            get { return _BarCode; }
            set { _BarCode = value; }

        }
        string _Name;
        public string Name
        {

            get { return _Name; }
            set { _Name = value; }

        }
        string _Description;
        public string Description
        {

            get { return _Description; }
            set { _Description = value; }

        }
        int _CategoryID;
        public int CategoryID
        {

            get { return _CategoryID; }
            set { _CategoryID = value; }

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
            _BarCode = string.Empty;
            _Name = string.Empty;
            _Description = string.Empty;
            _CategoryID = 0;

        }
        #endregion

        #region Constructor

        /// <summary>
        /// Initializes all members with the defualt values.
        /// </summary>
        public entItems()
        {
            SetDefaults();
        }
        /// <summary>
        /// Initializes all members with the supplied values.
        /// </summary>
        /// <param name="iID">The ID of the record to load its values to the class memebrs.</param>
        public entItems(int iID)
            : base(iID)
        {
            try
            {
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@ID", iID);
                DataTable tblRow = SqlAdoWrapper.ExecuteQueryCommand("Items_SelectByID", param,
                    false);
                if (tblRow != null && tblRow.Rows.Count > 0)
                {
                    DataRow rowCurr = tblRow.Rows[0];
                    ID = rowCurr["ID"] == DBNull.Value ? 0 : Convert.ToInt32(rowCurr["ID"]);
                    _BarCode = rowCurr["BarCode"] == DBNull.Value ? string.Empty : Convert.ToString(rowCurr["BarCode"]);
                    _Name = rowCurr["Name"] == DBNull.Value ? string.Empty : Convert.ToString(rowCurr["Name"]);
                    _Description = rowCurr["Description"] == DBNull.Value ? string.Empty : Convert.ToString(rowCurr["Description"]);
                    _CategoryID = rowCurr["CategoryID"] == DBNull.Value ? 0 : Convert.ToInt32(rowCurr["CategoryID"]);

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

        public static bool operator ==(entItems lhs, entItems rhs)
        {
            if (
                lhs.ID == rhs.ID
&& lhs._BarCode == rhs._BarCode
&& lhs._Name == rhs._Name
&& lhs._Description == rhs._Description
&& lhs._CategoryID == rhs._CategoryID

                )
                return true;
            else
                return false;
        }
        public static bool operator !=(entItems lhs, entItems rhs)
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