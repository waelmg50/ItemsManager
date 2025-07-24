namespace ItemsManager
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnlControls = new System.Windows.Forms.Panel();
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRestart = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTempClose = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBasicData = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMainUnits = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUnitsTypes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUnits = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUnitsConversions = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMainItems = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiItemsCotegories = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiItems = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiItemsUnits = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiItemsUnitsConversions = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExpensesTypes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSuppliersTypes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSuppliersAndCustomers = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOperations = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiItemsIn = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiInvoices = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiStocktaking = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExpenses = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiShifts = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiShiftDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCloseShift = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSecurity = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiData = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBackupDatabase = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiConnectOrRestoreDatabase = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiReports = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExchanges = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBills = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiItemsInReport = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDesignNewReport = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.errprvForm)).BeginInit();
            this.pnlControls.SuspendLayout();
            this.msMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlControls
            // 
            this.pnlControls.BackColor = System.Drawing.Color.Transparent;
            this.pnlControls.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlControls.BackgroundImage")));
            this.pnlControls.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlControls.Controls.Add(this.msMain);
            this.pnlControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlControls.Location = new System.Drawing.Point(0, 0);
            this.pnlControls.Margin = new System.Windows.Forms.Padding(4);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(989, 635);
            this.pnlControls.TabIndex = 0;
            // 
            // msMain
            // 
            this.msMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile,
            this.tsmiBasicData,
            this.tsmiOperations,
            this.tsmiSecurity,
            this.tsmiData,
            this.tsmiReports});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(989, 28);
            this.msMain.TabIndex = 0;
            this.msMain.Text = "menuStrip1";
            // 
            // tsmiFile
            // 
            this.tsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiRestart,
            this.tsmiTempClose,
            this.tsmiExit});
            this.tsmiFile.Name = "tsmiFile";
            this.tsmiFile.Size = new System.Drawing.Size(52, 24);
            this.tsmiFile.Text = "ملف";
            // 
            // tsmiRestart
            // 
            this.tsmiRestart.Name = "tsmiRestart";
            this.tsmiRestart.Size = new System.Drawing.Size(180, 26);
            this.tsmiRestart.Text = "إعادة التشغيل";
            this.tsmiRestart.Click += new System.EventHandler(this.tsmiRestart_Click);
            // 
            // tsmiTempClose
            // 
            this.tsmiTempClose.Name = "tsmiTempClose";
            this.tsmiTempClose.Size = new System.Drawing.Size(180, 26);
            this.tsmiTempClose.Text = "خروج مؤقت";
            this.tsmiTempClose.Click += new System.EventHandler(this.tsmiTempClose_Click);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(180, 26);
            this.tsmiExit.Text = "إغلاق البرنامج";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // tsmiBasicData
            // 
            this.tsmiBasicData.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiMainUnits,
            this.tsmiMainItems,
            this.tsmiExpensesTypes,
            this.tsmiSuppliersTypes,
            this.tsmiSuppliersAndCustomers});
            this.tsmiBasicData.Name = "tsmiBasicData";
            this.tsmiBasicData.Size = new System.Drawing.Size(129, 24);
            this.tsmiBasicData.Text = "البيانات الأساسية";
            // 
            // tsmiMainUnits
            // 
            this.tsmiMainUnits.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiUnitsTypes,
            this.tsmiUnits,
            this.tsmiUnitsConversions});
            this.tsmiMainUnits.Name = "tsmiMainUnits";
            this.tsmiMainUnits.Size = new System.Drawing.Size(233, 26);
            this.tsmiMainUnits.Text = "الوحدات";
            // 
            // tsmiUnitsTypes
            // 
            this.tsmiUnitsTypes.Name = "tsmiUnitsTypes";
            this.tsmiUnitsTypes.Size = new System.Drawing.Size(199, 26);
            this.tsmiUnitsTypes.Text = "أنواع الوحدات";
            this.tsmiUnitsTypes.Click += new System.EventHandler(this.tsmiUnitsTypes_Click);
            // 
            // tsmiUnits
            // 
            this.tsmiUnits.Name = "tsmiUnits";
            this.tsmiUnits.Size = new System.Drawing.Size(199, 26);
            this.tsmiUnits.Text = "الوحدات";
            this.tsmiUnits.Click += new System.EventHandler(this.tsmiUnits_Click);
            // 
            // tsmiUnitsConversions
            // 
            this.tsmiUnitsConversions.Name = "tsmiUnitsConversions";
            this.tsmiUnitsConversions.Size = new System.Drawing.Size(199, 26);
            this.tsmiUnitsConversions.Text = "تحويلات الوحدات";
            this.tsmiUnitsConversions.Click += new System.EventHandler(this.tsmiUnitsConversions_Click);
            // 
            // tsmiMainItems
            // 
            this.tsmiMainItems.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiItemsCotegories,
            this.tsmiItems,
            this.tsmiItemsUnits,
            this.tsmiItemsUnitsConversions});
            this.tsmiMainItems.Name = "tsmiMainItems";
            this.tsmiMainItems.Size = new System.Drawing.Size(233, 26);
            this.tsmiMainItems.Text = "الأصناف";
            // 
            // tsmiItemsCotegories
            // 
            this.tsmiItemsCotegories.Name = "tsmiItemsCotegories";
            this.tsmiItemsCotegories.Size = new System.Drawing.Size(246, 26);
            this.tsmiItemsCotegories.Text = "تصنيفات الأصناف";
            this.tsmiItemsCotegories.Click += new System.EventHandler(this.tsmiItemsCotegories_Click);
            // 
            // tsmiItems
            // 
            this.tsmiItems.Name = "tsmiItems";
            this.tsmiItems.Size = new System.Drawing.Size(246, 26);
            this.tsmiItems.Text = "الأصناف";
            this.tsmiItems.Click += new System.EventHandler(this.tsmiItems_Click);
            // 
            // tsmiItemsUnits
            // 
            this.tsmiItemsUnits.Name = "tsmiItemsUnits";
            this.tsmiItemsUnits.Size = new System.Drawing.Size(246, 26);
            this.tsmiItemsUnits.Text = "وحدات الأصناف";
            this.tsmiItemsUnits.Click += new System.EventHandler(this.tsmiItemsUnits_Click);
            // 
            // tsmiItemsUnitsConversions
            // 
            this.tsmiItemsUnitsConversions.Name = "tsmiItemsUnitsConversions";
            this.tsmiItemsUnitsConversions.Size = new System.Drawing.Size(246, 26);
            this.tsmiItemsUnitsConversions.Text = "تحويلات وحدات الأصناف";
            this.tsmiItemsUnitsConversions.Click += new System.EventHandler(this.tsmiItemsUnitsConversions_Click);
            // 
            // tsmiExpensesTypes
            // 
            this.tsmiExpensesTypes.Name = "tsmiExpensesTypes";
            this.tsmiExpensesTypes.Size = new System.Drawing.Size(233, 26);
            this.tsmiExpensesTypes.Text = "أنواع المصاريف";
            this.tsmiExpensesTypes.Click += new System.EventHandler(this.tsmiExpensesTypes_Click);
            // 
            // tsmiSuppliersTypes
            // 
            this.tsmiSuppliersTypes.Name = "tsmiSuppliersTypes";
            this.tsmiSuppliersTypes.Size = new System.Drawing.Size(233, 26);
            this.tsmiSuppliersTypes.Text = "أنواع الموردين والعملاء";
            this.tsmiSuppliersTypes.Click += new System.EventHandler(this.tsmiSuppliersTypes_Click);
            // 
            // tsmiSuppliersAndCustomers
            // 
            this.tsmiSuppliersAndCustomers.Name = "tsmiSuppliersAndCustomers";
            this.tsmiSuppliersAndCustomers.Size = new System.Drawing.Size(233, 26);
            this.tsmiSuppliersAndCustomers.Text = "الموردين والعملاء";
            this.tsmiSuppliersAndCustomers.Click += new System.EventHandler(this.tsmiSuppliersAndCustomers_Click);
            // 
            // tsmiOperations
            // 
            this.tsmiOperations.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiItemsIn,
            this.tsmiInvoices,
            this.tsmiStocktaking,
            this.tsmiExpenses,
            this.tsmiShifts});
            this.tsmiOperations.Name = "tsmiOperations";
            this.tsmiOperations.Size = new System.Drawing.Size(78, 24);
            this.tsmiOperations.Text = "العمليات";
            // 
            // tsmiItemsIn
            // 
            this.tsmiItemsIn.Name = "tsmiItemsIn";
            this.tsmiItemsIn.Size = new System.Drawing.Size(167, 26);
            this.tsmiItemsIn.Text = "فواتير الشراء";
            this.tsmiItemsIn.Click += new System.EventHandler(this.tsmiItemsIn_Click);
            // 
            // tsmiInvoices
            // 
            this.tsmiInvoices.Name = "tsmiInvoices";
            this.tsmiInvoices.Size = new System.Drawing.Size(167, 26);
            this.tsmiInvoices.Text = "فواتير البيع";
            this.tsmiInvoices.Click += new System.EventHandler(this.tsmiInvoices_Click);
            // 
            // tsmiStocktaking
            // 
            this.tsmiStocktaking.Name = "tsmiStocktaking";
            this.tsmiStocktaking.Size = new System.Drawing.Size(167, 26);
            this.tsmiStocktaking.Text = "جرد المحل";
            this.tsmiStocktaking.Click += new System.EventHandler(this.tsmiStocktaking_Click);
            // 
            // tsmiExpenses
            // 
            this.tsmiExpenses.Name = "tsmiExpenses";
            this.tsmiExpenses.Size = new System.Drawing.Size(167, 26);
            this.tsmiExpenses.Text = "المصاريف";
            this.tsmiExpenses.Click += new System.EventHandler(this.tsmiExpenses_Click);
            // 
            // tsmiShifts
            // 
            this.tsmiShifts.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiShiftDetails,
            this.tsmiCloseShift});
            this.tsmiShifts.Name = "tsmiShifts";
            this.tsmiShifts.Size = new System.Drawing.Size(167, 26);
            this.tsmiShifts.Text = "الورديات";
            // 
            // tsmiShiftDetails
            // 
            this.tsmiShiftDetails.Name = "tsmiShiftDetails";
            this.tsmiShiftDetails.Size = new System.Drawing.Size(196, 26);
            this.tsmiShiftDetails.Text = "تفاصيل الورديات";
            this.tsmiShiftDetails.Click += new System.EventHandler(this.tsmiShiftDetails_Click);
            // 
            // tsmiCloseShift
            // 
            this.tsmiCloseShift.Name = "tsmiCloseShift";
            this.tsmiCloseShift.Size = new System.Drawing.Size(196, 26);
            this.tsmiCloseShift.Text = "إغلاق الوردية";
            this.tsmiCloseShift.Click += new System.EventHandler(this.tsmiCloseShift_Click);
            // 
            // tsmiSecurity
            // 
            this.tsmiSecurity.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiUsers});
            this.tsmiSecurity.Name = "tsmiSecurity";
            this.tsmiSecurity.Size = new System.Drawing.Size(108, 24);
            this.tsmiSecurity.Text = "حماية البرنامج";
            // 
            // tsmiUsers
            // 
            this.tsmiUsers.Name = "tsmiUsers";
            this.tsmiUsers.Size = new System.Drawing.Size(169, 26);
            this.tsmiUsers.Text = "المستخدمين";
            this.tsmiUsers.Click += new System.EventHandler(this.tsmiUsers_Click);
            // 
            // tsmiData
            // 
            this.tsmiData.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiBackupDatabase,
            this.tsmiConnectOrRestoreDatabase});
            this.tsmiData.Name = "tsmiData";
            this.tsmiData.Size = new System.Drawing.Size(69, 24);
            this.tsmiData.Text = "البيانات";
            // 
            // tsmiBackupDatabase
            // 
            this.tsmiBackupDatabase.Name = "tsmiBackupDatabase";
            this.tsmiBackupDatabase.Size = new System.Drawing.Size(289, 26);
            this.tsmiBackupDatabase.Text = "عمل نسخة احتياطية من البيانات";
            this.tsmiBackupDatabase.Click += new System.EventHandler(this.tsmiBackupDatabase_Click);
            // 
            // tsmiConnectOrRestoreDatabase
            // 
            this.tsmiConnectOrRestoreDatabase.Name = "tsmiConnectOrRestoreDatabase";
            this.tsmiConnectOrRestoreDatabase.Size = new System.Drawing.Size(289, 26);
            this.tsmiConnectOrRestoreDatabase.Text = "اتصال - استرجاع قاعدة البيانات";
            this.tsmiConnectOrRestoreDatabase.Click += new System.EventHandler(this.tsmiConnectOrRestoreDatabase_Click);
            // 
            // tsmiReports
            // 
            this.tsmiReports.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiExchanges,
            this.tsmiBills,
            this.tsmiItemsInReport,
            this.tsmiDesignNewReport});
            this.tsmiReports.Name = "tsmiReports";
            this.tsmiReports.Size = new System.Drawing.Size(67, 24);
            this.tsmiReports.Text = "التقارير";
            // 
            // tsmiExchanges
            // 
            this.tsmiExchanges.Name = "tsmiExchanges";
            this.tsmiExchanges.Size = new System.Drawing.Size(221, 26);
            this.tsmiExchanges.Text = "المصروفات";
            this.tsmiExchanges.Click += new System.EventHandler(this.tsmiExchanges_Click);
            // 
            // tsmiBills
            // 
            this.tsmiBills.Name = "tsmiBills";
            this.tsmiBills.Size = new System.Drawing.Size(221, 26);
            this.tsmiBills.Text = "الفواتير";
            this.tsmiBills.Click += new System.EventHandler(this.tsmiBills_Click);
            // 
            // tsmiItemsInReport
            // 
            this.tsmiItemsInReport.Name = "tsmiItemsInReport";
            this.tsmiItemsInReport.Size = new System.Drawing.Size(221, 26);
            this.tsmiItemsInReport.Text = "فواتير الشراء";
            this.tsmiItemsInReport.Click += new System.EventHandler(this.tsmiItemsInReport_Click);
            // 
            // tsmiDesignNewReport
            // 
            this.tsmiDesignNewReport.Name = "tsmiDesignNewReport";
            this.tsmiDesignNewReport.Size = new System.Drawing.Size(221, 26);
            this.tsmiDesignNewReport.Text = "Design New Report";
            this.tsmiDesignNewReport.Click += new System.EventHandler(this.tsmiDesignNewReport_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(989, 635);
            this.Controls.Add(this.pnlControls);
            this.MainMenuStrip = this.msMain;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "برنامج مدير الأصناف - الشاشة الرئيسية";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errprvForm)).EndInit();
            this.pnlControls.ResumeLayout(false);
            this.pnlControls.PerformLayout();
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem tsmiFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiRestart;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripMenuItem tsmiBasicData;
        private System.Windows.Forms.ToolStripMenuItem tsmiMainItems;
        private System.Windows.Forms.ToolStripMenuItem tsmiItemsCotegories;
        private System.Windows.Forms.ToolStripMenuItem tsmiItems;
        private System.Windows.Forms.ToolStripMenuItem tsmiItemsUnits;
        private System.Windows.Forms.ToolStripMenuItem tsmiItemsUnitsConversions;
        private System.Windows.Forms.ToolStripMenuItem tsmiOperations;
        private System.Windows.Forms.ToolStripMenuItem tsmiItemsIn;
        private System.Windows.Forms.ToolStripMenuItem tsmiInvoices;
        private System.Windows.Forms.ToolStripMenuItem tsmiStocktaking;
        private System.Windows.Forms.ToolStripMenuItem tsmiSecurity;
        private System.Windows.Forms.ToolStripMenuItem tsmiUsers;
        private System.Windows.Forms.ToolStripMenuItem tsmiMainUnits;
        private System.Windows.Forms.ToolStripMenuItem tsmiUnitsTypes;
        private System.Windows.Forms.ToolStripMenuItem tsmiUnits;
        private System.Windows.Forms.ToolStripMenuItem tsmiUnitsConversions;
        private System.Windows.Forms.ToolStripMenuItem tsmiTempClose;
        private System.Windows.Forms.ToolStripMenuItem tsmiData;
        private System.Windows.Forms.ToolStripMenuItem tsmiBackupDatabase;
        private System.Windows.Forms.ToolStripMenuItem tsmiConnectOrRestoreDatabase;
        private System.Windows.Forms.ToolStripMenuItem tsmiExpensesTypes;
        private System.Windows.Forms.ToolStripMenuItem tsmiExpenses;
        private System.Windows.Forms.ToolStripMenuItem tsmiShifts;
        private System.Windows.Forms.ToolStripMenuItem tsmiShiftDetails;
        private System.Windows.Forms.ToolStripMenuItem tsmiCloseShift;
        private System.Windows.Forms.ToolStripMenuItem tsmiReports;
        private System.Windows.Forms.ToolStripMenuItem tsmiExchanges;
        private System.Windows.Forms.ToolStripMenuItem tsmiBills;
        private System.Windows.Forms.ToolStripMenuItem tsmiSuppliersTypes;
        private System.Windows.Forms.ToolStripMenuItem tsmiSuppliersAndCustomers;
        private System.Windows.Forms.ToolStripMenuItem tsmiItemsInReport;
        private System.Windows.Forms.ToolStripMenuItem tsmiDesignNewReport;
    }
}
