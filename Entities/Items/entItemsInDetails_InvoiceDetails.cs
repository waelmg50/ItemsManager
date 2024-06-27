using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utilities;
using System.Data;
using System.Data.SqlClient;

namespace Entities
{
    public class entItemsInDetails_InvoiceDetails : BaseEntity
    {

        #region Table Fields and properties

        int _ItemInID;
        public int ItemInID
        {

            get { return _ItemInID; }
            set { _ItemInID = value; }

        }
        int _InvoiceDetailsID;
        public int InvoiceDetailsID
        {

            get { return _InvoiceDetailsID; }
            set { _InvoiceDetailsID = value; }

        }
        decimal _Quantity;
        public decimal Quantity
        {

            get { return _Quantity; }
            set { _Quantity = value; }

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
            _ItemInID = 0;
            _InvoiceDetailsID = 0;
            _Quantity = 0;

        }
        #endregion

        #region Constructor

        /// <summary>
        /// Initializes all members with the defualt values.
        /// </summary>
        public entItemsInDetails_InvoiceDetails()
        {
            SetDefaults();
        }
        /// <summary>
        /// Initializes all members with the supplied values.
        /// </summary>
        /// <param name="iID">The ID of the record to load its values to the class memebrs.</param>
        public entItemsInDetails_InvoiceDetails(int iID)
            : base(iID)
        {
            try
            {
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@ID", iID);
                DataTable tblRow = SqlAdoWrapper.ExecuteQueryCommand("ItemsInDetails_InvoiceDetails_SelectByID", param,
                    false);
                if (tblRow != null && tblRow.Rows.Count > 0)
                {
                    DataRow rowCurr = tblRow.Rows[0];
                    ID = rowCurr["ID"] == DBNull.Value ? 0 : Convert.ToInt32(rowCurr["ID"]);
                    _ItemInID = rowCurr["ItemInID"] == DBNull.Value ? 0 : Convert.ToInt32(rowCurr["ItemInID"]);
                    _InvoiceDetailsID = rowCurr["InvoiceDetailsID"] == DBNull.Value ? 0 : Convert.ToInt32(rowCurr["InvoiceDetailsID"]);
                    _Quantity = rowCurr["Quantity"] == DBNull.Value ? 0 : Convert.ToDecimal(rowCurr["Quantity"]);

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

        public static bool operator ==(entItemsInDetails_InvoiceDetails lhs, entItemsInDetails_InvoiceDetails rhs)
        {
            if (
                lhs.ID == rhs.ID
&& lhs._ItemInID == rhs._ItemInID
&& lhs._InvoiceDetailsID == rhs._InvoiceDetailsID
&& lhs._Quantity == rhs._Quantity

                )
                return true;
            else
                return false;
        }
        public static bool operator !=(entItemsInDetails_InvoiceDetails lhs, entItemsInDetails_InvoiceDetails rhs)
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