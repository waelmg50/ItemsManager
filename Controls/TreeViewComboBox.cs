using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Utilities;

namespace CustomControls
{

    [DefaultEvent("AfterSelect")]
    public partial class ucTreeViewComboBox : UserControl
    {

        #region Auto Generated Code

        public ucTreeViewComboBox()
        {
            InitializeComponent();
        }

        #endregion

        #region Private Members

        Directions drctnDirection = Directions.rtl;
        int iSelectionLevel = -1;
        object objSelectedValue = new object();
        DataTable[] dtarrDataSources;
        string[] strarrPrimaryKeyMemebers;
        string[] strarrDisplayMembers;
        string[] strarrRelationMembers;
        bool bFirstClick = true;
        bool bRecursiveTable = true;

        #region AfterSelectEvents

        public delegate void AfterSelectHandler(object sender, EventArgs e);
        [Category("Action")]
        [Description("Fires After an item is selected from the tree view.")]
        public event AfterSelectHandler AfterSelect;

        #endregion

        #endregion

        #region Enumerations

        public enum Directions
        {
            rtl = 0,
            ltr = 1
        }

        #endregion

        #region Properties

        /// <summary>
        /// Spicefies the direction of the control. "rtl" for right to left direction
        /// and "ltr" for left to right direction.
        /// </summary>
        public Directions Direction
        {
            get
            {
                return drctnDirection;
            }
            set
            {
                try
                {
                    if (value == Directions.rtl)
                    {
                        drctnDirection = value;
                        //imgComboButton.Dock = DockStyle.Left;
                        btnExDropDown.Dock = DockStyle.Left;
                        textBox.TextAlign = HorizontalAlignment.Left;
                        textBox.RightToLeft = RightToLeft.Yes;
                        treeviewList.RightToLeft = RightToLeft.Yes;
                        treeviewList.RightToLeftLayout = true;
                    }
                    else
                    {
                        if (value == Directions.ltr)
                        {
                            drctnDirection = value;
                            //imgComboButton.Dock = DockStyle.Right;
                            btnExDropDown.Dock = DockStyle.Right;
                            textBox.TextAlign = HorizontalAlignment.Right;
                            textBox.RightToLeft = RightToLeft.No;
                            treeviewList.RightToLeft = RightToLeft.No;
                            treeviewList.RightToLeftLayout = false;
                        }
                        else
                        {
                            ErrorHandler.LogError("This Control only takes \"rtl\" and \"ltr\" For the "
                                + "direction property");
                        }
                    }
                }
                catch (Exception ex)
                {
                    ErrorHandler.LogError(ex);
                }
            } 
        }
        /// <summary>
        /// Gets or sets the level of the node that will select the tree view list to select the node at any level set
        /// the selection level to -1.
        /// </summary>
        public int SelectionLevel
        {
            get
            {
                return iSelectionLevel;
            }
            set
            {
                try
                {
                    if (value <= TreeManager.GetTreeDepth(treeviewList))
                    {
                        btnExDropDown.Enabled = true;
                        if (value >= -1)
                        {
                            iSelectionLevel = value;
                        }
                        else
                        {
                            ErrorHandler.LogError("The selection level must be >= -1");
                        }
                    }
                    else
                    {
                        btnExDropDown.Enabled = false;
                        ErrorHandler.LogError("The selection level must be less than the level of "
                        + "the treeviewList see if you loaded the control before setting the Datasources all the related"
                        + "sources of the treeviewList");
                    }
                }
                catch (Exception ex)
                {
                    ErrorHandler.LogError(ex);
                }
            }
        }
        /// <summary>
        /// Gets or sets the selected node with the supplied value.
        /// </summary>
        public object SelectedValue
        {
            get
            {
                return objSelectedValue;
            }
            set
            {
                try
                {
                    if (value == null || value.ToString().Trim().Length == 0)
                    {
                        treeviewList.CollapseAll();
                        treeviewList.SelectedNode = null;
                        textBox.Text = string.Empty;
                        
                    }
                    else
                    {
                        TreeNode tnSelected = TreeManager.SearchNodes(treeviewList.Nodes, iSelectionLevel, value);
                        treeviewList.CollapseAll();
                        if (tnSelected != null)
                        {
                            objSelectedValue = tnSelected.Tag;
                            OnAfterSelect(null);
                            treeviewList.SelectedNode = tnSelected;
                            textBox.Text = tnSelected.Text;
                        }
                    }
                    objSelectedValue = value;
                    if (treeviewList.Visible)
                    {
                        if (Height >= (pnlControls.Height + treeviewList.Height))
                            Height -= treeviewList.Height;
                        treeviewList.Visible = false;
                    }
                }
                catch (Exception ex)
                {
                    ErrorHandler.LogError(ex);
                }
            }
        }
        /// <summary>
        /// Gets the path of the selected node in a string array from the root node to the selected node.
        /// </summary>
        public string[] SelectedPath
        {
            get
            {
                try
                {
                    if (!DesignMode && treeviewList.SelectedNode != null)
                            return TreeManager.GetTreeNodePathList(treeviewList.SelectedNode);
                    return null;
                }
                catch (Exception e)
                {
                    ErrorHandler.LogError(e);
                    return null;
                }
            }
        }
        /// <summary>
        /// Sets the data tables that will be loaded to the tree view of the control.
        /// </summary>
        public DataTable[] DataSources
        {
            set
            {
                try
                {
                    dtarrDataSources = value;
                    if (dtarrDataSources != null && strarrPrimaryKeyMemebers != null && strarrDisplayMembers != null &&
                  strarrRelationMembers != null)
                        LoadTree(dtarrDataSources, strarrPrimaryKeyMemebers, strarrDisplayMembers, strarrRelationMembers);
                }
                catch (Exception ex)
                {
                    ErrorHandler.LogError(ex);
                }
            }
        }
        /// <summary>
        /// Sets the names of the columns that are the primarykey columns of the datatables in the data source.
        /// </summary>
        public string[] PrimaryKeyMemebers
        {
            set
            {
                try
                {
                    strarrPrimaryKeyMemebers = value;
                    if (dtarrDataSources != null && strarrPrimaryKeyMemebers != null && strarrDisplayMembers != null &&
                  strarrRelationMembers != null)
                        LoadTree(dtarrDataSources, strarrPrimaryKeyMemebers, strarrDisplayMembers, strarrRelationMembers);
                }
                catch (Exception ex)
                {
                    ErrorHandler.LogError(ex);
                }
            }
        }
        /// <summary>
        /// Sets the names of the columns in the datatables in the data source that will appear in the text of the tree 
        /// nodes in the treeviewList.
        /// </summary>
        public string[] DisplayMembers
        {
            set
            {
                try
                {
                    strarrDisplayMembers = value;
                    if (dtarrDataSources != null && strarrPrimaryKeyMemebers != null && strarrDisplayMembers != null &&
                  strarrRelationMembers != null)
                        LoadTree(dtarrDataSources, strarrPrimaryKeyMemebers, strarrDisplayMembers, strarrRelationMembers);
                }
                catch (Exception ex)
                {
                    ErrorHandler.LogError(ex);
                }
            }
        }
        /// <summary>
        /// Sets the names of the columns that are the relation ship columns between the datatables in the data source.
        /// </summary>
        public string[] RelationMembers
        {
            set
            {
                try
                {
                    strarrRelationMembers = value;
                    if (dtarrDataSources != null && strarrPrimaryKeyMemebers != null && strarrDisplayMembers != null &&
                        strarrRelationMembers != null)
                        LoadTree(dtarrDataSources, strarrPrimaryKeyMemebers, strarrDisplayMembers, strarrRelationMembers);
                }
                catch (Exception ex)
                {
                    ErrorHandler.LogError(ex);
                }
            }
        }
        /// <summary>
        /// Gets or sets a value indicateing the tree of the control is from recursive table or multiple tables.
        /// </summary>
        public bool RecursiveTable
        {
            get
            {
                return bRecursiveTable;
            }
            set
            {
                bRecursiveTable = value;
            }
        }

