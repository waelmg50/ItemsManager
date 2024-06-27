using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utilities;
using System.Data;
using System.Data.SqlClient;

namespace Entities
{
    public class entItemsInDetails : BaseEntity
    {

        #region Table Fields and properties

        int _ItemID;
        public int ItemID
        {

            get { return _ItemID; }
            set { _ItemID = value; }

        }
        decimal _Quantity;
        public decimal Quantity
        {

            get { return _Quantity; }
            set { _Quantity = value; }

        }
        int _UnitID;
        public int UnitID
        {

            get { return _UnitID; }
            set { _UnitID = value; }

        }
        int _ItemsInHeadID;
        public int ItemsInHeadID
        {

            get { return _ItemsInHeadID; }
            set { _ItemsInHeadID = value; }

        }
        decimal _PurchasePrice;
        public decimal PurchasePrice
        {

            get { return _PurchasePrice; }
            set { _PurchasePrice = value; }

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
            _Quantity = 0;
            _UnitID = 0;
            _ItemsInHeadID = 0;

        }
        #endregion

        #region Constructor

        /// <summary>
        /// Initializes all members with the defualt values.
        /// </summary>
        public entItemsInDetails()
        {
            SetDefaults();
        }
        /// <summary>
        /// Initializes all members with the supplied values.
        /// </summary>
        /// <param name="iID">The ID of the record to load its values to the class memebrs.</param>
        public entItemsInDetails(int iID)
            : base(iID)
        {
            try
            {
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@ID", iID);
                DataTable tblRow = SqlAdoWrapper.ExecuteQueryCommand("ItemsInDetails_SelectByID", param,
                    false);
                if (tblRow != null && tblRow.Rows.Count > 0)
                {
                    DataRow rowCurr = tblRow.Rows[0];
                    ID = rowCurr["ID"] == DBNull.Value ? 0 : Convert.ToInt32(rowCurr["ID"]);
                    _ItemID = rowCurr["ItemID"] == DBNull.Value ? 0 : Convert.ToInt32(rowCurr["ItemID"]);
                    _Quantity = rowCurr["Quantity"] == DBNull.Value ? 0 : Convert.ToDecimal(rowCurr["Quantity"]);
                    _UnitID = rowCurr["UnitID"] == DBNull.Value ? 0 : Convert.ToInt32(rowCurr["UnitID"]);
                    _ItemsInHeadID = rowCurr["ItemsInHeadID"] == DBNull.Value ? 0 : Convert.ToInt32(rowCurr["ItemsInHeadID"]);
                    _PurchasePrice = rowCurr["Quantity"] == DBNull.Value ? 0 : Convert.ToDecimal(rowCurr["PurchasePrice"]);
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

        public static bool operator ==(entItemsInDetails lhs, entItemsInDetails rhs)
        {
            if (
                lhs.ID == rhs.ID
&& lhs._ItemID == rhs._ItemID
&& lhs._Quantity == rhs._Quantity
&& lhs._UnitID == rhs._UnitID
&& lhs._ItemsInHeadID == rhs._ItemsInHeadID

                )
                return true;
            else
                return false;
        }
        public static bool operator !=(entItemsInDetails lhs, entItemsInDetails rhs)
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