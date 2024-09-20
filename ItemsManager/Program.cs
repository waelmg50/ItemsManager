using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Utilities;

namespace ItemsManager
{
    static class Program
    {

        #region Members

        public static DevExpressReports.DevExpressReportStorage ReportStorage { get; set; } = new DevExpressReports.DevExpressReportStorage();

        #endregion

        #region Entry Point

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                if (DBConnection.Connect())
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    UserLogin.CurrentShiftID = Managers.mngrShifts.GetCurrentShiftID();
                    if (UserLogin.CurrentShiftID > 0)
                        Application.Run(new frmLogin() { LoginStatus = 0 });
                    else if (UserLogin.CurrentShiftID == 0)
                        Application.Run(new Shifts.frmShiftIn());
                    if (UserLogin.CurrentShiftID > 0 && UserLogin.LoggedUserID > 0)
                        Application.Run(new frmMain());
                }
                else
                    Application.Run(new frmRestore());
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
            finally
            {
                if (DBConnection.Connection.State == System.Data.ConnectionState.Open)
                    DBConnection.Disconnect();
            }
        }

        #endregion

    }
}