        #endregion

        #region Event Handlers

        private void imgComboButton_Click(object sender, EventArgs e)
        {
            try
            {
                int ControlsHeight = pnlControls.Height;
                if (treeviewList.Visible)
                {
                    if (Height >= (pnlControls.Height + treeviewList.Height))
                        Height -= treeviewList.Height;
                    treeviewList.Visible = false;
                }
                else
                {
                    pnlControls.Height = ControlsHeight;
                    if (Height <= (pnlControls.Height + treeviewList.Height))
                        Height += treeviewList.Height;
                    treeviewList.Visible = true;
                }
                bFirstClick = !bFirstClick;
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }
        private void ucTreeViewComboBox_Load(object sender, EventArgs e)
        {
            try
            {
                if (dtarrDataSources != null && strarrPrimaryKeyMemebers != null && strarrDisplayMembers != null &&
                  strarrRelationMembers != null)
                    LoadTree(dtarrDataSources, strarrPrimaryKeyMemebers, strarrDisplayMembers, strarrRelationMembers);
                BringToFront();
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }
        private void treeviewList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (treeviewList.SelectedNode != null && (iSelectionLevel == -1 || treeviewList.SelectedNode.Level == SelectionLevel))
                    ShowSelection();
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }
        private void imgComboButton_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                int ControlsHeight = pnlControls.Height;
                SelectedValue = null;
                if (treeviewList.Visible)
                {
                    if (Height >= (pnlControls.Height))
                        Height -= treeviewList.Height;
                    treeviewList.Visible = false;
                    pnlControls.Height = ControlsHeight;
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }
        private void ucTreeViewComboBox_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                //int ControlsHeight = pnlControls.Height;
                //if (treeviewList.Visible)
                //{
                //    if (Height >= (pnlControls.Height))
                //        Height -= treeviewList.Height;
                //    treeviewList.Visible = false;
                //    pnlControls.Height = ControlsHeight;
                //}
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }
        private void ucTreeViewComboBox_SizeChanged(object sender, EventArgs e)
        {
            if (Height < 21)
                Height = 21;
        }

