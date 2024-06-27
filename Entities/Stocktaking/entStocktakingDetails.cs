using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utilities;
using System.Data;
using System.Data.SqlClient;

namespace Entities
{
    public class entStocktakingDetails : BaseEntity
    {

        #region Table Fields and properties

        int _StocktakingHeadID;
        public int StocktakingHeadID
        {

            get { return _StocktakingHeadID; }
            set { _StocktakingHeadID = value; }

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
        decimal _CalculatedQuantity;
        public decimal CalculatedQuantity
        {

            get { return _CalculatedQuantity; }
            set { _CalculatedQuantity = value; }

        }
        decimal _ExistigQuantity;
        public decimal ExistigQuantity
        {

            get { return _ExistigQuantity; }
            set { _ExistigQuantity = value; }

        }
        decimal _LackQuantity;
        public decimal LackQuantity
        {

            get { return _LackQuantity; }
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
            _StocktakingHeadID = 0;
            _ItemID = 0;
            _UnitID = 0;
            _CalculatedQuantity = 0;
            _ExistigQuantity = 0;
            _LackQuantity = 0;

        }
        #endregion

        #region Constructor

        /// <summary>
        /// Initializes all members with the defualt values.
        /// </summary>
        public entStocktakingDetails()
        {
            SetDefaults();
        }
        /// <summary>
        /// Initializes all members with the supplied values.
        /// </summary>
        /// <param name="iID">The ID of the record to load its values to the class memebrs.</param>
        public entStocktakingDetails(int iID)
            : base(iID)
        {
            try
            {
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@ID", iID);
                DataTable tblRow = SqlAdoWrapper.ExecuteQueryCommand("StocktakingDetails_SelectByID", param,
                    false);
                if (tblRow != null && tblRow.Rows.Count > 0)
                {
                    DataRow rowCurr = tblRow.Rows[0];
                    ID = rowCurr["ID"] == DBNull.Value ? 0 : Convert.ToInt32(rowCurr["ID"]);
                    _StocktakingHeadID = rowCurr["StocktakingHeadID"] == DBNull.Value ? 0 : Convert.ToInt32(rowCurr["StocktakingHeadID"]);
                    _ItemID = rowCurr["ItemID"] == DBNull.Value ? 0 : Convert.ToInt32(rowCurr["ItemID"]);
                    _UnitID = rowCurr["UnitID"] == DBNull.Value ? 0 : Convert.ToInt32(rowCurr["UnitID"]);
                    _CalculatedQuantity = rowCurr["CalculatedQuantity"] == DBNull.Value ? 0 : Convert.ToDecimal(rowCurr["CalculatedQuantity"]);
                    _ExistigQuantity = rowCurr["ExistigQuantity"] == DBNull.Value ? 0 : Convert.ToDecimal(rowCurr["ExistigQuantity"]);
                    _LackQuantity = rowCurr["LackQuantity"] == DBNull.Value ? 0 : Convert.ToDecimal(rowCurr["LackQuantity"]);
                }
                else
                    SetDefaults();
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }
        /// <summary>
        /// Initializes all members with the supplied values.
        /// </summary>
        /// <param name="iID">The ID of the record to load its values to the class memebrs.</param>
        public entStocktakingDetails(int iID, SqlTransaction sqltrnSave)
            : base(iID)
        {
            try
            {
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@ID", iID);
                DataTable tblRow = SqlAdoWrapper.ExecuteQueryCommand("StocktakingDetails_SelectByID", param, sqltrnSave, false);
                if (tblRow != null && tblRow.Rows.Count > 0)
                {
                    DataRow rowCurr = tblRow.Rows[0];
                    ID = rowCurr["ID"] == DBNull.Value ? 0 : Convert.ToInt32(rowCurr["ID"]);
                    _StocktakingHeadID = rowCurr["StocktakingHeadID"] == DBNull.Value ? 0 : Convert.ToInt32(rowCurr["StocktakingHeadID"]);
                    _ItemID = rowCurr["ItemID"] == DBNull.Value ? 0 : Convert.ToInt32(rowCurr["ItemID"]);
                    _UnitID = rowCurr["UnitID"] == DBNull.Value ? 0 : Convert.ToInt32(rowCurr["UnitID"]);
                    _CalculatedQuantity = rowCurr["CalculatedQuantity"] == DBNull.Value ? 0 : Convert.ToDecimal(rowCurr["CalculatedQuantity"]);
                    _ExistigQuantity = rowCurr["ExistigQuantity"] == DBNull.Value ? 0 : Convert.ToDecimal(rowCurr["ExistigQuantity"]);
                    _LackQuantity = rowCurr["LackQuantity"] == DBNull.Value ? 0 : Convert.ToDecimal(rowCurr["LackQuantity"]);

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

        public static bool operator ==(entStocktakingDetails lhs, entStocktakingDetails rhs)
        {
            if (
                lhs.ID == rhs.ID
&& lhs._StocktakingHeadID == rhs._StocktakingHeadID
&& lhs._ItemID == rhs._ItemID
&& lhs._UnitID == rhs._UnitID
&& lhs._CalculatedQuantity == rhs._CalculatedQuantity
&& lhs._ExistigQuantity == rhs._ExistigQuantity
&& lhs._LackQuantity == rhs._LackQuantity

                )
                return true;
            else
                return false;
        }
        public static bool operator !=(entStocktakingDetails lhs, entStocktakingDetails rhs)
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