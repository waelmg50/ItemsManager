using System;
using System.IO;
using System.Data;
using System.Windows.Forms;
using System.ComponentModel;
using System.Collections.Generic;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.Extensions;
using Utilities;
using System.Text.RegularExpressions;
using DevExpress.XtraPrinting.Native.WebClientUIControl;
using DevExpress.Utils.Animation;
using DevExpress.XtraReports;
using ReportStorageSample;
using DevExpress.Xpo;

namespace ItemsManager.DevExpressReports
{
    public class DevExpressReportStorage : ReportStorageExtension
    {
        private DataTable tblRports;
        string _uri;
        void FillReportsTable()
        {
            if (tblRports != null)
                tblRports.Clear();
            try
            {
                if (RecordsFunctions.IsDataExists("DevExpressReportStorage", null, null, 0))
                    tblRports = SqlAdoWrapper.ExecuteQueryCommand("select * from DevExpressReportStorage", null, true);
                else
                    tblRports = new DataTable();
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
                tblRports = new DataTable();
            }
            if (tblRports != null)
            {
                if (tblRports.Columns.Count < 1)
                {
                    tblRports.Columns.AddRange(new DataColumn[] { new DataColumn("ReportId", typeof(int)), new DataColumn("ReportCode", typeof(int)), new DataColumn("ReportKey", typeof(string)), new DataColumn("ReportDisplayName", typeof(string)), new DataColumn("ReadOnly", typeof(bool)), new DataColumn("LayoutData", typeof(byte[])) });
                }
                tblRports.PrimaryKey = new DataColumn[] { tblRports.Columns[0] };
            }
        }
        public DevExpressReportStorage()
        {
            FillReportsTable();
            if (tblRports != null)
                tblRports.PrimaryKey = new DataColumn[] { tblRports.Columns[0] };
        }
        public override bool IsValidUrl(string url)
        {
            if (string.IsNullOrWhiteSpace(url) || !Regex.IsMatch(url, @"^\d+$"))
                return false;
            if (tblRports == null || tblRports.Rows.Count < 1)
                return false;
            if (tblRports.Rows.Find(url) == null)
                return false;
            return true;
        }
        public override bool CanSetData(string url)
        {
            DataRow drReport = tblRports.Rows.Find(url);
            if (drReport == null)
                return false;
            return Convert.ToBoolean(drReport["ReadOnly"]);
        }
        public override void SetData(XtraReport report, string url)
        {
            int iReportID = Convert.ToInt32(url);
            DataRow[] dtrwArr = tblRports.Select($"ReportId = {iReportID}");
            if (dtrwArr == null || dtrwArr.Length < 1)
                return;
            DevExpressReportStorageDTO dtoReport = new DevExpressReportStorageDTO() { ReportId = iReportID, ReportKey = dtrwArr[0]["ReportKey"].ToString(), ReportDisplayName = dtrwArr[0]["ReportDisplayName"].ToString(), ReadOnly = Convert.ToBoolean(dtrwArr[0]["ReadOnly"]), ReportCode = Convert.ToInt32(dtrwArr[0]["ReportCode"]), ReportStoredProcedure = dtrwArr[0]["ReportStoredProcedure"].ToString() };
            using (MemoryStream ms = new MemoryStream())
            {
                report.SaveLayoutToXml(ms);
                dtoReport.LayoutData = ms.GetBuffer();
            }
            if (!dtoReport.UpdateReport())
            {
                FillReportsTable();
            }
        }
        public override string SetNewData(XtraReport report, string defaultUrl)
        {
            string dfUrl = defaultUrl;
            if (defaultUrl.Contains("'"))
                dfUrl = defaultUrl.Replace("'", "''");
            //If the repport exists before then overrite it.
            object objReportID = new object();
            if (GetUrlsCore(null).Contains(defaultUrl))
            {
                objReportID = SqlAdoWrapper.ExecuteScalarCommand($"select ReportId from DevExpressReportStorage where ReportKey = '{dfUrl}'", null, true);
                if (objReportID != null)
                {
                    int iReportID = Convert.ToInt32(objReportID);
                    if (iReportID > 0)
                        SetData(report, iReportID.ToString());
                    return iReportID.ToString();
                }
            }
            objReportID = SqlAdoWrapper.ExecuteScalarCommand("select isnull(max(ReportCode), 0) %2B 1 from DevExpressReportStorage", null, true);
            if (objReportID != null)
            {
                int iReportCode = Convert.ToInt32(objReportID);
                DevExpressReportStorageDTO dtoReport = new DevExpressReportStorageDTO()
                {
                    ReportId = 0,
                    ReportCode = iReportCode,
                    ReportKey = defaultUrl,
                    ReportDisplayName = defaultUrl,
                    ReadOnly = false,
                    JsonUriCon = DBConnection.Connection.ConnectionString
                };
                using (MemoryStream ms = new MemoryStream())
                {
                    report.SaveLayoutToXml(ms);
                    dtoReport.LayoutData = ms.GetBuffer();
                }
                if (!dtoReport.InsertReport())
                    FillReportsTable();
                return "0";
            }
            return string.Empty;
        }
        public override bool GetStandardUrlsSupported(ITypeDescriptorContext context)
        {
            // Always return true to confirm that the GetStandardUrls method is available.
            return true;
        }
        public override string[] GetStandardUrls(ITypeDescriptorContext context)
        {
            if (context != null && context.Instance is XRSubreport)
            {
                XRSubreport xrSubreport = context.Instance as XRSubreport;
                if (xrSubreport.RootReport !=
                    null && xrSubreport.RootReport.Extensions.TryGetValue("StorageID", out storageID))
                {
                    List<string> result = GetUrlsCore(CanPassId);
                    return result.ToArray();
                }
            }
            return GetUrlsCore(null).ToArray();
        }
        public override string GetNewUrl()
        {
            StorageEditorForm form = CreateForm();
            form.txtReportName.Enabled = false;
            if (form.ShowDialog() == DialogResult.OK)
                return form.txtReportName.Text;
            return string.Empty;
        }
        StorageEditorForm CreateForm()
        {
            StorageEditorForm form = new StorageEditorForm();
            foreach (string item in GetUrlsCore(null))
                form.lstbxReports.Items.Add(item);
            return form;
        }
        string storageID;
        bool CanPassId(string id)
        {
            return id != storageID;
        }
        public override byte[] GetData(string url)
        {
            // Get a dataset row containing the report.
            object objReportLayoutData = SqlAdoWrapper.ExecuteScalarCommand($"select LayoutData from DevExpressReportStorage where ReportId = @ReportId", new System.Data.SqlClient.SqlParameter[] { new System.Data.SqlClient.SqlParameter("@ReportId", url) }, true);
            if (objReportLayoutData != null)
                return (byte[])objReportLayoutData;
            return new byte[] { };
        }
        List<string> GetUrlsCore(Predicate<string> method)
        {
            List<string> list = new List<string>();
            foreach (DataRow row in tblRports.Rows)
                if (method == null || method(row["ReportID"].ToString()))
                    list.Add(row["ReportDisplayName"].ToString());
            return list;
        }
    }
    public class StorageItem : XPObject
    {
        string url;
        byte[] layout = null;
        public string Url
        {
            get { return url; }
            set { SetPropertyValue("Url", ref url, value); }
        }
        public byte[] Layout
        {
            get { return layout; }
            set { SetPropertyValue("Layout", ref layout, value); }
        }
        public StorageItem(Session session)
            : base(session)
        {
        }
    }
}
