using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utilities;
using System.Data;
using System.Data.SqlClient;

namespace Entities
{
    public class entUnitsConversions : BaseEntity
    {

        #region Table Fields and properties

int _FromUnitID;
public int FromUnitID
{

get { return _FromUnitID;}
set {_FromUnitID = value;}

}
int _ToUnitID;
public int ToUnitID
{

get { return _ToUnitID;}
set {_ToUnitID = value;}

}
decimal _Quantity;
public decimal Quantity
{

get { return _Quantity;}
set {_Quantity = value;}

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
_FromUnitID= 0;
_ToUnitID= 0;
_Quantity= 0;

        }
        #endregion

        #region Constructor

        /// <summary>
        /// Initializes all members with the defualt values.
        /// </summary>
        public entUnitsConversions()
        {
            SetDefaults();
        }
        /// <summary>
        /// Initializes all members with the supplied values.
        /// </summary>
        /// <param name="iID">The ID of the record to load its values to the class memebrs.</param>
        public entUnitsConversions(int iID)
            : base(iID)
        {
            try
            {
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@ID", iID);
                DataTable tblRow = SqlAdoWrapper.ExecuteQueryCommand("UnitsConversions_SelectByID", param,
                    false);
                if (tblRow != null && tblRow.Rows.Count > 0)
                {
                    DataRow rowCurr = tblRow.Rows[0];
                    ID= rowCurr["ID"] == DBNull.Value ?0: Convert.ToInt32(rowCurr["ID"]);
_FromUnitID= rowCurr["FromUnitID"] == DBNull.Value ?0: Convert.ToInt32(rowCurr["FromUnitID"]);
_ToUnitID= rowCurr["ToUnitID"] == DBNull.Value ?0: Convert.ToInt32(rowCurr["ToUnitID"]);
_Quantity= rowCurr["Quantity"] == DBNull.Value ?0: Convert.ToDecimal(rowCurr["Quantity"]);

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

        public static bool operator ==(entUnitsConversions lhs, entUnitsConversions rhs)
        {
            if (
                lhs.ID == rhs.ID
&& lhs._FromUnitID == rhs._FromUnitID
&& lhs._ToUnitID == rhs._ToUnitID
&& lhs._Quantity == rhs._Quantity

                )
                return true;
            else
                return false;
        }
        public static bool operator !=(entUnitsConversions lhs, entUnitsConversions rhs)
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