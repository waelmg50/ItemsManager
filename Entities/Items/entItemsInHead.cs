using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utilities;
using System.Data;
using System.Data.SqlClient;

namespace Entities
{
    public class entItemsInHead : BaseEntity
    {

        #region Table Fields and properties

        int _ShiftID;
        public int ShiftID
        {
            get { return _ShiftID; }
            set { _ShiftID = value; }
        }
        DateTime _InDate;
        public DateTime InDate
        {
            get { return _InDate; }
            set { _InDate = value; }
        }
        int _InsertUserID;
        public int InsertUserID
        {
            get { return _InsertUserID; }
            set { _InsertUserID = value; }
        }
        int _SupplierID;
        public int SupplierID
        {
            get { return _SupplierID; }
            set { _SupplierID = value; }
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
            _InDate = DateTime.MinValue;
            _InsertUserID = 0;
            _SupplierID = 0;
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes all members with the defualt values.
        /// </summary>
        public entItemsInHead()
        {
            SetDefaults();
        }
        /// <summary>
        /// Initializes all members with the supplied values.
        /// </summary>
        /// <param name="iID">The ID of the record to load its values to the class memebrs.</param>
        public entItemsInHead(int iID)
            : base(iID)
        {
            try
            {
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@ID", iID);
                DataTable tblRow = SqlAdoWrapper.ExecuteQueryCommand("ItemsInHead_SelectByID", param,
                    false);
                if (tblRow != null && tblRow.Rows.Count > 0)
                {
                    DataRow rowCurr = tblRow.Rows[0];
                    ID = rowCurr["ID"] == DBNull.Value ? 0 : Convert.ToInt32(rowCurr["ID"]);
                    _ShiftID = rowCurr["ShiftID"] == DBNull.Value ? 0 : Convert.ToInt32(rowCurr["ShiftID"]);
                    _InDate = rowCurr["InDate"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(rowCurr["InDate"]);
                    _InsertUserID = rowCurr["InsertUserID"] == DBNull.Value ? 0 : Convert.ToInt32(rowCurr["InsertUserID"]);
                    _SupplierID = rowCurr["SupplierID"] == DBNull.Value ? 0 : Convert.ToInt32(rowCurr["SupplierID"]);
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

    }
}