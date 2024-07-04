using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Utilities;

namespace ItemsManager.DevExpressReports
{
    public class DevExpressReportStorageDTO
    {
        public int ReportId { get; set; }
        public int ReportCode { get; set; }
        public string ReportKey { get; set; }
        public string ReportDisplayName { get; set; }
        public bool ReadOnly { get; set; }
        public byte[] LayoutData { get; set; }
        public string ReportStoredProcedure { get; set; }
        public string JsonUriCon { get; set; }
        public string DomainClassName { get; set; }

        public bool UpdateReport()
        {
           int iExecutionResult = SqlAdoWrapper.ExecuteNonQueryCommand("Update DevExpressReportStorage set ReportDisplayName = @ReportDisplayName, ReadOnly = @ReadOnly, LayoutData = @LayoutData, ReportStoredProcedure = @ReportStoredProcedure where ReportCode = @ReportCode", new SqlParameter[] { new SqlParameter("@ReportDisplayName", ReportDisplayName), new SqlParameter("@ReadOnly", ReadOnly), new SqlParameter("@LayoutData", LayoutData), new SqlParameter("@ReportStoredProcedure", ReportStoredProcedure), new SqlParameter("@ReportCode", ReportCode) }, true);
            return iExecutionResult > 0;
        }
        public bool InsertReport()
        {
            int iExecutionResult = SqlAdoWrapper.ExecuteNonQueryCommand("insert into DevExpressReportStorage (ReportDisplayName, ReadOnly, LayoutData, ReportStoredProcedure, ReportCode) values(@ReportDisplayName, @ReadOnly, @LayoutData, @ReportStoredProcedure, @ReportCode)", new SqlParameter[] { new SqlParameter("@ReportDisplayName", ReportDisplayName), new SqlParameter("@ReadOnly", ReadOnly), new SqlParameter("@LayoutData", LayoutData), new SqlParameter("@ReportStoredProcedure", ReportStoredProcedure), new SqlParameter("@ReportCode", ReportCode) }, true);
            return iExecutionResult > 0;
        }
    }
}
