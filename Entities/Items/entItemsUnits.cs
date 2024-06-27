using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utilities;
using System.Data;
using System.Data.SqlClient;

namespace Entities
{
    public class entItemsUnits : BaseEntity
    {

        #region Table Fields and properties

        int _ItemID;
        public int ItemID
        {

            get { return _ItemID; }
            set { _ItemID = value; }

        }
        int _UnitID;
        public int UnitID
        {

            get { return _UnitID; }
            set { _UnitID = value; }

        }
        bool _IsDefault;
        public bool IsDefault
        {

            get { return _IsDefault; }
            set { _IsDefault = value; }

        }
        decimal _UnitPrice;
        public decimal UnitPrice
        {

            get { return _UnitPrice; }
            set { _UnitPrice = value; }

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
            _ItemID = 0;
            _UnitID = 0;
            _IsDefault = false;
            _UnitPrice = 0;

        }
        #endregion

        #region Constructor

        /// <summary>
        /// Initializes all members with the defualt values.
        /// </summary>
        public entItemsUnits()
        {
            SetDefaults();
        }
        /// <summary>
        /// Initializes all members with the supplied values.
        /// </summary>
        /// <param name="iID">The ID of the record to load its values to the class memebrs.</param>
        public entItemsUnits(int iID)
            : base(iID)
        {
            try
            {
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@ID", iID);
                DataTable tblRow = SqlAdoWrapper.ExecuteQueryCommand("ItemsUnits_SelectByID", param,
                    false);
                if (tblRow != null && tblRow.Rows.Count > 0)
                {
                    DataRow rowCurr = tblRow.Rows[0];
                    ID = rowCurr["ID"] == DBNull.Value ? 0 : Convert.ToInt32(rowCurr["ID"]);
                    _ItemID = rowCurr["ItemID"] == DBNull.Value ? 0 : Convert.ToInt32(rowCurr["ItemID"]);
                    _UnitID = rowCurr["UnitID"] == DBNull.Value ? 0 : Convert.ToInt32(rowCurr["UnitID"]);
                    _IsDefault = rowCurr["IsDefault"] == DBNull.Value ? false : Convert.ToBoolean(rowCurr["IsDefault"]);
                    _UnitPrice = rowCurr["UnitPrice"] == DBNull.Value ? 0 : Convert.ToDecimal(rowCurr["UnitPrice"]);

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

        public static bool operator ==(entItemsUnits lhs, entItemsUnits rhs)
        {
            if (lhs.ID == rhs.ID
                && lhs._ItemID == rhs._ItemID
                && lhs._UnitID == rhs._UnitID
                && lhs._IsDefault == rhs._IsDefault
                && lhs._UnitPrice == rhs._UnitPrice)
                return true;
            else
                return false;
        }
        public static bool operator !=(entItemsUnits lhs, entItemsUnits rhs)
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