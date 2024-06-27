using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utilities;
using System.Data;
using System.Data.SqlClient;

namespace Entities
{
    public class entExpenses : BaseEntity
    {

        #region Table Fields and properties

        int _TypeID;
        public int TypeID
        {

            get { return _TypeID; }
            set { _TypeID = value; }

        }
        string _Statement;
        public string Statement
        {

            get { return _Statement; }
            set { _Statement = value; }

        }
        decimal _Value;
        public decimal Value
        {

            get { return _Value; }
            set { _Value = value; }

        }
        string _Remarks;
        public string Remarks
        {

            get { return _Remarks; }
            set { _Remarks = value; }

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
            ID = 0;
            _TypeID = 0;
            _Statement = string.Empty;
            _Value = 0;
            _Remarks = string.Empty;
            _ShiftID = 0;

        }
        #endregion

        #region Constructor

        /// <summary>
        /// Initializes all members with the defualt values.
        /// </summary>
        public entExpenses()
        {
            SetDefaults();
        }
        /// <summary>
        /// Initializes all members with the supplied values.
        /// </summary>
        /// <param name="iID">The ID of the record to load its values to the class memebrs.</param>
        public entExpenses(int iID)
            : base(iID)
        {
            try
            {
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@ID", iID);
                DataTable tblRow = SqlAdoWrapper.ExecuteQueryCommand("Expenses_SelectByID", param,
                    false);
                if (tblRow != null && tblRow.Rows.Count > 0)
                {
                    DataRow rowCurr = tblRow.Rows[0];
                    ID = rowCurr["ID"] == DBNull.Value ? 0 : Convert.ToInt32(rowCurr["ID"]);
                    _TypeID = rowCurr["TypeID"] == DBNull.Value ? 0 : Convert.ToInt32(rowCurr["TypeID"]);
                    _Statement = rowCurr["Statement"] == DBNull.Value ? string.Empty : Convert.ToString(rowCurr["Statement"]);
                    _Value = rowCurr["Value"] == DBNull.Value ? 0 : Convert.ToDecimal(rowCurr["Value"]);
                    _Remarks = rowCurr["Remarks"] == DBNull.Value ? string.Empty : Convert.ToString(rowCurr["Remarks"]);
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

        public static bool operator ==(entExpenses lhs, entExpenses rhs)
        {
            if (
                lhs.ID == rhs.ID
&& lhs._TypeID == rhs._TypeID
&& lhs._Statement == rhs._Statement
&& lhs._Value == rhs._Value
&& lhs._Remarks == rhs._Remarks
&& lhs._ShiftID == rhs._ShiftID

                )
                return true;
            else
                return false;
        }
        public static bool operator !=(entExpenses lhs, entExpenses rhs)
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