using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utilities;
using System.Data;
using System.Data.SqlClient;

namespace Entities
{
    public class entSuppliers : BaseEntity
    {

        #region Table Fields and properties

       string _Name;
        public string Name
        {

            get { return _Name; }
            set { _Name = value; }

        }
        string _Address;
        public string Address
        {

            get { return _Address; }
            set { _Address = value; }

        }
        int _TypeID;
        public int TypeID
        {

            get { return _TypeID; }
            set { _TypeID = value; }

        }
        bool _IsSupplier;
        public bool IsSupplier
        {

            get { return _IsSupplier; }
            set { _IsSupplier = value; }

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
            _Address = string.Empty;
            _TypeID = 0;
            _IsSupplier = false;
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes all members with the defualt values.
        /// </summary>
        public entSuppliers()
        {
            SetDefaults();
        }
        /// <summary>
        /// Initializes all members with the supplied values.
        /// </summary>
        /// <param name="iID">The ID of the record to load its values to the class memebrs.</param>
        public entSuppliers(int iID)
            : base(iID)
        {
            try
            {
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@ID", iID);
                DataTable tblRow = SqlAdoWrapper.ExecuteQueryCommand("Suppliers_SelectByID", param,
                    false);
                if (tblRow != null && tblRow.Rows.Count > 0)
                {
                    DataRow rowCurr = tblRow.Rows[0];
                    ID = rowCurr["ID"] == DBNull.Value ? 0 : Convert.ToInt32(rowCurr["ID"]);
                    _Name = rowCurr["Name"] == DBNull.Value ? string.Empty : Convert.ToString(rowCurr["Name"]);
                    _Address = rowCurr["Address"] == DBNull.Value ? string.Empty : Convert.ToString(rowCurr["Address"]);
                    _TypeID = rowCurr["TypeID"] == DBNull.Value ? 0 : Convert.ToInt32(rowCurr["TypeID"]);
                    _IsSupplier = rowCurr["IsSupplier"] == DBNull.Value ? false : Convert.ToBoolean(rowCurr["IsSupplier"]);
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

        public static bool operator ==(entSuppliers lhs, entSuppliers rhs)
        {
            if (lhs.ID == rhs.ID
                && lhs._Name == rhs._Name
                && lhs._Address == rhs._Address
                && lhs._IsSupplier == rhs._IsSupplier
                && lhs._TypeID == rhs._TypeID)
                return true;
            else
                return false;
        }
        public static bool operator !=(entSuppliers lhs, entSuppliers rhs)
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