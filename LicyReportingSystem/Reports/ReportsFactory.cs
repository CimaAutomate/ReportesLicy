using DevExpress.XtraReports.UI;
using LicyReportingSystem.PredefinedReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LicyReportingSystem.Reports
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