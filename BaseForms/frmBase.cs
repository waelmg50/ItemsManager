using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Utilities;

namespace ItemsManager.BaseForms
{
    public partial class frmBase : Form
    {

        #region Constructor

        public frmBase()
        {
            InitializeComponent();
        }

        #endregion

        #region Methods

        /// <summary>
        /// Adjusts the tabindex property of the controls.
        /// </summary>
        /// <param name="indxControls">The coolection of controls to be indexed.</param>
        /// <param name="iBeginTabIndex">The begin index for the controls collection.</param>
        /// <returns>Returns the end index of the controls collection.</returns>
        protected int AdjustTabIndexes(System.Windows.Forms.Control.ControlCollection indxControls, int iBeginTabIndex)
        {
            try
            {
                int iEndTabIndex = iBeginTabIndex;
                if (indxControls.Count == 0)
                    return iEndTabIndex;
                Control cntFirstNonIndexedControl = indxControls[0];
                //Get the first non indexed control.
                foreach (Control cntrlNonIndexed in indxControls)
                    if (cntrlNonIndexed.Tag == null || !cntrlNonIndexed.Tag.ToString().Contains("indexed"))
                    {
                        cntFirstNonIndexedControl = cntrlNonIndexed;
                        break;
                    }
                //If the list is totaly indexed then return
                if (cntFirstNonIndexedControl == indxControls[0] && cntFirstNonIndexedControl.Tag != null
                    && cntFirstNonIndexedControl.Tag.ToString().Contains("indexed"))
                    return iEndTabIndex;
                //Sort the controls.
                for (int i = 1; i < indxControls.Count; i++)
                {
                    if (indxControls[i].Tag != null && indxControls[i].Tag.ToString().Contains("indexed"))
                        continue;
                    if (cntFirstNonIndexedControl.Location.Y == indxControls[i].Location.Y)
                    {
                        if (cntFirstNonIndexedControl.Location.X < indxControls[i].Location.X)
                                cntFirstNonIndexedControl = indxControls[i];
                    }
                    if (cntFirstNonIndexedControl.Location.Y > indxControls[i].Location.Y)
                        cntFirstNonIndexedControl = indxControls[i];
                }
                //Return if the minimum control is indexed.
                if (cntFirstNonIndexedControl.Tag != null && cntFirstNonIndexedControl.Tag.ToString().Contains("indexed"))
                    return iBeginTabIndex;
                //Set the index of the control.
                cntFirstNonIndexedControl.TabIndex = iBeginTabIndex;
                //Set the index for the next control.
                iEndTabIndex = iBeginTabIndex + 1;
                //If the control have child controls then index them.
                if (cntFirstNonIndexedControl.Controls.Count > 0)
                    iEndTabIndex = AdjustTabIndexes(cntFirstNonIndexedControl.Controls, iEndTabIndex);
                //Mark the control as indexed.
                if (cntFirstNonIndexedControl.Tag != null)
                    cntFirstNonIndexedControl.Tag = cntFirstNonIndexedControl.Tag.ToString() + "|indexed";
                else
                    cntFirstNonIndexedControl.Tag = "indexed";
                //Sort the rest of the controls collection.
                iEndTabIndex = AdjustTabIndexes(indxControls, iEndTabIndex);
                return iEndTabIndex;
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
                return 0;
            }
        }
        /// <summary>
        /// Empty the controls from it's data.
        /// </summary>
        /// <param name="emptControls">The control colleection to be emptied.</param>
        protected virtual void EmptyControls(ControlCollection emptControls)
        {
            try
            {
                foreach (Control cntEmpt in emptControls)
                {
                    if (cntEmpt is TextBox)
                        ((TextBox)cntEmpt).Text = string.Empty;
                    else if (cntEmpt is ComboBox)
                    {
                        ((ComboBox)cntEmpt).SelectedIndex = -1;
                        ((ComboBox)cntEmpt).Text = string.Empty;
                    }
                    else if (cntEmpt is RadioButton)
                        ((RadioButton)cntEmpt).Checked = false;
                    else if (cntEmpt is CheckBox)
                        ((CheckBox)cntEmpt).Checked = false;
                    else if (cntEmpt is DataGridView)
                    {
                        DataGridView dgvEmpt = ((DataGridView)cntEmpt);
                        if (dgvEmpt.DataSource == null)
                            dgvEmpt.Rows.Clear();
                        else
                            dgvEmpt.DataSource = null;
                    }
                    else if (cntEmpt is Label && cntEmpt.Tag != null && cntEmpt.Tag.ToString().Contains('1'))
                        ((Label)cntEmpt).Text = string.Empty;
                    if (cntEmpt.Controls.Count > 0)
                        EmptyControls(cntEmpt.Controls);
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }
        /// <summary>
        /// Erases all the data from the controls.
        /// </summary>
        /// <param name="emptControls">The control collection to be erased.</param>
        protected virtual void EmptyControls(System.Windows.Forms.Control.ControlCollection emptControls)
        {
            try
            {
                foreach (Control cntEmpt in emptControls)
                {
                    if (cntEmpt is TextBox)
                        ((TextBox)cntEmpt).Text = string.Empty;
                    else if (cntEmpt is ComboBox)
                    {
                        ((ComboBox)cntEmpt).SelectedIndex = -1;
                        ((ComboBox)cntEmpt).Text = string.Empty;
                    }
                    else if (cntEmpt is MaskedTextBox)
                        ((MaskedTextBox)cntEmpt).Text = string.Empty;
                    else if (cntEmpt is RadioButton)
                        ((RadioButton)cntEmpt).Checked = false;
                    else if (cntEmpt is CheckBox)
                        ((CheckBox)cntEmpt).Checked = false;
                    else if (cntEmpt is DataGridView)
                    {
                        DataGridView dgvEmpt = ((DataGridView)cntEmpt);
                        if (dgvEmpt.DataSource == null && dgvEmpt.Rows.Count > 0)
                            dgvEmpt.Rows.Clear();
                        else
                            if (dgvEmpt.Rows.Count > 0)
                                ClearGridViewSource(dgvEmpt.DataSource);
                    }
                    else if (cntEmpt is Label && cntEmpt.Tag != null && cntEmpt.Tag.ToString().Contains('1'))
                        ((Label)cntEmpt).Text = string.Empty;
                    else if (cntEmpt is CustomControls.ucTreeViewComboBox)
                        ((CustomControls.ucTreeViewComboBox)cntEmpt).SelectedValue = null;
                    if (cntEmpt.Controls.Count > 0)
                        EmptyControls(cntEmpt.Controls);
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }
        /// <summary>
        /// Validates the controls of the form.
        /// </summary>
        /// <returns>Returns true if all the data are valid, other wise ot returns false.</returns>
        protected virtual bool ValidateForm()
        {
            errprvForm.Clear();
            return ValidateControls(Controls);
        }
        /// <summary>
        /// Validate if the required controls are empty or not.
        /// </summary>
        /// <param name="vldtControls">The controls collection to be validated.</param>
        /// <returns>Returns true if all the required controls are not empty other wise it returns false.</returns>
        bool ValidateControls(System.Windows.Forms.Control.ControlCollection vldtControls)
        {
            bool Res = true;
            foreach (Control cntIsEmpty in vldtControls)
            {
                if (cntIsEmpty.Visible && cntIsEmpty.Tag != null && cntIsEmpty.Tag.ToString().Contains('1'))
                {
                    if ((cntIsEmpty is TextBox && ((TextBox)cntIsEmpty).Text == string.Empty)
                        || (cntIsEmpty is ComboBox && ((ComboBox)cntIsEmpty).Text == string.Empty)
                        || (cntIsEmpty is CustomControls.ucTreeViewComboBox && ((CustomControls.ucTreeViewComboBox)cntIsEmpty).SelectedValue == null))
                    {
                        errprvForm.SetError(cntIsEmpty, Resources.ProgramMessages.MesEnterField);
                        Res = false;
                    }
                }
                if (cntIsEmpty.Visible && cntIsEmpty.Controls.Count > 0)
                    Res = Res && ValidateControls(cntIsEmpty.Controls);
            }
            return Res;
        }
        /// <summary>
        /// Validate if the required controls are empty or not.
        /// </summary>
        /// <param name="vldtControls">The controls collection to be validated.</param>
        /// <returns>Returns true if all the required controls are not empty other wise it returns false.</returns>
        bool ValidateControls(ControlCollection vldtControls)
        {
            try
            {
                bool Res = true;
                foreach (Control cntIsEmpty in vldtControls)
                {
                    if (cntIsEmpty.Tag != null && cntIsEmpty.Tag.ToString() == "1")
                    {
                        if ((cntIsEmpty is TextBox && ((TextBox)cntIsEmpty).Text == string.Empty)
                            || (cntIsEmpty is ComboBox && ((ComboBox)cntIsEmpty).Text == string.Empty)
                            || (cntIsEmpty is CustomControls.ucTreeViewComboBox
                            && ((CustomControls.ucTreeViewComboBox)cntIsEmpty).SelectedValue == null))
                        {
                            errprvForm.SetError(cntIsEmpty, Resources.ProgramMessages.MesEnterField);
                            Res = false;
                        }
                    }
                    if (cntIsEmpty.Controls.Count > 0)
                        Res = Res && ValidateControls(cntIsEmpty.Controls);
                }
                return Res;
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
                return false;
            }
        }
        void ClearGridViewSource(object objDataGridViewSource)
        {
            try
            {
                if (objDataGridViewSource is DataTable)
                    ((DataTable)objDataGridViewSource).Rows.Clear();
                else if (objDataGridViewSource is BindingSource)
                    ((BindingSource)objDataGridViewSource).Clear();
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }

        #endregion

        #region Event Handlers

        private void frmBase_Load(object sender, EventArgs e)
        {
            //Don't run the code in the design mode.
            if (!DesignMode)
            {
                AdjustTabIndexes(Controls, 0);
                //Insert the current user opened the current form.
                //if (DBConnection.CompanyConnection.State == ConnectionState.Open)
                //    Managers.mngrModificationHistory.Insert(Entities.Enume.Enumerations.RecordOperations.OpenForm, "P", "Open Form",
                //Name.Substring(3));
                InputLanguage.CurrentInputLanguage = Helper.GetInputLanguage("ar");
                if (UserLogin.LoggedUserID > 0)
                    Text += " - " + RecordsFunctions.GetNameUsingID("Users", "FullName", UserLogin.LoggedUserID);
            }
            if (errprvForm != null)
                errprvForm.Clear();
        }
        private void frmBase_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!DesignMode)
            {
                //Insert the Current user closed the current form.
                //if (DBConnection.CompanyConnection.State == ConnectionState.Open)
                //    Managers.mngrModificationHistory.Insert(Entities.Enume.Enumerations.RecordOperations.CloseForm, "S", "Close Form", Name.Substring(3));
            }
        }
        private void frmBase_InputLanguageChanging(object sender, InputLanguageChangingEventArgs e)
        {
            //if (ActiveControl is CustomControls.LanguageTextBox)
            //{
            //    if ((((CustomControls.LanguageTextBox)ActiveControl).IsArabic && !e.Culture.Name.Contains("ar"))
            //        || (!((CustomControls.LanguageTextBox)ActiveControl).IsArabic && !e.Culture.Name.Contains("en")))
            //    {
            //        Helper.ShowMessage(Resources.ProgramMessages.MesUseSuitableLanguage);
            //        e.Cancel = true;
            //    }
            //}
        }
        private void frmBase_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                    SendKeys.Send("{" + Keys.Tab.ToString() + "}");
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }

        #endregion

    }
}
