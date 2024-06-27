using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utilities;
using System.Data;
using System.Data.SqlClient;

namespace Entities
{
    public class entInvoiceHead : BaseEntity
    {

        #region Table Fields and properties

        int _ShiftID;
        public int ShiftID
        {

            get { return _ShiftID; }
            set { _ShiftID = value; }

        }
        DateTime _InvDate;
        public DateTime InvDate
        {

            get { return _InvDate; }
            set { _InvDate = value; }

        }
        decimal _TotalCash;
        public decimal TotalCash
        {

            get { return _TotalCash; }
            set { _TotalCash = value; }

        }
        int _SellUserID;
        public int SellUserID
        {

            get { return _SellUserID; }
            set { _SellUserID = value; }

        }
        int _CustomerID;
        public int CustomerID
        {

            get { return _CustomerID; }
            set { _CustomerID = value; }

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
            _ShiftID = 0;
            _InvDate = DateTime.MinValue;
            _TotalCash = 0;
            _SellUserID = 0;
            _CustomerID = 0;
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes all members with the defualt values.
        /// </summary>
        public entInvoiceHead()
        {
            SetDefaults();
        }
        /// <summary>
        /// Initializes all members with the supplied values.
        /// </summary>
        /// <param name="iID">The ID of the record to load its values to the class memebrs.</param>
        public entInvoiceHead(int iID)
            : base(iID)
        {
            try
            {
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@ID", iID);
                DataTable tblRow = SqlAdoWrapper.ExecuteQueryCommand("InvoiceHead_SelectByID", param,
                    false);
                if (tblRow != null && tblRow.Rows.Count > 0)
                {
                    DataRow rowCurr = tblRow.Rows[0];
                    ID = rowCurr["ID"] == DBNull.Value ? 0 : Convert.ToInt32(rowCurr["ID"]);
                    _ShiftID = rowCurr["ShiftID"] == DBNull.Value ? 0 : Convert.ToInt32(rowCurr["ShiftID"]);
                    _InvDate = rowCurr["InvDate"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(rowCurr["InvDate"]);
                    _TotalCash = rowCurr["TotalCash"] == DBNull.Value ? 0 : Convert.ToDecimal(rowCurr["TotalCash"]);
                    _SellUserID = rowCurr["SellUserID"] == DBNull.Value ? 0 : Convert.ToInt32(rowCurr["SellUserID"]);
                    _CustomerID = rowCurr["CustomerID"] == DBNull.Value ? 0 : Convert.ToInt32(rowCurr["CustomerID"]);
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

        public static bool operator ==(entInvoiceHead lhs, entInvoiceHead rhs)
        {
            if (lhs.ID == rhs.ID
                && lhs._ShiftID == rhs._ShiftID
                && lhs._InvDate == rhs._InvDate
                && lhs._TotalCash == rhs._TotalCash
                && lhs._SellUserID == rhs._SellUserID
                && lhs._CustomerID == rhs._CustomerID)
                return true;
            else
                return false;
        }
        public static bool operator !=(entInvoiceHead lhs, entInvoiceHead rhs)
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