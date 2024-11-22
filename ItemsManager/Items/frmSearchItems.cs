using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Utilities;

namespace ItemsManager.Items
{
    public partial class frmSearchItems : ItemsManager.BaseForms.frmBase
    {

        #region Members

        public int ItemID, CategoryID;

        #endregion

        #region Constructor

        public frmSearchItems()
        {
            InitializeComponent();
        }

        #endregion

        #region Events Handlers

        private void dgvItemUnits_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dgvItems.SelectedRows.Count > 0)
                {
                    ItemID = Convert.ToInt32(dgvItems.SelectedRows[0].Cells["dgtxtcItemID"].Value);
                    CategoryID = Convert.ToInt32(dgvItems.SelectedRows[0].Cells["dgtxtcCategoryID"].Value);
                    Close();
                }
                else
                    Helper.ShowMessage("اختر صنف أولاً");
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }

        private void txtKeyWord_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(null, null);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                dgvItems.DataSource = Managers.mngrItems.GetItemsByKeyWord(txtKeyWord.Text);
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
            Cursor.Current = Cursors.Arrow;
        }

        private void frmSearchItems_Load(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                dgvItems.DataSource = Managers.mngrItems.GetItemsByKeyWord(string.Empty);
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
            Cursor.Current = Cursors.Arrow;
        }

        #endregion

    }
}
