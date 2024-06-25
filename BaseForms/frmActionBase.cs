using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Utilities;
using Managers;
using Entities;
using CustomControls;

namespace ItemsManager.BaseForms
{
    public partial class frmActionBase : ItemsManager.BaseForms.frmBase
    {

        #region Constructor

        public frmActionBase()
        {
            InitializeComponent();
        }

        #endregion

        #region Public members

        /// <summary>
        /// The current record id.
        /// </summary>
        public int iRecordID = 0;
        /// <summary>
        /// The table that the form deals with.
        /// </summary>
        public string strTableName = string.Empty;
        /// <summary>
        /// A condtion to filter the record set of the source table of the form.
        /// </summary>
        public string strCondtion = string.Empty;
        /// <summary>
        /// A value indicates whether a changes occured or not.
        /// </summary>
        protected bool bChangesOccured = false;
        /// <summary>
        /// The status of the form.
        /// </summary>
        public SystemClasses.Enumerations.FormStatus frmstsStatus = SystemClasses.Enumerations.FormStatus.New;
        /// <summary>
        /// If the form in the delete mode or not.
        /// </summary>
        protected bool bDeleteFlag = false;
        /// <summary>
        /// This option will hide all buttons.
        /// </summary>
        public bool bhideAllwithoutPrint = false;
        /// <summary>
        /// Hides all the navigation buttons and the new button.
        /// </summary>
        public bool bHideNavigationAndNew = false;
        /// <summary>
        /// Hides the buttons of the operations of the database.
        /// </summary>
        public bool bhideDatabaseOperationButtons = false;

        #endregion

        #region Methods

