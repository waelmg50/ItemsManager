namespace ItemsManager.BaseForms
{
    partial class frmActionBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmActionBase));
            this.bnToolBar = new System.Windows.Forms.BindingNavigator(this.components);
            this.tsbtnMoveLast = new System.Windows.Forms.ToolStripButton();
            this.tsbtnMoveNext = new System.Windows.Forms.ToolStripButton();
            this.tsbtnMovePrivious = new System.Windows.Forms.ToolStripButton();
            this.tsbtnMoveFirst = new System.Windows.Forms.ToolStripButton();
            this.tssepNavigation = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnAddNew = new System.Windows.Forms.ToolStripButton();
            this.tsbtnSave = new System.Windows.Forms.ToolStripButton();
            this.tsbtnDelete = new System.Windows.Forms.ToolStripButton();
            this.tsbtnUndo = new System.Windows.Forms.ToolStripButton();
            this.tsbtnSearch = new System.Windows.Forms.ToolStripButton();
            this.tssepActionButtons = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnPrint = new System.Windows.Forms.ToolStripButton();
            this.bnsepPrint = new System.Windows.Forms.ToolStripSeparator();
            this.pnlControls = new System.Windows.Forms.Panel();
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new CustomControls.NumericTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errprvForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnToolBar)).BeginInit();
            this.bnToolBar.SuspendLayout();
            this.pnlControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // bnToolBar
            // 
            this.bnToolBar.AddNewItem = null;
            this.bnToolBar.CountItem = null;
            this.bnToolBar.DeleteItem = null;
            this.bnToolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnMoveLast,
            this.tsbtnMoveNext,
            this.tsbtnMovePrivious,
            this.tsbtnMoveFirst,
            this.tssepNavigation,
            this.tsbtnAddNew,
            this.tsbtnSave,
            this.tsbtnDelete,
            this.tsbtnUndo,
            this.tsbtnSearch,
            this.tssepActionButtons,
            this.tsbtnPrint,
            this.bnsepPrint});
            this.bnToolBar.Location = new System.Drawing.Point(0, 0);
            this.bnToolBar.MoveFirstItem = this.tsbtnMoveLast;
            this.bnToolBar.MoveLastItem = this.tsbtnMoveFirst;
            this.bnToolBar.MoveNextItem = this.tsbtnMovePrivious;
            this.bnToolBar.MovePreviousItem = this.tsbtnMoveNext;
            this.bnToolBar.Name = "bnToolBar";
            this.bnToolBar.PositionItem = null;
            this.bnToolBar.Size = new System.Drawing.Size(742, 25);
            this.bnToolBar.TabIndex = 4;
            this.bnToolBar.Text = "bindingNavigator1";
            // 
            // tsbtnMoveLast
            // 
            this.tsbtnMoveLast.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnMoveLast.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnMoveLast.Image")));
            this.tsbtnMoveLast.Name = "tsbtnMoveLast";
            this.tsbtnMoveLast.RightToLeftAutoMirrorImage = true;
            this.tsbtnMoveLast.Size = new System.Drawing.Size(23, 22);
            this.tsbtnMoveLast.Text = "Move first";
            this.tsbtnMoveLast.ToolTipText = "أول سجل";
            this.tsbtnMoveLast.Click += new System.EventHandler(this.tsbtnMoveLast_Click);
            // 
            // tsbtnMoveNext
            // 
            this.tsbtnMoveNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnMoveNext.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnMoveNext.Image")));
            this.tsbtnMoveNext.Name = "tsbtnMoveNext";
            this.tsbtnMoveNext.RightToLeftAutoMirrorImage = true;
            this.tsbtnMoveNext.Size = new System.Drawing.Size(23, 22);
            this.tsbtnMoveNext.Text = "Move previous";
            this.tsbtnMoveNext.ToolTipText = "السابق";
            this.tsbtnMoveNext.Click += new System.EventHandler(this.tsbtnMoveNext_Click);
            // 
            // tsbtnMovePrivious
            // 
            this.tsbtnMovePrivious.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnMovePrivious.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnMovePrivious.Image")));
            this.tsbtnMovePrivious.Name = "tsbtnMovePrivious";
            this.tsbtnMovePrivious.RightToLeftAutoMirrorImage = true;
            this.tsbtnMovePrivious.Size = new System.Drawing.Size(23, 22);
            this.tsbtnMovePrivious.Text = "Move next";
            this.tsbtnMovePrivious.ToolTipText = "التالي";
            this.tsbtnMovePrivious.Click += new System.EventHandler(this.tsbtnMovePrivious_Click);
            // 
            // tsbtnMoveFirst
            // 
            this.tsbtnMoveFirst.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnMoveFirst.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnMoveFirst.Image")));
            this.tsbtnMoveFirst.Name = "tsbtnMoveFirst";
            this.tsbtnMoveFirst.RightToLeftAutoMirrorImage = true;
            this.tsbtnMoveFirst.Size = new System.Drawing.Size(23, 22);
            this.tsbtnMoveFirst.Text = "Move last";
            this.tsbtnMoveFirst.ToolTipText = "آخر سجل";
            this.tsbtnMoveFirst.Click += new System.EventHandler(this.tsbtnMoveFirst_Click);
            // 
            // tssepNavigation
            // 
            this.tssepNavigation.Name = "tssepNavigation";
            this.tssepNavigation.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbtnAddNew
            // 
            this.tsbtnAddNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnAddNew.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnAddNew.Image")));
            this.tsbtnAddNew.Name = "tsbtnAddNew";
            this.tsbtnAddNew.RightToLeftAutoMirrorImage = true;
            this.tsbtnAddNew.Size = new System.Drawing.Size(23, 22);
            this.tsbtnAddNew.Text = "Add new";
            this.tsbtnAddNew.ToolTipText = "جديد";
            this.tsbtnAddNew.Click += new System.EventHandler(this.tsbtnAddNew_Click);
            // 
            // tsbtnSave
            // 
            this.tsbtnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnSave.Image")));
            this.tsbtnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnSave.Name = "tsbtnSave";
            this.tsbtnSave.Size = new System.Drawing.Size(23, 22);
            this.tsbtnSave.Text = "&Save";
            this.tsbtnSave.ToolTipText = "حفظ";
            this.tsbtnSave.Click += new System.EventHandler(this.tsbtnSave_Click);
            // 
            // tsbtnDelete
            // 
            this.tsbtnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnDelete.Image")));
            this.tsbtnDelete.Name = "tsbtnDelete";
            this.tsbtnDelete.RightToLeftAutoMirrorImage = true;
            this.tsbtnDelete.Size = new System.Drawing.Size(23, 22);
            this.tsbtnDelete.Text = "حذف";
            this.tsbtnDelete.Click += new System.EventHandler(this.tsbtnDelete_Click);
            // 
            // tsbtnUndo
            // 
            this.tsbtnUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnUndo.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnUndo.Image")));
            this.tsbtnUndo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnUndo.Name = "tsbtnUndo";
            this.tsbtnUndo.Size = new System.Drawing.Size(23, 22);
            this.tsbtnUndo.Text = "تراجع";
            this.tsbtnUndo.Click += new System.EventHandler(this.tsbtnUndo_Click);
            // 
            // tsbtnSearch
            // 
            this.tsbtnSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnSearch.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnSearch.Image")));
            this.tsbtnSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnSearch.Name = "tsbtnSearch";
            this.tsbtnSearch.Size = new System.Drawing.Size(23, 22);
            this.tsbtnSearch.Text = "بحث";
            this.tsbtnSearch.Click += new System.EventHandler(this.tsbtnSearch_Click);
            // 
            // tssepActionButtons
            // 
            this.tssepActionButtons.Name = "tssepActionButtons";
            this.tssepActionButtons.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbtnPrint
            // 
            this.tsbtnPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnPrint.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnPrint.Image")));
            this.tsbtnPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnPrint.Name = "tsbtnPrint";
            this.tsbtnPrint.Size = new System.Drawing.Size(23, 22);
            this.tsbtnPrint.Text = "&Print";
            this.tsbtnPrint.ToolTipText = "طباعة";
            this.tsbtnPrint.Click += new System.EventHandler(this.tsbtnPrint_Click);
            // 
            // bnsepPrint
            // 
            this.bnsepPrint.Name = "bnsepPrint";
            this.bnsepPrint.Size = new System.Drawing.Size(6, 25);
            // 
            // pnlControls
            // 
            this.pnlControls.BackColor = System.Drawing.Color.Transparent;
            this.pnlControls.Controls.Add(this.lblID);
            this.pnlControls.Controls.Add(this.txtID);
            this.pnlControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlControls.Location = new System.Drawing.Point(0, 25);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(742, 491);
            this.pnlControls.TabIndex = 5;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(667, 13);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(63, 13);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "المسلسل :";
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.White;
            this.txtID.IsInt = true;
            this.txtID.Location = new System.Drawing.Point(594, 13);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(54, 20);
            this.txtID.TabIndex = 0;
            this.txtID.TabStop = false;
            this.txtID.Leave += new System.EventHandler(this.txtID_Leave);
            // 
            // frmActionBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(742, 516);
            this.Controls.Add(this.pnlControls);
            this.Controls.Add(this.bnToolBar);
            this.MaximizeBox = false;
            this.Name = "frmActionBase";
            this.Load += new System.EventHandler(this.frmActionBase_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBase_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.errprvForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnToolBar)).EndInit();
            this.bnToolBar.ResumeLayout(false);
            this.bnToolBar.PerformLayout();
            this.pnlControls.ResumeLayout(false);
            this.pnlControls.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator bnToolBar;
        private System.Windows.Forms.ToolStripButton tsbtnMoveLast;
        private System.Windows.Forms.ToolStripButton tsbtnMoveNext;
        private System.Windows.Forms.ToolStripButton tsbtnMovePrivious;
        private System.Windows.Forms.ToolStripButton tsbtnMoveFirst;
        private System.Windows.Forms.ToolStripSeparator tssepNavigation;
        private System.Windows.Forms.ToolStripButton tsbtnAddNew;
        private System.Windows.Forms.ToolStripButton tsbtnSave;
        private System.Windows.Forms.ToolStripButton tsbtnDelete;
        private System.Windows.Forms.ToolStripButton tsbtnUndo;
        private System.Windows.Forms.ToolStripButton tsbtnSearch;
        private System.Windows.Forms.ToolStripSeparator tssepActionButtons;
        private System.Windows.Forms.ToolStripButton tsbtnPrint;
        private System.Windows.Forms.ToolStripSeparator bnsepPrint;
        protected CustomControls.NumericTextBox txtID;
        protected System.Windows.Forms.Panel pnlControls;
        protected System.Windows.Forms.Label lblID;
    }
}
