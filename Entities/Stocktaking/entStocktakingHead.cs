using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utilities;
using System.Data;
using System.Data.SqlClient;

namespace Entities
{
    public class entStocktakingHead : BaseEntity
    {

        #region Table Fields and properties

        DateTime _StockTakingDate;
        public DateTime StockTakingDate
        {

            get { return _StockTakingDate; }
            set { _StockTakingDate = value; }

        }
        int _UserID;
        public int UserID
        {

            get { return _UserID; }
            set { _UserID = value; }

        }
        int _ShiftID;
        public int ShiftID
        {

            get { return _ShiftID; }
            set { _ShiftID = value; }

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
            _StockTakingDate = DateTime.MinValue;
            _UserID = 0;
            _ShiftID = 0;

        }
        #endregion

        #region Constructor

        /// <summary>
        /// Initializes all members with the defualt values.
        /// </summary>
        public entStocktakingHead()
        {
            SetDefaults();
        }
        /// <summary>
        /// Initializes all members with the supplied values.
        /// </summary>
        /// <param name="iID">The ID of the record to load its values to the class memebrs.</param>
        public entStocktakingHead(int iID)
            : base(iID)
        {
            try
            {
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@ID", iID);
                DataTable tblRow = SqlAdoWrapper.ExecuteQueryCommand("StocktakingHead_SelectByID", param,
                    false);
                if (tblRow != null && tblRow.Rows.Count > 0)
                {
                    DataRow rowCurr = tblRow.Rows[0];
                    ID = rowCurr["ID"] == DBNull.Value ? 0 : Convert.ToInt32(rowCurr["ID"]);
                    _StockTakingDate = rowCurr["StockTakingDate"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(rowCurr["StockTakingDate"]);
                    _UserID = rowCurr["UserID"] == DBNull.Value ? 0 : Convert.ToInt32(rowCurr["UserID"]);
                    _ShiftID = rowCurr["ShiftID"] == DBNull.Value ? 0 : Convert.ToInt32(rowCurr["ShiftID"]);

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

        public static bool operator ==(entStocktakingHead lhs, entStocktakingHead rhs)
        {
            if (lhs.ID == rhs.ID
                && lhs._StockTakingDate == rhs._StockTakingDate
                && lhs._UserID == rhs._UserID
                && lhs._ShiftID == rhs._ShiftID)
                return true;
            else
                return false;
        }
        public static bool operator !=(entStocktakingHead lhs, entStocktakingHead rhs)
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