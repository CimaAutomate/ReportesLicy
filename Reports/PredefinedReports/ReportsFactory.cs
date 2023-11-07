using DevExpress.XtraReports.UI;
using LicyReportingSystem.Reports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reports.PredefinedReports
{
    public static class ReportsFactory
    {
        public static Dictionary<string, Func<XtraReport>> Reports = new Dictionary<string, Func<XtraReport>>()
        {
            ["TestReport"] = () => new TestReport(),
            ["ImpresionesPorMunicipioReport"] = () => new ImpresionesPorMunicipioReport()
        };
    }
}