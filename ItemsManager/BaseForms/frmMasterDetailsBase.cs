using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Utilities;

namespace ItemsManager.BaseForms
{
    public partial class frmMasterDetailsBase : frmActionBase
    {

        #region Constructor

        public frmMasterDetailsBase()
        {
            InitializeComponent();
        }

        #endregion

        #region Members

        /// <summary>
        /// The data source of the details grid.
        /// </summary>
        protected DataTable tblDetails = new DataTable();
        /// <summary>
        /// The current Record ID of the details.
        /// </summary>
        protected int iDetailsID = 0;
        /// <summary>
        /// A list contains the deleted records from the grid of the detials.
        /// </summary>
        protected List<int> ilstRemovedDetailsID = new List<int>();
        /// <summary>
        /// A transaction to save all the data in it so if one record failed to be saved all the changes will be rolled back.
        /// </summary>
        protected SqlTransaction sqltrnSave;

        #endregion

        #region Virtual Methods

        protected virtual bool CheckBeforeSave()
        {
            return true;
        }
        /// <summary>
        /// Tests if there is No Changes in the current data or not.
        /// </summary>
        /// <returns>Returns true if no changes happened other wise it returns false.</returns>
        protected virtual bool NoChangesOccured()
        {
            return !IsFormModified();
        }
        /// <summary>
        /// Saves the details of the from.
        /// </summary>
        /// <returns>Returns true if all the details saved successfully. Other wise it returns false.</returns>
        protected virtual bool SaveDetails()
        {
            try
            {
                int iSavedRes = 0;
                //Delete the deleted details.
                foreach (int iDetailsID in ilstRemovedDetailsID)
                {
                    iSavedRes = DeleteDetails(iDetailsID);
                    //If any problem occured return false.
                    if (iSavedRes <= 0)
                        return false;
                }
                //Insert and update the data in the grid.
                iSavedRes = InsertUpdateDetails();
                //If any problem occured return false.
                if (iSavedRes <= 0)
                    return false;
                //Operation was successfull so return true.
                return true;
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
                return false;
            }
        }
        /// <summary>
        /// Deletes a single record in the details.
        /// </summary>
        /// <param name="iDetailID">The ID of the record to be deleted.</param>
        /// <returns>Returns the number of rows affected by the delete operation.</returns>
        protected virtual int DeleteDetails(int iDetailID)
        {
            return 0;
        }
        /// <summary>
        /// Inserts and Updates the data of the details.
        /// </summary>
        /// <returns>Returns the number of rows affected by the last inserted record in the details.</returns>
        protected virtual int InsertUpdateDetails()
        {
            try
            {
                int iRes = 0;
                foreach (DataRow dRowDetails in tblDetails.Rows)
                {
                    iRes = SaveDetails(dRowDetails);
                    if (iRes <= 0)
                        return iRes;
                }
                return 1;
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
                return 0;
            }
        }
        /// <summary>
        /// After Clearing Controls reload the datagrids.
        /// </summary>
        protected override void AddNew()
        {
            base.AddNew();
            LoadGrid();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dRowDetial"></param>
        /// <returns></returns>
        protected virtual int SaveDetails(DataRow dRowDetial)
        {
            return 0;
        }
        /// <summary>
        /// Saves the data of the master record and the details record in one transaction.
        /// </summary>
        protected override void Save()
        {
            try
            {
                //Validate the form.
                if (ValidateForm())
                {
                    Cursor.Current = Cursors.WaitCursor;
                    int iSaveResult = 0;
                    //Get the master recrd data.
                    GetObject();
                    //Begin the transaction.
                    string strTransactionName = "Save" + strTableName;
                    if (strTransactionName.Length > 30)
                        strTransactionName = strTransactionName.Substring(0, 30);
                    sqltrnSave = DBConnection.Connection.BeginTransaction(strTransactionName);
                    if (!CheckBeforeSave())
                    {
                        if (sqltrnSave.Connection != null)
                            sqltrnSave.Rollback();
                        Helper.ShowMessage(Resources.ProgramMessages.MesDataNotSaved);
                        return;
                    }
                    //Save the data of the master record according to the form status.
                    if (frmstsStatus == SystemClasses.Enumerations.FormStatus.New)
                    {
                        iSaveResult = InsertData();
                        //If error occured roll back all the operations done by the transaction.
                        if (iSaveResult > 0)
                            iRecordID = iSaveResult;
                        else
                        {
                            if (sqltrnSave.Connection != null)
                                sqltrnSave.Rollback();
                            return;
                        }
                    }
                    else
                    {
                        iSaveResult = UpdateData();
                        if (iSaveResult <= 0)
                        {
                            if (sqltrnSave.Connection != null)
                                sqltrnSave.Rollback();
                            return;
                        }
                    }
                    //If the details saved successfully display a message to the user.
                    if (SaveDetails())
                    {
                        //End the transaction to save the data and release the tables in the database.
                        sqltrnSave.Commit();
                        if (iSaveResult > 0)
                        {
                            //Display a message of the successfull save.
                            Helper.ShowMessage(Resources.ProgramMessages.MesSaveSuccessfull);
                            //Inialize the form to insert new record if the current form status is New.
                            if (frmstsStatus == SystemClasses.Enumerations.FormStatus.New)
                            {
                                EmptyControls(Controls);
                                //Clears the details rows.
                                tblDetails.Rows.Clear();
                                AddNew();
                                SetFocus();
                                iRecordID = 0;
                            }
                            bChangesOccured = false;
                        }
                    }
                    else
                    {
                        //The data of the details is not saved so roll back the transaction.
                        if (sqltrnSave.Connection != null)
                            sqltrnSave.Rollback();
                        return;
                    }
                    //After the operation is completed load the grid.
                    LoadGrid();
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
                if (sqltrnSave.Connection != null)
                    sqltrnSave.Rollback();
                return;
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
        /// <summary>
        /// Empty the controls of the form and the deleted list.
        /// </summary>
        /// <param name="emptControls">The control collection to delete</param>
        protected override void  EmptyControls(Control.ControlCollection emptControls)
        {
            base.EmptyControls(emptControls);
            if (ilstRemovedDetailsID.Count > 0)
                ilstRemovedDetailsID.Clear();
        }
        
        #region On Load Functions

        /// <summary>
        /// Loads the data of the details of the current record to the grid.
        /// </summary>
        protected virtual void LoadGrid()
        { }
        /// <summary>
        /// Loads all the required data to the corresponding controls.
        /// </summary>
        protected virtual void LoadData()
        {
            LoadGrid();
        }

        #endregion

        #endregion

        #region Event Handlers

        private void frmMasterDetailsBase_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
                LoadData();
        }

        #endregion

    }
}
