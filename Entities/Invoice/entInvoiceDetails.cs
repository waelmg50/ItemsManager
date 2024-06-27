using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utilities;
using System.Data;
using System.Data.SqlClient;

namespace Entities
{
    public class entInvoiceDetails : BaseEntity
    {

        #region Table Fields and properties

        int _InvoiceHeadID;
        public int InvoiceHeadID
        {

            get { return _InvoiceHeadID; }
            set { _InvoiceHeadID = value; }

        }
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
        decimal _Quantity;
        public decimal Quantity
        {

            get { return _Quantity; }
            set { _Quantity = value; }

        }
        decimal _UnitPrice;
        public decimal UnitPrice
        {

            get { return _UnitPrice; }
            set { _UnitPrice = value; }

        }
        decimal _TotalPrice;
        public decimal TotalPrice
        {

            get { return _TotalPrice; }
            set { _TotalPrice = value; }

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
            _InvoiceHeadID = 0;
            _ItemID = 0;
            _UnitID = 0;
            _Quantity = 0;
            _UnitPrice = 0;
            _TotalPrice = 0;

        }
        #endregion

        #region Constructor

        /// <summary>
        /// Initializes all members with the defualt values.
        /// </summary>
        public entInvoiceDetails()
        {
            SetDefaults();
        }
        /// <summary>
        /// Initializes all members with the supplied values.
        /// </summary>
        /// <param name="iID">The ID of the record to load its values to the class memebrs.</param>
        public entInvoiceDetails(int iID)
            : base(iID)
        {
            try
            {
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@ID", iID);
                DataTable tblRow = SqlAdoWrapper.ExecuteQueryCommand("InvoiceDetails_SelectByID", param,
                    false);
                if (tblRow != null && tblRow.Rows.Count > 0)
                {
                    DataRow rowCurr = tblRow.Rows[0];
                    ID = rowCurr["ID"] == DBNull.Value ? 0 : Convert.ToInt32(rowCurr["ID"]);
                    _InvoiceHeadID = rowCurr["InvoiceHeadID"] == DBNull.Value ? 0 : Convert.ToInt32(rowCurr["InvoiceHeadID"]);
                    _ItemID = rowCurr["ItemID"] == DBNull.Value ? 0 : Convert.ToInt32(rowCurr["ItemID"]);
                    _UnitID = rowCurr["UnitID"] == DBNull.Value ? 0 : Convert.ToInt32(rowCurr["UnitID"]);
                    _Quantity = rowCurr["Quantity"] == DBNull.Value ? 0 : Convert.ToDecimal(rowCurr["Quantity"]);
                    _UnitPrice = rowCurr["UnitPrice"] == DBNull.Value ? 0 : Convert.ToDecimal(rowCurr["UnitPrice"]);
                    _TotalPrice = rowCurr["TotalPrice"] == DBNull.Value ? 0 : Convert.ToDecimal(rowCurr["TotalPrice"]);

                }
                else
                    SetDefaults();
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }
        public entInvoiceDetails(int iID, SqlTransaction sqltrnSave)
            : base(iID)
        {
            try
            {
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@ID", iID);
                DataTable tblRow = SqlAdoWrapper.ExecuteQueryCommand("InvoiceDetails_SelectByID", param, sqltrnSave, false);
                if (tblRow != null && tblRow.Rows.Count > 0)
                {
                    DataRow rowCurr = tblRow.Rows[0];
                    ID = rowCurr["ID"] == DBNull.Value ? 0 : Convert.ToInt32(rowCurr["ID"]);
                    _InvoiceHeadID = rowCurr["InvoiceHeadID"] == DBNull.Value ? 0 : Convert.ToInt32(rowCurr["InvoiceHeadID"]);
                    _ItemID = rowCurr["ItemID"] == DBNull.Value ? 0 : Convert.ToInt32(rowCurr["ItemID"]);
                    _UnitID = rowCurr["UnitID"] == DBNull.Value ? 0 : Convert.ToInt32(rowCurr["UnitID"]);
                    _Quantity = rowCurr["Quantity"] == DBNull.Value ? 0 : Convert.ToDecimal(rowCurr["Quantity"]);
                    _UnitPrice = rowCurr["UnitPrice"] == DBNull.Value ? 0 : Convert.ToDecimal(rowCurr["UnitPrice"]);
                    _TotalPrice = rowCurr["TotalPrice"] == DBNull.Value ? 0 : Convert.ToDecimal(rowCurr["TotalPrice"]);

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

        public static bool operator ==(entInvoiceDetails lhs, entInvoiceDetails rhs)
        {
            if (
                lhs.ID == rhs.ID
&& lhs._InvoiceHeadID == rhs._InvoiceHeadID
&& lhs._ItemID == rhs._ItemID
&& lhs._UnitID == rhs._UnitID
&& lhs._Quantity == rhs._Quantity
&& lhs._UnitPrice == rhs._UnitPrice
&& lhs._TotalPrice == rhs._TotalPrice

                )
                return true;
            else
                return false;
        }
        public static bool operator !=(entInvoiceDetails lhs, entInvoiceDetails rhs)
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