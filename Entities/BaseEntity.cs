using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class BaseEntity
    {

        #region Table Fields

        int _ID;
        int _UserID;

        #endregion

        #region Public Properties

        /// <summary>
        /// The ID of the record.
        /// </summary>
        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        /// <summary>
        /// The Current User ID to store it with the current operation.
        /// </summary>
        public int UserID
        {
            get { return _UserID; }
            set { _UserID = value; }
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes all members with the defualt values.
        /// </summary>
        public BaseEntity()
        {
            _ID = 0;
            _UserID = Utilities.UserLogin.LoggedUserID;
        }
        /// <summary>
        /// Initializes all members with the supplied values.
        /// </summary>
        /// <param name="iID">The ID of the record to load its values to the class memebrs.</param>
        public BaseEntity(int iID)
        {
            _ID = iID;
            _UserID = Utilities.UserLogin.LoggedUserID;
        }

        #endregion

        #region Private Methos

        /// <summary>
        /// Set the defualt values of the class members
        /// </summary>
        protected virtual void SetDefaults()
        {
            _ID = 0;
        }

        #endregion

    }
}