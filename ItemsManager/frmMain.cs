using DevExpress.XtraReports.UserDesigner;
using ItemsManager.DevExpressReports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Utilities;

namespace ItemsManager
{
    public partial class frmMain : ItemsManager.BaseForms.frmBase
    {

        #region Constructor

        public frmMain()
        {
            try
            {
                //UserLogin.CurrentShiftID = Managers.mngrShifts.GetCurrentShiftID();
                //if (UserLogin.CurrentShiftID > 0)
                //{
                //    frmLogin frmLgn = new frmLogin();
                //    frmLgn.LoginStatus = 0;
                //    frmLgn.ShowDialog(this);
                //}
                //else if (UserLogin.CurrentShiftID == 0)
                //{
                //    Shifts.frmShiftIn frmShftN = new Shifts.frmShiftIn();
                //    frmShftN.ShowDialog(this);
                //}

                //if (UserLogin.CurrentShiftID <= 0 || UserLogin.LoggedUserID <= 0)
                //{
                //    Application.Exit();
                //    return;
                //}
                InitializeComponent();
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }

        #endregion

        #region Methods

        void LoadPermessions()
        {
            try
            {
                tsmiData.Visible = tsmiSecurity.Visible = tsmiItemsIn.Visible = tsmiStocktaking.Visible = tsmiBasicData.Visible = tsmiShiftDetails.Visible
                    = tsmiReports.Visible = UserLogin.IsAdmin;
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }

        #endregion

        #region Event Handlers

        #region Menu Commands

        private void tsmiRestart_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Restart();
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }
        private void tsmiExit_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }
        private void tsmiUnitsTypes_Click(object sender, EventArgs e)
        {
            try
            {
                Units.frmUnitsTypes frmUntTps = new Units.frmUnitsTypes();
                frmUntTps.ShowDialog(this);
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }
        private void tsmiUnits_Click(object sender, EventArgs e)
        {
            try
            {
                object objRes = SqlAdoWrapper.ExecuteScalarCommand("select top 1 count(*) from UnitsTypes", null, true);
                if (Helper.CheckNumberInt(objRes) && Convert.ToInt32(objRes) > 0)
                {
                    Units.frmUnits frmUnts = new Units.frmUnits();
                    frmUnts.ShowDialog(this);
                }
                else
                    Helper.ShowMessage(Resources.ProgramMessages.ErrMesEnterUnitsTypesFirst);
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }
        private void tsmiUnitsConversions_Click(object sender, EventArgs e)
        {
            try
            {
                object objRes = SqlAdoWrapper.ExecuteScalarCommand("select top 1 count(*) from Units", null, true);
                if (Helper.CheckNumberInt(objRes) && Convert.ToInt32(objRes) > 0)
                {
                    Units.frmUnitsConversions frmUntsConv = new Units.frmUnitsConversions();
                    frmUntsConv.ShowDialog(this);
                }
                else
                    Helper.ShowMessage(Resources.ProgramMessages.ErrMesEnterUnitsFirst);
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }
        private void tsmiItemsCotegories_Click(object sender, EventArgs e)
        {
            try
            {
                Items.frmItemsCategories frmItemCat = new ItemsManager.Items.frmItemsCategories();
                frmItemCat.ShowDialog(this);
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }
        private void tsmiItems_Click(object sender, EventArgs e)
        {
            try
            {
                object objRes = SqlAdoWrapper.ExecuteScalarCommand("select top 1 count(*) from ItemsCategories", null, true);
                if (Helper.CheckNumberInt(objRes) && Convert.ToInt32(objRes) > 0)
                {
                    Items.frmItems frmItms = new Items.frmItems();
                    frmItms.ShowDialog(this);
                }
                else
                    Helper.ShowMessage(Resources.ProgramMessages.ErrMesEnterCategoriesFirst);
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }
        private void tsmiItemsUnits_Click(object sender, EventArgs e)
        {
            try
            {
                object objRes = SqlAdoWrapper.ExecuteScalarCommand("select top 1 count(*) from Units", null, true);
                if (Helper.CheckNumberInt(objRes) && Convert.ToInt32(objRes) > 0)
                {
                    objRes = SqlAdoWrapper.ExecuteScalarCommand("select top 1 count(*) from Items", null, true);
                    if (Helper.CheckNumberInt(objRes) && Convert.ToInt32(objRes) > 0)
                    {
                        Items.frmItemsUnits frmItmsUnts = new Items.frmItemsUnits();
                        frmItmsUnts.ShowDialog(this);
                    }
                    else
                        Helper.ShowMessage(Resources.ProgramMessages.ErrMesNoItemsExist);
                }
                else
                    Helper.ShowMessage(Resources.ProgramMessages.ErrMesEnterUnitsFirst);
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }
        private void tsmiItemsUnitsConversions_Click(object sender, EventArgs e)
        {
            try
            {
                object objRes = SqlAdoWrapper.ExecuteScalarCommand("select top 1 count(*) from Units", null, true);
                if (Helper.CheckNumberInt(objRes) && Convert.ToInt32(objRes) > 0)
                {
                    objRes = SqlAdoWrapper.ExecuteScalarCommand("select top 1 count(*) from Items", null, true);
                    if (Helper.CheckNumberInt(objRes) && Convert.ToInt32(objRes) > 0)
                    {
                        Items.frmItemsUnitsConversions frmItmsUntsConv = new Items.frmItemsUnitsConversions();
                        frmItmsUntsConv.ShowDialog(this);
                    }
                    else
                        Helper.ShowMessage(Resources.ProgramMessages.ErrMesNoItemsExist);
                }
                else
                    Helper.ShowMessage(Resources.ProgramMessages.ErrMesEnterUnitsFirst);
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }
        private void tsmiItemsIn_Click(object sender, EventArgs e)
        {
            try
            {
                object objRes = SqlAdoWrapper.ExecuteScalarCommand("select top 1 count(*) from Items", null, true);
                if (Helper.CheckNumberInt(objRes) && Convert.ToInt32(objRes) > 0)
                {
                    Items.frmItemsIn frmItmIn = new ItemsManager.Items.frmItemsIn();
                    frmItmIn.ShowDialog(this);
                }
                else
                    Helper.ShowMessage(Resources.ProgramMessages.ErrMesNoItemsExist);
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }
        private void tsmiInvoices_Click(object sender, EventArgs e)
        {
            try
            {
                object objRes = SqlAdoWrapper.ExecuteScalarCommand("select top 1 count(*) from Items", null, true);
                if (Helper.CheckNumberInt(objRes) && Convert.ToInt32(objRes) > 0)
                {
                    Invoice.frmInvoices frmInvces = new Invoice.frmInvoices();
                    frmInvces.ShowDialog(this);
                }
                else
                    Helper.ShowMessage(Resources.ProgramMessages.ErrMesNoItemsExist);
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }
        private void tsmiStocktaking_Click(object sender, EventArgs e)
        {
            try
            {
                object objRes = SqlAdoWrapper.ExecuteScalarCommand("select top 1 count(*) from ExpensesTypes", null, true);
                if (Helper.CheckNumberInt(objRes) && Convert.ToInt32(objRes) > 0)
                {
                    Stocktaking.frmStocktaking frmStockTking = new Stocktaking.frmStocktaking();
                    frmStockTking.ShowDialog(this);
                }
                else
                    Helper.ShowMessage(Resources.ProgramMessages.ErrMesNoItemsExist);
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }
        private void tsmiCloseShift_Click(object sender, EventArgs e)
        {
            try
            {
                Shifts.frmShiftsOut frmShftOt = new Shifts.frmShiftsOut();
                frmShftOt.ShowDialog(this);
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }
        private void tsmiUsers_Click(object sender, EventArgs e)
        {
            try
            {
                SystemForms.frmUsers frmUsrs = new SystemForms.frmUsers();
                frmUsrs.ShowDialog(this);
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }
        private void tsmiTempClose_Click(object sender, EventArgs e)
        {
            try
            {
                frmLogin frmLgn = new frmLogin();
                frmLgn.LoginStatus = 3;
                frmLgn.ShowDialog(this);
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }
        private void tsmiBackupDatabase_Click(object sender, EventArgs e)
        {
            try
            {
                frmBackup frmBckp = new frmBackup();
                frmBckp.ShowDialog(this);
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }
        private void tsmiConnectOrRestoreDatabase_Click(object sender, EventArgs e)
        {
            try
            {
                frmRestore frmRstr = new frmRestore();
                frmRstr.ConnectOnly = false;
                frmRstr.ShowDialog(this);
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }
        private void tsmiExpensesTypes_Click(object sender, EventArgs e)
        {
            try
            {
                Expenses.frmExpensesTypes frmExpnsTyps = new Expenses.frmExpensesTypes();
                frmExpnsTyps.ShowDialog(this);
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }
        private void tsmiExpenses_Click(object sender, EventArgs e)
        {
            try
            {
                object objRes = SqlAdoWrapper.ExecuteScalarCommand("select top 1 count(*) from ExpensesTypes", null, true);
                if (Helper.CheckNumberInt(objRes) && Convert.ToInt32(objRes) > 0)
                {
                    Expenses.frmExpenses frmExpns = new Expenses.frmExpenses();
                    frmExpns.ShowDialog(this);
                }
                else
                    Helper.ShowMessage(Resources.ProgramMessages.MesInsertExpencesTypes);
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }
        private void tsmiShiftDetails_Click(object sender, EventArgs e)
        {
            try
            {
                Shifts.frmShiftDetails frmShftDtls = new Shifts.frmShiftDetails();
                frmShftDtls.ShowDialog(this);
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }
        private void tsmiExchanges_Click(object sender, EventArgs e)
        {
            try
            {
                Report.frmExpencesReport frmExpenssRprt = new Report.frmExpencesReport();
                frmExpenssRprt.ShowDialog(this);
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }
        private void tsmiBills_Click(object sender, EventArgs e)
        {
            try
            {
                Report.frmInvoicesReport frmInvoiceDetails = new Report.frmInvoicesReport();
                frmInvoiceDetails.ShowDialog(this);
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }
        private void tsmiSuppliersTypes_Click(object sender, EventArgs e)
        {
            try
            {
                BasicData.frmSuppliersTypes frmSpplrsTyps = new BasicData.frmSuppliersTypes();
                frmSpplrsTyps.ShowDialog(this);
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }
        private void tsmiSuppliersAndCustomers_Click(object sender, EventArgs e)
        {
            try
            {
                BasicData.frmSuppliersAndCustomers frmSpplrsCstmrs = new BasicData.frmSuppliersAndCustomers();
                frmSpplrsCstmrs.ShowDialog(this);
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }
        private void tsmiItemsInReport_Click(object sender, EventArgs e)
        {
            try
            {
                Report.frmItemsInReport frmItemsInDetails = new Report.frmItemsInReport();
                frmItemsInDetails.ShowDialog(this);
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }

        #endregion

        private void frmMain_Load(object sender, EventArgs e)
        {
            try
            {
                LoadPermessions();
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }

        #endregion

        private void tsmiDesignNewReport_Click(object sender, EventArgs e)
        {
            try
            {
                XRDesignRibbonForm frmDesignReport = new XRDesignRibbonForm();
                frmDesignReport.ShowDialog(this);
                //frmDesignReports frmDsnReports = new frmDesignReports();
                //frmDsnReports.ShowDialog(this);
            }
            catch(Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
        }
    }
}