        #endregion

        #region Private Functions

        /// <summary>
        /// Shows the selected node text in the text box control.
        /// </summary>
        void ShowSelection()
        {
            try
            {
                textBox.Text = treeviewList.SelectedNode.Text;
                objSelectedValue = treeviewList.SelectedNode.Tag;
                OnAfterSelect(null);
                if (Height >= (pnlControls.Height))
                    Height -= treeviewList.Height;
                treeviewList.Visible = false;
                bFirstClick = true;
            }
            catch (Exception e)
            {
                ErrorHandler.LogError(e);
            }
        }
        /// <summary>
        /// Fills the tree of the treeviewComboBox.
        /// </summary>
        /// <param name="dtTreeTables">The set of tables that will fill the tree.</param>
        /// <param name="IDColumns">The set of strings that represents the 
        /// ID Columns of the tables.</param>
        /// <param name="TextColumns">The set of strings that represents the columns names that it's
        /// values will appear in the nodes.</param>
        /// <param name="RelationColumns">The set of strings that represents the columns names
        /// of the relations between the tables.</param>
        void LoadTree(DataTable[] dtTreeTables, string[] IDColumns,
            string[] TextColumns, string[] RelationColumns)
        {
            try
            {
                if (bRecursiveTable)
                    if (dtTreeTables.Length > 0 && IDColumns.Length > 0 && TextColumns.Length > 0 && RelationColumns.Length > 0)
                        btnExDropDown.Enabled = TreeManager.CreateTreeInRecursiveTable(treeviewList, dtTreeTables[0], IDColumns[0],
                        TextColumns[0], RelationColumns[0], 0, 1);
                    else
                        btnExDropDown.Enabled = TreeManager.CreateTreeInTreeView(treeviewList, dtTreeTables, IDColumns,
                            TextColumns, RelationColumns, 0, 1);
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }
        /// <summary>
        /// call After select event
        /// </summary>
        /// <param name="e">The Event Argument to send.</param>
        void OnAfterSelect(System.EventArgs e)
        {
            if (AfterSelect != null)
            {
                AfterSelect(this, e);
            }
        }

        #endregion

    }
}
