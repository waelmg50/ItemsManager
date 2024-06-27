using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Utilities
{
    /// <summary>
    /// A class for managing all tree operations.
    /// </summary>
    public class TreeManager
    {

        #region Private Methods

        /// <summary>
        /// Checks if the Supplied columns exists in the supplied tables.
        /// </summary>
        /// <param name="dtTables">The tables to check the columns in it.</param>
        /// <param name="IDColumns">The columns to check in the table.</param>
        /// <param name="TextColumns">The columns to check in the table.</param>
        /// <param name="RelationColumns">The columns to check in the table.</param>
        /// <returns>Returns true if all the supoplied columns exist in the tables otherwise it returns false.</returns>
        static bool CheckColumns(DataTable[] dtTables, string[] IDColumns,
            string[] TextColumns, string[] RelationColumns)
        {
            //Check the existance of the first column names in the first table
            if (!SqlAdoWrapper.CheckColumns(dtTables[0], new string[] { IDColumns[0], TextColumns[0] }))
                return false;

            for (int i = 1; i < dtTables.Length; i++)
            {
                //Check the existance of all column names in the corresponding tables.
                if (!SqlAdoWrapper.CheckColumns(dtTables[i], new string[] { IDColumns[i], 
                    TextColumns[i] , RelationColumns[i-1]}))
                {
                    return false;
                }
            }
            return true;
        }

        #endregion

        #region Public Members

        /// <summary>
        /// Creates a tree from a supplied datatables.
        /// </summary>
        /// <param name="tnCarier">The node that carries the required tree.</param>
        /// <param name="dtTreeTables">The set of tables that will fill the tree.</param>
        /// <param name="IDColumns">The set of strings that represents the 
        /// ID Columns of the tables.</param>
        /// <param name="TextColumns">The set of strings that represents the columns names that it's
        /// values will appear in the nodes.</param>
        /// <param name="RelationColumns">The set of strings that represents the columns names
        /// of the relations between the tables.</param>
        /// <param name="ImageIndex">The index of the image that will appear in nodes that represents
        /// the first table of the table collection. The next levels image idexes wil be
        /// lev * 2 where lev is the level of the node.</param>
        /// <param name="SelectedImageIndex">The index of the image that will appear in nodes that 
        /// represents the first table of the table collection when they are selected. The next levels selected 
        /// image idexes wil be (lev * 2) + 1 where lev is the level of the node.</param>
        /// <param name="NodeColor">The color of the text of the added nodes.</param>
        /// <returns>Returns false if error hapens otherwise it returns true.</returns>
        public static bool CreateTree(TreeNode tnCarier, DataTable[] dtTreeTables, string[] IDColumns,
            string[] TextColumns, string[] RelationColumns, int ImageIndex, int SelectedImageIndex
            , System.Drawing.Color NodeColor)
        {
            try
            {
                //If the data table collection is empty then do nothing and return true.
                if (dtTreeTables.Length == 0 || dtTreeTables == null || dtTreeTables[0] == null) return true;
                //Check that the column names are correct for all the tables.
                if (CheckColumns(dtTreeTables, IDColumns, TextColumns, RelationColumns))
                {
                    //Get the child table collection and column names.
                    DataTable[] dtChildTables = new DataTable[dtTreeTables.Length - 1];
                    string[] ChildIDColumns = new string[IDColumns.Length - 1];
                    string[] ChildTextColumns = new string[TextColumns.Length - 1];
                    string[] ChildRelationColumns;
                    if (RelationColumns.Length > 1)
                        ChildRelationColumns = new string[RelationColumns.Length - 1];
                    else
                        ChildRelationColumns = new string[] { string.Empty };
                    //Fill the child table collection tables and column names from the suppplied table collection.
                    for (int TablesIndex = 0; TablesIndex < dtTreeTables.Length - 1; TablesIndex++)
                    {
                        dtChildTables[TablesIndex] = dtTreeTables[TablesIndex + 1].Copy();
                        ChildIDColumns[TablesIndex] = IDColumns[TablesIndex + 1];
                        ChildTextColumns[TablesIndex] = TextColumns[TablesIndex + 1];
                        if (TablesIndex == dtTreeTables.Length - 2) continue;
                        ChildRelationColumns[TablesIndex] = RelationColumns[TablesIndex + 1];
                    }
                    //Loop throw all records in the first table of the table collection.
                    foreach (DataRow drRoot in dtTreeTables[0].Rows)
                    {
                        //Assign the text column value in the record to a tree node and give it an image index.
                        TreeNode tnRoot = new TreeNode(drRoot[TextColumns[0]].ToString(), ImageIndex,
                            SelectedImageIndex);
                        //Assign the ID of the record to the tag of the tree node.
                        tnRoot.Tag = drRoot[IDColumns[0]];
                        //If the user supply a color 
                        if(NodeColor != null)
                            tnRoot.ForeColor = NodeColor;
                        //If we are not in the last level then add the remaining of the tree.
                        if (dtTreeTables.Length > 1)
                        {
                            //Get the child table of the current record in the first table of the table collection.
                            dtChildTables[0] = SqlAdoWrapper.GetChildTable(dtTreeTables[1], tnRoot.Tag,
                               RelationColumns[0]);
                            //Add the child tree to the current node.
                            CreateTree(tnRoot, dtChildTables, ChildIDColumns, ChildTextColumns, ChildRelationColumns,
                                ImageIndex, SelectedImageIndex, NodeColor);
                        }
                        //Add the node to the tree node.
                        tnCarier.Nodes.Add(tnRoot);
                    }
                }
                else
                {
                    //Display a message to the user that the column names are not correct.
                    Helper.ShowMessage(Resources.ProgramMessages.ErrMesTblClms, MessageBoxButtons.OK
                          , MessageBoxIcon.Error);
                    return false;
                }
                //Every thing is done correctly so return true.
                return true;
            }
            catch (Exception e)
            {
                //Display and save any exception occurs from the code.
                ErrorHandler.LogError(e);
                return false;
            }
        }
        /// <summary>
        /// Creates a tree from a recursive data table.
        /// </summary>
        /// <param name="tnCarier">The node that will carry the result.</param>
        /// <param name="dtTreeTable">The data table that carries the data.</param>
        /// <param name="IDColumn">The column that have the primary key of the table.</param>
        /// <param name="TextColumn">Ther column that have the text that will be shown in the nodes.</param>
        /// <param name="RelationColumn">The column that carries the recursive relation.</param>
        /// <param name="ImageIndex">The index of the image that will appear in the nodes.</param>
        /// <param name="SelectedImageIndex">The index of the image that will appear in the selected nodes.</param>
        /// <returns>Returns false if error hapens other wise it returns true.</returns>
        public static bool CreateTreeInRecursiveTable(TreeNode tnCarier, DataTable dtTreeTable, string IDColumn,
            string TextColumn, string RelationColumn, int ImageIndex, int SelectedImageIndex)
        {
            try
            {
                //If the supplied table is empty then do nothing and return true.
                if (dtTreeTable == null || dtTreeTable.Rows.Count == 0) return true;
                //Check that the supplied columns exist in the supplied datatable.
                if (SqlAdoWrapper.CheckColumns(dtTreeTable, new string[] { IDColumn, TextColumn, RelationColumn }))
                {
                    DataTable dtActionTable = new DataTable();
                    //If the tree node have null id then it is the first calling to the function.
                    if (tnCarier.Tag == null)
                    {
                        //Clear the previously added nodes.
                        tnCarier.Nodes.Clear();
                        //Add the columns of the supplied table to the action table (The table that will be added to the tree).
                        foreach (DataColumn dc in dtTreeTable.Columns)
                            dtActionTable.Columns.Add(dc.ColumnName, dc.DataType);
                        //Add the records of the first level only to the action table.
                        foreach (DataRow drSubTable in dtTreeTable.Rows)
                        {
                            //If the relation column value is null then we have a parent record.so we add it to the action table.
                            if (drSubTable[RelationColumn] == DBNull.Value)
                                dtActionTable.ImportRow(drSubTable);
                        }
                    }
                    else
                        //We are not in a first level node so the action table is the child table for the current node.
                        dtActionTable = SqlAdoWrapper.GetChildTable(dtTreeTable, tnCarier.Tag, RelationColumn);
                    //Loop through all the action table rows to add its rows as a nodes for the current parent node.
                    foreach (DataRow drRoot in dtActionTable.Rows)
                    {
                        //Create a tree node that represents the current record in the action table.
                        TreeNode tnRoot = new TreeNode(drRoot[TextColumn].ToString(), ImageIndex,
                            SelectedImageIndex);
                        //Assign the ID of the record to the tag of the tree node.
                        tnRoot.Tag = drRoot[IDColumn];
                        //If the tree table is not finished then add the child tree of the current node.
                        if (dtTreeTable.Rows.Count > 0)
                            CreateTreeInRecursiveTable(tnRoot, dtTreeTable, IDColumn, TextColumn, RelationColumn,
                                ImageIndex, SelectedImageIndex);
                        //Add the current node to the parent tree node.
                        tnCarier.Nodes.Add(tnRoot);
                    }
                }
                else
                {
                    //Display a message to the user that the column names are not correct.
                    Helper.ShowMessage(Resources.ProgramMessages.ErrMesTblClms, MessageBoxButtons.OK
                          , MessageBoxIcon.Error);
                    return false;
                }
                //Every thing is done correctly so return true.
                return true;
            }
            catch (Exception e)
            {
                //Display and save any exception occurs from the code.
                ErrorHandler.LogError(e);
                return false;
            }
        }
        /// <summary>
        /// Creates a tree from a recursive data table.
        /// </summary>
        /// <param name="tvCarier">The tree view control that will carry the result.</param>
        /// <param name="dtTreeTable">The data table that carries the data.</param>
        /// <param name="IDColumn">The column that have the primary key of the table.</param>
        /// <param name="TextColumn">Ther column that have the text that will be shown in the nodes.</param>
        /// <param name="RelationColumn">The column that carries the recursive relation.</param>
        /// <param name="ImageIndex">The index of the image that will appear in the nodes.</param>
        /// <param name="SelectedImageIndex">The index of the image that will appear in the selected nodes.</param>
        /// <returns>Returns false if error hapens other wise it returns true.</returns>
        public static bool CreateTreeInRecursiveTable(TreeView tvCarier, DataTable dtTreeTable, string IDColumn,
            string TextColumn, string RelationColumn, int ImageIndex, int SelectedImageIndex)
        {
            try
            {
                //If the supplied table is empty then do nothing and return true.
                if (dtTreeTable.Rows.Count == 0 || dtTreeTable == null) return true;
                //Check that the supplied columns exist in the supplied datatable.
                if (SqlAdoWrapper.CheckColumns(dtTreeTable, new string[] { IDColumn, TextColumn, RelationColumn }))
                {
                    DataTable dtActionTable = new DataTable();
                    //Clear the previously added nodes.
                    tvCarier.Nodes.Clear();
                    //Add the columns of the supplied table to the action table (The table that will be added to the tree).
                    foreach (DataColumn dc in dtTreeTable.Columns)
                        dtActionTable.Columns.Add(dc.ColumnName, dc.DataType);
                    //Add the records of the first level only to the action table.
                    foreach (DataRow drSubTable in dtTreeTable.Rows)
                    {
                        //If the relation column value is null then we have a parent record.so we add it to the action table.
                        if (drSubTable[RelationColumn] ==DBNull.Value)
                            dtActionTable.ImportRow(drSubTable);
                    }
                    //Loop through all the action table rows to add its rows as a nodes for the current parent node.
                    foreach (DataRow drRoot in dtActionTable.Rows)
                    {
                        //Create a tree node that represents the current row.
                        TreeNode tnRoot = new TreeNode(drRoot[TextColumn].ToString(), ImageIndex,
                            SelectedImageIndex);
                        //Assign the ID of the record to the tag of the tree node.
                        tnRoot.Tag = drRoot[IDColumn];
                        //If the tree table is not finished then add the child tree of the current node.
                        if (dtTreeTable.Rows.Count > 0)
                            CreateTreeInRecursiveTable(tnRoot, dtTreeTable, IDColumn, TextColumn, RelationColumn,
                                    ImageIndex, SelectedImageIndex);
                        //Add the current node to the tree.
                        tvCarier.Nodes.Add(tnRoot);
                    }
                }
                else
                {
                    //Display a message to the user that the column names are not correct.
                    Helper.ShowMessage(Resources.ProgramMessages.ErrMesTblClms, MessageBoxButtons.OK
                          , MessageBoxIcon.Error);
                    return false;
                }
                //Every thing is done correctly so return true.
                return true;
            }
            catch (Exception e)
            {
                //Display and save any exception occurs from the code.
                ErrorHandler.LogError(e);
                return false;
            }
        }
        /// <summary>
        /// Creates a tree from a supplied datatables.
        /// </summary>
        /// <param name="tvCarier">The tree view that will carry the required tree.</param>
        /// <param name="dtTreeTables">The set of tables that will fill the tree.</param>
        /// <param name="IDColumns">The set of strings that represents the 
        /// ID Columns of the tables.</param>
        /// <param name="TextColumns">The set of strings that represents the columns names that it's
        /// values will appear in the nodes.</param>
        /// <param name="RelationColumns">The set of strings that represents the columns names
        /// of the relations between the tables.</param>
        /// <param name="ImageIndex">The index of the image that will appear in nodes that represents
        /// the first table of the table collection. The next levels image idexes wil be
        /// lev * 2 where lev is the level of the node.</param>
        /// <param name="SelectedImageIndex">The index of the image that will appear in nodes that 
        /// represents the first table of the table collection when they are selected. The next levels selected 
        /// image idexes wil be (lev * 2) + 1 where lev is the level of the node.</param>
        /// <returns>False if error hapens otherwise it returns true.</returns>
        public static bool CreateTreeInTreeView(TreeView tvCarier, DataTable[] dtTreeTables, string[] IDColumns,
            string[] TextColumns, string[] RelationColumns, int ImageIndex, int SelectedImageIndex)
        {
            try
            {
                //If the data table collection is empty then do nothing and return true.
                if (dtTreeTables.Length == 0 || dtTreeTables == null || dtTreeTables[0] == null) return true;
                //Check that the column names are correct for all the tables.
                if (CheckColumns(dtTreeTables, IDColumns, TextColumns, RelationColumns))
                {
                    //Get the child table collection and column names.
                    DataTable[] dtChildTables = new DataTable[dtTreeTables.Length - 1];
                    string[] ChildIDColumns = new string[IDColumns.Length - 1];
                    string[] ChildTextColumns = new string[TextColumns.Length - 1];
                    string[] ChildRelationColumns;
                    if (RelationColumns.Length > 1)
                        ChildRelationColumns = new string[RelationColumns.Length - 1];
                    else
                        ChildRelationColumns = new string[] { string.Empty };
                    //Fill the child table collection tables and column names from the suppplied table collection.
                    for (int TablesIndex = 0; TablesIndex < dtTreeTables.Length - 1; TablesIndex++)
                    {
                        dtChildTables[TablesIndex] = dtTreeTables[TablesIndex + 1].Copy();
                        ChildIDColumns[TablesIndex] = IDColumns[TablesIndex + 1];
                        ChildTextColumns[TablesIndex] = TextColumns[TablesIndex + 1];
                        if (TablesIndex == dtTreeTables.Length - 2) continue;
                        ChildRelationColumns[TablesIndex] = RelationColumns[TablesIndex + 1];
                    }
                    //Loop throw all records in the first table of the table collection.
                    foreach (DataRow drRoot in dtTreeTables[0].Rows)
                    {
                        //Assign the text column value in the record to a tree node and give it an image index.
                        TreeNode tnRoot = new TreeNode(drRoot[TextColumns[0]].ToString(), ImageIndex,
                            SelectedImageIndex);
                        //Assign the ID of the record to the tag of the tree node.
                        tnRoot.Tag = drRoot[IDColumns[0]];
                        //If we are not in the last level then add the remaining of the tree.
                        if (dtTreeTables.Length > 1)
                        {
                            //Get the child table of the current record in the first table of the table collection.
                            dtChildTables[0] = SqlAdoWrapper.GetChildTable(dtTreeTables[1], tnRoot.Tag,
                               RelationColumns[0]);
                            //Add the child tree to the current node.
                            CreateTree(tnRoot, dtChildTables, ChildIDColumns, ChildTextColumns, ChildRelationColumns,
                                ImageIndex + 2, SelectedImageIndex + 2, tvCarier.ForeColor);
                        }
                        //Add the node to the tree view control.
                        tvCarier.Nodes.Add(tnRoot);
                    }
                }
                else
                {
                    //Display a message to the user that the column names are not correct.
                    Helper.ShowMessage(Resources.ProgramMessages.ErrMesTblClms, MessageBoxButtons.OK
                          , MessageBoxIcon.Error);
                    return false;
                }
                //Every thing is done correctly so return true.
                return true;
            }
            catch (Exception e)
            {
                //Display and save any exception occurs from the code.
                ErrorHandler.LogError(e);
                return false;
            }
        }
        /// <summary>
        /// Creates a tree from a recursive data table and another related datatable(s).
        /// </summary>
        /// <param name="tvCarier">The tree view control that will carry the result.</param>
        /// <param name="dtTreeTables">The set of tables that will fill the tree.</param>
        /// <param name="IDColumns">The set of strings that represents the 
        /// ID Columns of the tables.</param>
        /// <param name="TextColumns">The set of strings that represents the columns names that it's
        /// values will appear in the nodes.</param>
        /// <param name="RelationColumns">The set of strings that represents the columns names
        /// of the relations between the tables.</param>
        /// <param name="ImageIndex">The index of the image that will appear in nodes that represents
        /// the first table of the table collection. The next levels image idexes wil be
        /// lev * 2 where lev is the level of the node.</param>
        /// <param name="SelectedImageIndex">The index of the image that will appear in nodes that 
        /// represents the first table of the table collection when they are selected. The next levels selected 
        /// image idexes wil be (lev * 2) + 1 where lev is the level of the node.</param>
        /// <returns>Returns false if error hapens other wise it returns true.</returns>
        public static bool CreateTreeFromMultibletableFirstRecursive(TreeNode tnCarier, DataTable[] dtTreeTables, string[] IDColumns,
            string[] TextColumns, string[] RelationColumns, int ImageIndex, int SelectedImageIndex)
        {
            try
            {
                //If the data table collection is empty then do nothing and return true.
                if (dtTreeTables.Length == 0 || dtTreeTables == null || dtTreeTables[0] == null) return true;
                //Check that the column names are correct for all the tables.
                if (CheckColumns(dtTreeTables, IDColumns, TextColumns, RelationColumns))
                {
                    DataTable dtActionTable = new DataTable();
                    //Get the action table as the child table for the current node.
                    dtActionTable = SqlAdoWrapper.GetChildTable(dtTreeTables[0], tnCarier.Tag, RelationColumns[0]);
                    //If we have a child rows in the action table then add it.
                    if (dtActionTable.Rows.Count > 0)
                    {
                        //Loop through all the action table rows to add its rows as a nodes for the current parent node.
                        foreach (DataRow drRoot in dtActionTable.Rows)
                        {
                            //Create a tree node that represents the current record in the action table.
                            TreeNode tnRoot = new TreeNode(drRoot[TextColumns[0]].ToString(), ImageIndex,
                                SelectedImageIndex);
                            //Assign the ID of the record to the tag of the tree node.
                            tnRoot.Tag = drRoot[IDColumns[0]];
                            //If the tree table is not finished then add the child tree of the current node.
                            if (dtTreeTables[0].Rows.Count > 0)
                                CreateTreeFromMultibletableFirstRecursive(tnRoot, dtTreeTables, IDColumns, TextColumns, RelationColumns,
                                        ImageIndex, SelectedImageIndex);
                            //Add the current node to the parent tree node.
                            tnCarier.Nodes.Add(tnRoot);
                        }
                    }
                    //Get the child collection from the second table.
                    //Get the child table collection and column names.
                    DataTable[] dtChildTables = new DataTable[dtTreeTables.Length - 1];
                    string[] ChildIDColumns = new string[IDColumns.Length - 1];
                    string[] ChildTextColumns = new string[TextColumns.Length - 1];
                    string[] ChildRelationColumns;
                    if (RelationColumns.Length > 1)
                        ChildRelationColumns = new string[RelationColumns.Length - 1];
                    else
                        ChildRelationColumns = new string[] { string.Empty };
                    //Fill the child table collection tables and column names from the suppplied table collection.
                    for (int TablesIndex = 0; TablesIndex < dtTreeTables.Length - 1; TablesIndex++)
                    {
                        dtChildTables[TablesIndex] = dtTreeTables[TablesIndex + 1].Copy();
                        ChildIDColumns[TablesIndex] = IDColumns[TablesIndex + 1];
                        ChildTextColumns[TablesIndex] = TextColumns[TablesIndex + 1];
                        if (TablesIndex == dtTreeTables.Length - 1) continue;
                        ChildRelationColumns[TablesIndex] = RelationColumns[TablesIndex + 1];
                    }
                    //If we are not in the last level then add the remaining of the tree.
                    if (dtTreeTables.Length > 1)
                    {
                        //Get the child table of the current record in the first table of the table collection.
                        dtChildTables[0] = SqlAdoWrapper.GetChildTable(dtTreeTables[1], tnCarier.Tag,
                           ChildRelationColumns[0]);
                        //Add the child tree to the current node.
                        CreateTree(tnCarier, dtChildTables, ChildIDColumns, ChildTextColumns, ChildRelationColumns,
                            ImageIndex + 2, SelectedImageIndex + 2, System.Drawing.Color.Red);
                    }
                }
                else
                {
                    //Display a message to the user that the column names are not correct.
                    Helper.ShowMessage(Resources.ProgramMessages.ErrMesTblClms, MessageBoxButtons.OK
                          , MessageBoxIcon.Error);
                    return false;
                }
                //Every thing is done correctly so return true.
                return true;
            }
            catch (Exception e)
            {
                //Display and save any exception occurs from the code.
                ErrorHandler.LogError(e);
                return false;
            }
        }
        /// <summary>
        /// Creates a tree from a recursive data table and another related datatable(s).
        /// </summary>
        /// <param name="tvCarier">The tree view control that will carry the result.</param>
        /// <param name="dtTreeTables">The set of tables that will fill the tree.</param>
        /// <param name="IDColumns">The set of strings that represents the 
        /// ID Columns of the tables.</param>
        /// <param name="TextColumns">The set of strings that represents the columns names that it's
        /// values will appear in the nodes.</param>
        /// <param name="RelationColumns">The set of strings that represents the columns names
        /// of the relations between the tables.</param>
        /// <param name="ImageIndex">The index of the image that will appear in nodes that represents
        /// the first table of the table collection. The next levels image idexes wil be
        /// lev * 2 where lev is the level of the node.</param>
        /// <param name="SelectedImageIndex">The index of the image that will appear in nodes that 
        /// represents the first table of the table collection when they are selected. The next levels selected 
        /// image idexes wil be (lev * 2) + 1 where lev is the level of the node.</param>
        /// <returns>Returns false if error hapens other wise it returns true.</returns>
        public static bool CreateTreeFromMultibletableFirstRecursive(TreeView tvCarier, DataTable[] dtTreeTables, string[] IDColumns,
            string[] TextColumns, string[] RelationColumns, int ImageIndex, int SelectedImageIndex)
        {
            try
            {
                //If the data table collection is empty then do nothing and return true.
                if (dtTreeTables.Length == 0 || dtTreeTables == null || dtTreeTables[0] == null) return true;
                //Check that the column names are correct for all the tables.
                if (CheckColumns(dtTreeTables, IDColumns, TextColumns, RelationColumns))
                {
                    DataTable dtActionTable = new DataTable();
                    //Clear the previously added nodes.
                    tvCarier.Nodes.Clear();
                    //Add the columns of the supplied table to the action table (The table that will be added to the tree).
                    foreach (DataColumn dc in dtTreeTables[0].Columns)
                        dtActionTable.Columns.Add(dc.ColumnName, dc.DataType);
                    //Add the records of the first level only to the action table.
                    foreach (DataRow drSubTable in dtTreeTables[0].Rows)
                    {
                        //If the relation column value is null then we have a parent record.so we add it to the action table.
                        if (drSubTable[RelationColumns[0]] == DBNull.Value)
                            dtActionTable.ImportRow(drSubTable);
                    }
                    //Loop through all the action table rows to add its rows as a nodes for the current parent node.
                    foreach (DataRow drRoot in dtActionTable.Rows)
                    {
                        //Create a tree node that represents the current row.
                        TreeNode tnRoot = new TreeNode(drRoot[TextColumns[0]].ToString(), ImageIndex,
                            SelectedImageIndex);
                        //Assign the ID of the record to the tag of the tree node.
                        tnRoot.Tag = drRoot[IDColumns[0]];
                        //If the tree table is not finished then add the child tree of the current node.
                        if (dtTreeTables[0].Rows.Count > 0)
                            CreateTreeFromMultibletableFirstRecursive(tnRoot, dtTreeTables, IDColumns, TextColumns
                                , RelationColumns, ImageIndex, SelectedImageIndex);
                        //Add the current node to the tree.
                        tvCarier.Nodes.Add(tnRoot);
                    }
                }
                else
                {
                    //Display a message to the user that the column names are not correct.
                    Helper.ShowMessage(Resources.ProgramMessages.ErrMesTblClms, MessageBoxButtons.OK
                          , MessageBoxIcon.Error);
                    return false;
                }
                //Every thing is done correctly so return true.
                return true;
            }
            catch (Exception e)
            {
                //Display and save any exception occurs from the code.
                ErrorHandler.LogError(e);
                return false;
            }
        }
        /// <summary>
        /// Searches for a value of the tag property of a node in a tree node collection and in the subcollections of the
        /// nodes in the collection.
        /// </summary>
        /// <param name="SearchDomain">The tree node collection to search in.</param>
        /// <param name="SearchValue">The value to search for.</param>
        /// <returns>Returns the tree node found in the serach if exists other wise it returns new instance of tree node.
        /// </returns>
        public static TreeNode SearchNodes(TreeNodeCollection SearchDomain, object SearchValue)
        {
            TreeNode tnResult = null;
            foreach (TreeNode SearchNode in SearchDomain)
            {
                //If the tag of the current node equals the value we search for then return the current node.
                if (SearchNode.Tag != null && SearchNode.Tag.ToString() == SearchValue.ToString())
                    return SearchNode;
                else
                {
                    //If the current node is a leaf in the tree then continue to the next node in the collection.
                    if (SearchNode.Nodes.Count == 0)
                        continue;
                    else
                    {
                        //Search for the current value in the collection of nodes of the current node.
                        tnResult = SearchNodes(SearchNode.Nodes, SearchValue);
                        if (tnResult != null)
                            return tnResult;
                    }
                }
            }
            return tnResult;
        }
        /// <summary>
        /// Searches for a value of the tag property of a node in a tree node collection and in the subcollections of the
        /// nodes in the collection in a certain level.
        /// </summary>
        /// <param name="SearchDomain">The tree node collection to search in.</param>
        /// <param name="Level">The required level that the required node is supposed to be in.</param>
        /// <param name="SearchValue">The value to search for.</param>
        public static TreeNode SearchNodes(TreeNodeCollection SearchDomain, int Level, object SearchValue)
        {
            TreeNode tnResult = new TreeNode();
            foreach (TreeNode SearchNode in SearchDomain)
            {
                //If the tag of the current node equals the value we search for then test the level.
                if (SearchNode.Tag.ToString() == SearchValue.ToString())
                {
                    //If the level is correct then return the current node.
                    if (Level == -1 || SearchNode.Level == Level)
                        return SearchNode;
                }
                else
                {
                    //If the current node is a leaf in the tree then continue to the next node in the collection.
                    if (SearchNode.Nodes.Count == 0)
                        continue;
                    else
                    {
                        //Search for the current value in the collection of nodes of the current node.
                        tnResult = SearchNodes(SearchNode.Nodes, Level, SearchValue);
                        if (tnResult != null && tnResult.Text.Length > 0)
                            return tnResult;
                    }
                }
            }
            return tnResult;
        }
        /// <summary>
        /// Gets the depth of the tree in the treeView control.
        /// </summary>
        /// <param name="tvDepth">The tree view to see its depth.</param>
        /// <returns>The depth of the tree in the tree node control.</returns>
        public static int GetTreeDepth(TreeView tvDepth)
        {
            int DepthResult = 0;
            //If the tree view dosen't have node then the depth is zero length.
            if (tvDepth.Nodes.Count == 0)
                return 0;
            else
            {
                //We are in the first level so increase the depth by 1.
                DepthResult++;
                //Loop through all the nodes in the collection to test the depth in all the paths in the tree.
                foreach (TreeNode tnNode in tvDepth.Nodes)
                {
                    if (tnNode.Nodes.Count > 0)
                    {
                        int NodeTreeDepth = 0;
                        //Get the depth of the current node.
                        NodeTreeDepth = GetNodeTreeDepth(tnNode);
                        //If the depth of the node is greater then the current calculated depth then it is the new depth.
                        if (DepthResult < NodeTreeDepth)
                            DepthResult = NodeTreeDepth;
                    }
                }
            }
            //Return the calculated depth.
            return DepthResult;
        }
        /// <summary>
        /// Gets the depth of the tree of the TreeNode.
        /// </summary>
        /// <param name="tnDepthNode">The node to calculate its depth.</param>
        /// <returns>The depth of the the tree of the TreeNode Control.</returns>
        public static int GetNodeTreeDepth(TreeNode tnDepthNode)
        {
            int DepthResult = 0;
            //If the tree node dosen't have node then the depth is zero length.
            if (tnDepthNode.Nodes.Count == 0)
                return 0;
            else
            {
                //We are in the first level so increase the depth by 1.
                DepthResult++;
                //Loop through all the nodes in the collection to test the depth in all the paths in the tree.
                foreach (TreeNode tnNode in tnDepthNode.Nodes)
                {
                    if (tnNode.Nodes.Count > 0)
                    {
                        int NodeTreeDepth = 0;
                        //Get the depth of the current node added by one since the current node is in the inner level of
                        //the current node.
                        NodeTreeDepth = 1 + GetNodeTreeDepth(tnNode);
                        //If the depth of the node is greater then the current calculated depth then it is the new depth.
                        if (DepthResult < NodeTreeDepth)
                            DepthResult = NodeTreeDepth;
                    }
                }
            }
            //Return the calculated depth.
            return DepthResult;
        }
        /// <summary>
        /// Gets the path of the selected node beginning from its parent to the root.
        /// </summary>
        /// <param name="tnPathNode">The selected node to get its path.</param>
        /// <returns>Returns a string list of the path of the selected node beginning from its parent to the root.</returns>
        public static List<string> GetTreeNodePath(TreeNode tnPathNode)
        {
            try
            {
                if (tnPathNode == null || tnPathNode.Parent == null)
                    return null;
                else
                {
                    List<string> strlstPath = new List<string>();
                    strlstPath.Add(tnPathNode.Parent.Text);
                    if (tnPathNode.Parent.Parent == null)
                        return strlstPath;
                    else
                    {
                        List<string> strlstParentPath = GetTreeNodePath(tnPathNode.Parent);
                        strlstPath.AddRange(strlstParentPath);
                        return strlstPath;
                    }
                }
                return null;
            }
            catch (Exception e)
            {
                ErrorHandler.LogError(e);
                return null;
            }
        }
        /// <summary>
        /// Gets the path list of a tree node.
        /// </summary>
        /// <param name="tnPathNode">The tree node to get its path.</param>
        /// <returns>Returns an array of stringrs from the supplied tree node parent to the root of the tree node.</returns>
        public static string[] GetTreeNodePathList(TreeNode tnPathNode)
        {
            try
            {
                List<string> strlstPath = GetTreeNodePath(tnPathNode);
                if (strlstPath == null)
                    return null;
                else
                {
                    string[] strarrPaths = new string[strlstPath.Count];
                    for (int i = strlstPath.Count - 1; i >= 0; i--)
                        strarrPaths[strlstPath.Count - 1 - i] = strlstPath[i];
                    return strarrPaths;
                }
            }
            catch (Exception e)
            {
                ErrorHandler.LogError(e);
                return null;
            }
        }
        /// <summary>
        /// Gets the checked nodes in the supplied tree node collection.
        /// </summary>
        /// <param name="tnCltionCarrier">The tree node collection to get its checked node list.</param>
        /// <returns>Returns a collection of the checked tree nodes.</returns>
        public static List<TreeNode> GetLeafCheckedNodes(TreeNodeCollection tnCltionCarrier)
        {
            try
            {
                List<TreeNode> tncltionResult = new List<TreeNode>();
                if (tnCltionCarrier.Count == 0)
                    return null;
                foreach (TreeNode tnParent in tnCltionCarrier)
                {
                    if (tnParent.Checked)
                    {
                        if (tnParent.Nodes.Count == 0)
                            tncltionResult.Add(tnParent);
                    }
                    List<TreeNode> tncltionChildResult = GetLeafCheckedNodes(tnParent.Nodes);
                    if (tncltionChildResult != null)
                        tncltionResult.AddRange(tncltionChildResult);
                }
                return tncltionResult;
            }
            catch (Exception e)
            {
                ErrorHandler.LogError(e);
                return null;
            }
        }
        /// <summary>
        /// clear the checked nodes in the supplied tree node collection.
        /// </summary>
        /// <param name="tncCheckedNodes">The tree node collection to clear its checked node list.</param>
        public static void ClearCheckedNodes(TreeNodeCollection tncCheckedNodes)
        {
            try
            {
                foreach (TreeNode tnChecked in tncCheckedNodes)
                {
                    if (tnChecked.Checked)
                    {
                        tnChecked.Checked = false;
                    }
                    if (tnChecked.Nodes.Count > 0)
                        ClearCheckedNodes(tnChecked.Nodes);
                }
            }
            catch (Exception e)
            {
                ErrorHandler.LogError(e);
            }
        }
        /// <summary>
        /// Clear the checked nodes in the supplied tree node collection and if dosen't check the childs if the parent was not checked.
        /// </summary>
        /// <param name="tncCheckedNodes">The tree node collection to clear its checked node list.</param>
        public static void ClearCheckedNodesWithParentCheck(TreeNodeCollection tncCheckedNodes)
        {
            try
            {
                foreach (TreeNode tnChecked in tncCheckedNodes)
                {
                    if (tnChecked.Checked)
                    {
                        tnChecked.Checked = false;

                        if (tnChecked.Nodes.Count > 0)
                            ClearCheckedNodes(tnChecked.Nodes);
                    }
                }
            }
            catch (Exception e)
            {
                ErrorHandler.LogError(e);
            }
        }

        #endregion

    }
}