        /// <summary>
        /// Saves the current record according to the form status.
        /// </summary>
        protected virtual void Save()
        {
            try
            {
                if (!DesignMode)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    //Validate the form for errors.
                    if (ValidateForm())
                    {
                        int iSaveResult = 0;
                        //Get the current object from the forms controls.
                        GetObject();
                        //If the form status is new then insert else update.
                        if (frmstsStatus == SystemClasses.Enumerations.FormStatus.New)
                        {
                            //Insert the current data and Get the ID of the inserted record.
                            iSaveResult = InsertData();
                            //Store the id of the record if the insert was successfull in the current record id.
                            if (iSaveResult > 0)
                                iRecordID = iSaveResult;
                        }
                        else
                            //Update the current data and Get the ID of the updated record.
                            iSaveResult = UpdateData();
                        //If the save process was successfull show a message to the user.
                        if (iSaveResult > 0)
                        {
                            Helper.ShowMessage(Resources.ProgramMessages.MesSaveSuccessfull);
                            //Reintialize the form to insert a new record if the  form status is New
                            if (frmstsStatus == SystemClasses.Enumerations.FormStatus.New)
                            {
                                EmptyControls(Controls);
                                SetFocus();
                            }
                        }
                    }
                }
                //LoadUserPermesions();
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
        /// <summary>
        /// Sets the focus at the first control in the form.
        /// </summary>
        protected virtual void SetFocus()
        { }
        /// <summary>
        /// Inserts the current data in the database.
        /// </summary>
        /// <returns>Returns the ID of the inserted record.</returns>
        protected virtual int InsertData()
        {
            return 0;
        }
        /// <summary>
        /// Updates the current record in the database by the current data in the form.
        /// </summary>
        /// <returns>Returns the number of rows affected by the update statement.</returns>
        protected virtual int UpdateData()
        {
            return 0;
        }
        /// <summary>
        /// Initializes the form to insert new record.
        /// </summary>
        protected virtual void AddNew()
        {
            try
            {
                if (!DesignMode)
                {
                    EmptyControls(Controls);
                    frmstsStatus = SystemClasses.Enumerations.FormStatus.New;
                    iRecordID = 0;
                    SetFocus();
                    //LoadUserPermesions();
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }
        /// <summary>
        /// Prints the current record.
        /// </summary>
        protected virtual void Print()
        { }
        /// <summary>
        /// Search in Table.
        /// </summary>
        protected virtual void Search()
        {
            try
            {
                frmSearch frmSrch = new frmSearch(strTableName);
                frmSrch.ShowDialog(this);
                if (frmSrch.SelectedRowID > 0)
                    ChangeCurrentID(frmSrch.SelectedRowID);
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }
        /// <summary>
        /// Deletes the current record.
        /// </summary>
        /// <returns>Returns the number of records affected by tha delete process.</returns>
        protected virtual int Delete()
        {
            Cursor.Current = Cursors.WaitCursor;
            bDeleteFlag = true;
            return 0;
        }
        /// <summary>
        /// Warns the user before deleting the current record.
        /// </summary>
        protected virtual void ButtonDelete()
        {
            try
            {
                if (Helper.ShowMessage(Resources.ProgramMessages.MesDeleteConfirm, MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    if (iRecordID > 0)
                    {
                        int iDeleteRes = Delete();
                        if (iDeleteRes > 0)
                        {
                            EmptyControls(Controls);
                            frmstsStatus = SystemClasses.Enumerations.FormStatus.New;
                            ReInitialize();
                            SetFocus();
                            Helper.ShowMessage(Resources.ProgramMessages.MesDeleteSuccessfull);
                        }
                    }
                    else
                        Helper.ShowMessage(Resources.ProgramMessages.MesChooseRecordToDelete);
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }
        /// <summary>
        /// Re Inializes the current entity class.
        /// </summary>
        protected virtual void ReInitialize()
        { }
        /// <summary>
        /// Changes the current record ID and displays the new record.
        /// </summary>
        /// <param name="iNewRecordID">The ID of the current record to display.</param>
        protected virtual void ChangeCurrentID(int iNewRecordID)
        {
            if (!DesignMode)
            {
                iRecordID = iNewRecordID;
                DisplayObject();
                tsbtnDelete.Visible = tsbtnSave.Visible = !(pnlControls.Tag != null && pnlControls.Tag.ToString() == "1") && !(bhideAllwithoutPrint || bhideDatabaseOperationButtons);
                //LoadUserPermesions();
            }
        }
        /// <summary>
        /// Undo the last action that the user do before saving the data.
        /// </summary>
        protected virtual void Undo()
        {
            try
            {
                if (!DesignMode)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    if (frmstsStatus == SystemClasses.Enumerations.FormStatus.New)
                        EmptyControls(Controls);
                    else if (frmstsStatus == SystemClasses.Enumerations.FormStatus.Update)
                        DisplayObject();
                    //LoadUserPermesions();
                    Cursor.Current = Cursors.Default;
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }
        /// <summary>
        /// Gets the data from the controls of the form to the current entity class.
        /// </summary>
        protected virtual void GetObject()
        {
            //LoadUserPermesions();
        }
        /// <summary>
        /// Displays the data in the current entity class to the controls of the form.
        /// </summary>
        protected virtual void DisplayObject()
        {
            try
            {
                bChangesOccured = false;
                frmstsStatus = SystemClasses.Enumerations.FormStatus.Update;
                if (iRecordID > 0)
                    txtID.Text = iRecordID.ToString();
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }
        /// <summary>
        /// Tests if there is a change in the current data so the user can close the form. If there is unsaved data the program warns the user to save the changes first.
        /// </summary>
        /// <returns>Returns true if there is no unsaved data in the form other wise it returns false.</returns>
        protected virtual bool ValidateClose()
        {
            try
            {
                errprvForm.Clear();
                bool Res = true;
                if (IsFormModified() || bChangesOccured)
                {
                    DialogResult drClose = Helper.ShowMessage(Resources.ProgramMessages.MesExitFormConfirm,
                        MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                    if (drClose == DialogResult.Yes)
                    {
                        if (ValidateForm())
                        {
                            Save();
                            Res = Res && true;
                        }
                        else
                            Res = true;
                    }
                    else if (drClose == DialogResult.Cancel)
                        Res = false;
                    else if (drClose == DialogResult.No)
                        Res = Res && true;
                }
                else
                    Res = true;
                return Res;
            }
            catch (Exception e)
            {
                ErrorHandler.LogError(e);
                return false;
            }
        }
        /// <summary>
        /// Determines if there is any changes occured or not.
        /// </summary>
        /// <returns>returns true if any changes occured otherwise it returns false.</returns>
        protected virtual bool IsFormModified()
        {
            return false;
        }
        /// <summary>
        /// Erases all the data from the controls.
        /// </summary>
        /// <param name="emptControls">The control collection to be erased.</param>
        protected override void EmptyControls(System.Windows.Forms.Control.ControlCollection emptControls)
        {
            base.EmptyControls(emptControls);
            pnlControls.Tag = null;
            tsbtnSave.Enabled = tsbtnDelete.Enabled = true;
        }
        /// <summary>
        /// 
        /// </summary>
        protected virtual void LoadInitialControls()
        { }

        #endregion

        #region Event Handlers

        private void frmActionBase_Load(object sender, EventArgs e)
        {
            try
            {
                if (!DesignMode)
                {
                    //tsbtnDelete.Enabled = frmstsStatus == SystemClasses.Enumerations.FormStatus.Update;
                    tsbtnSave.Enabled = pnlControls.Enabled = tsbtnUndo.Enabled = !(frmstsStatus == SystemClasses.Enumerations.FormStatus.Show);
                    LoadInitialControls();
                    if (frmstsStatus == SystemClasses.Enumerations.FormStatus.New)
                        EmptyControls(Controls);
                    else
                        DisplayObject();
                    //hideAllwithoutPrint = false;
                    if (bhideAllwithoutPrint)
                        tsbtnAddNew.Visible = tsbtnDelete.Visible = tsbtnMoveFirst.Visible = tsbtnMoveLast.Visible
                            = tsbtnMoveNext.Visible = tsbtnMovePrivious.Visible = tsbtnSave.Visible = tsbtnUndo.Visible = false;
                    if (bHideNavigationAndNew)
                        tsbtnAddNew.Visible = tsbtnMoveFirst.Visible = tsbtnMoveLast.Visible = tsbtnMoveNext.Visible = tsbtnMovePrivious.Visible = false;
                    if(!(bHideNavigationAndNew || bhideAllwithoutPrint))
                        tsbtnMoveFirst.Visible = tsbtnMoveLast.Visible = tsbtnMoveNext.Visible = tsbtnMovePrivious.Visible = true;
                    if (bhideDatabaseOperationButtons)
                        tsbtnAddNew.Visible = tsbtnDelete.Visible = tsbtnSave.Visible = tsbtnSearch.Visible = tsbtnUndo.Visible = false;
                    tsbtnMoveFirst.Enabled = tsbtnMovePrivious.Enabled = tsbtnMoveNext.Enabled = tsbtnMoveLast.Enabled = true;
                    SetFocus();
                    RecordsFunctions.AutoComplete(strTableName, "ID", txtID);
                    //LoadUserPermesions();
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }
        private void tsbtnSave_Click(object sender, EventArgs e)
        {
            if (!DesignMode && tsbtnSave.Visible)
                Save();
        }
        private void tsbtnDelete_Click(object sender, EventArgs e)
        {
            if (!DesignMode && tsbtnDelete.Visible)
                ButtonDelete();
        }
        private void tsbtnPrint_Click(object sender, EventArgs e)
        {
            if (!DesignMode && tsbtnPrint.Visible)
                Print();
        }
        private void frmBase_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!bDeleteFlag
                && frmstsStatus != SystemClasses.Enumerations.FormStatus.Show
                && !ValidateClose())
                e.Cancel = true;
        }
        private void tsbtnUndo_Click(object sender, EventArgs e)
        {
            if (!DesignMode && tsbtnUndo.Visible)
                Undo();
        }
        private void tsbtnMoveFirst_Click(object sender, EventArgs e)
        {
            if (!DesignMode && tsbtnMoveLast.Visible)
            {
                //Gest the ID of the last record then display its data.
                ChangeCurrentID(RecordsFunctions.Navigate(RecordsFunctions.Navegations.Last, strTableName, iRecordID, strCondtion));
                //Set the current status of the form to Update.
                frmstsStatus = SystemClasses.Enumerations.FormStatus.Update;
            }
        }
        private void tsbtnMovePrivious_Click(object sender, EventArgs e)
        {
            if (!DesignMode && tsbtnMoveNext.Visible)
            {
                //Gest the ID of the next record then display its data.
                RecordsFunctions.Navegations nvMoveType = RecordsFunctions.Navegations.Next;
                int iNewRecordID = RecordsFunctions.Navigate(nvMoveType, strTableName, iRecordID, strCondtion);
                if (iRecordID > 0 && iNewRecordID == 0)
                {
                    Helper.ShowMessage(Resources.ProgramMessages.MesLastRecord);
                    return;
                }
                if (iRecordID == 0)
                    nvMoveType = RecordsFunctions.Navegations.First;
                ChangeCurrentID(iNewRecordID);
                //Set the current status of the form to Update.
                frmstsStatus = SystemClasses.Enumerations.FormStatus.Update;
            }
        }
        private void tsbtnMoveNext_Click(object sender, EventArgs e)
        {
            if (!DesignMode && tsbtnMovePrivious.Visible)
            {
                //Gest the ID of the previous record then displays its data.
                RecordsFunctions.Navegations nvMoveType = RecordsFunctions.Navegations.Previous;
                int iNewRecordID = RecordsFunctions.Navigate(nvMoveType, strTableName, iRecordID, strCondtion);
                if (iRecordID > 0 && iNewRecordID == 0)
                {
                    Helper.ShowMessage(Resources.ProgramMessages.MesFirstRecord);
                    return;
                }
                if (iRecordID == 0)
                    nvMoveType = RecordsFunctions.Navegations.Last;
                ChangeCurrentID(RecordsFunctions.Navigate(nvMoveType, strTableName, iRecordID, strCondtion));
                //Set the current status of the form to Update.
                frmstsStatus = SystemClasses.Enumerations.FormStatus.Update;
            }
        }
        private void tsbtnMoveLast_Click(object sender, EventArgs e)
        {
            if (!DesignMode && tsbtnMoveFirst.Visible)
            {
                //Gest the ID of the first inserted record then display its data.
                ChangeCurrentID(RecordsFunctions.Navigate(RecordsFunctions.Navegations.First, strTableName, iRecordID, strCondtion));
                //Set the current status of the form to Update.
                frmstsStatus = SystemClasses.Enumerations.FormStatus.Update;
            }
        }
        private void tsbtnAddNew_Click(object sender, EventArgs e)
        {
            if (!DesignMode && tsbtnAddNew.Visible)
                AddNew();
        }
        private void tsbtnHelp_Click(object sender, EventArgs e)
        {
            //if (!DesignMode && tsbtnHelp.Visible)
        }
        private void tsbtnSearch_Click(object sender, EventArgs e)
        {
            if (!DesignMode)
                Search();
        }
        private void txtID_Leave(object sender, EventArgs e)
        {
            try
            {
                if (strTableName.Length > 0 && Helper.CheckNumberInt(txtID.Text))
                {
                    if (RecordsFunctions.IsDataExists(strTableName, "ID", txtID.Text, 0))
                        ChangeCurrentID(Convert.ToInt32(txtID.Text));
                    else
                        txtID.Text = iRecordID.ToString();
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }

        #endregion

    }
}