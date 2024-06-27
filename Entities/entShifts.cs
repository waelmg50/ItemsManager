using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utilities;
using System.Data;
using System.Data.SqlClient;

namespace Entities
{
    public class entShifts : BaseEntity
    {

        #region Table Fields and properties

        DateTime _DateIn;
        public DateTime DateIn
        {

            get { return _DateIn; }
            set { _DateIn = value; }

        }
        DateTime _DateOut;
        public DateTime DateOut
        {

            get { return _DateOut; }
            set { _DateOut = value; }

        }
        int _TimeConsumed;
        public int TimeConsumed
        {

            get { return _TimeConsumed; }
        }
        int _UserInID;
        public int UserInID
        {

            get { return _UserInID; }
            set { _UserInID = value; }

        }
        int _UserOutID;
        public int UserOutID
        {

            get { return _UserOutID; }
            set { _UserOutID = value; }

        }
        decimal _CashIn;
        public decimal CashIn
        {

            get { return _CashIn; }
            set { _CashIn = value; }

        }
        decimal _CashOut;
        public decimal CashOut
        {

            get { return _CashOut; }
            set { _CashOut = value; }

        }
        bool _Finished;
        public bool Finished
        {

            get { return _Finished; }
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
            _DateIn = DateTime.MinValue;
            _DateOut = DateTime.MinValue;
            _TimeConsumed = 0;
            _UserInID = 0;
            _UserOutID = 0;
            _CashIn = 0;
            _CashOut = 0;
            _Finished = false;
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes all members with the defualt values.
        /// </summary>
        public entShifts()
        {
            SetDefaults();
        }
        /// <summary>
        /// Initializes all members with the supplied values.
        /// </summary>
        /// <param name="iID">The ID of the record to load its values to the class memebrs.</param>
        public entShifts(int iID)
            : base(iID)
        {
            try
            {
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@ID", iID);
                DataTable tblRow = SqlAdoWrapper.ExecuteQueryCommand("Shifts_SelectByID", param,
                    false);
                if (tblRow != null && tblRow.Rows.Count > 0)
                {
                    DataRow rowCurr = tblRow.Rows[0];
                    ID = rowCurr["ID"] == DBNull.Value ? 0 : Convert.ToInt32(rowCurr["ID"]);
                    _DateIn = rowCurr["DateIn"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(rowCurr["DateIn"]);
                    _DateOut = rowCurr["DateOut"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(rowCurr["DateOut"]);
                    _TimeConsumed = rowCurr["TimeConsumed"] == DBNull.Value ? 0 : Convert.ToInt32(rowCurr["TimeConsumed"]);
                    _UserInID = rowCurr["UserInID"] == DBNull.Value ? 0 : Convert.ToInt32(rowCurr["UserInID"]);
                    _UserOutID = rowCurr["UserOutID"] == DBNull.Value ? 0 : Convert.ToInt32(rowCurr["UserOutID"]);
                    _CashIn = rowCurr["CashIn"] == DBNull.Value ? 0 : Convert.ToDecimal(rowCurr["CashIn"]);
                    _CashOut = rowCurr["CashOut"] == DBNull.Value ? 0 : Convert.ToDecimal(rowCurr["CashOut"]);
                    _Finished = rowCurr["Finished"] == DBNull.Value ? false : Convert.ToBoolean(rowCurr["Finished"]);

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

        public static bool operator ==(entShifts lhs, entShifts rhs)
        {
            if (lhs.ID == rhs.ID
                && lhs._DateIn == rhs._DateIn
                && lhs._DateOut == rhs._DateOut
                && lhs._TimeConsumed == rhs._TimeConsumed
                && lhs._UserInID == rhs._UserInID
                && lhs._UserOutID == rhs._UserOutID
                && lhs._CashIn == rhs._CashIn
                && lhs._CashOut == rhs._CashOut
                && lhs._Finished == rhs._Finished)
                return true;
            else
                return false;
        }
        public static bool operator !=(entShifts lhs, entShifts rhs)
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