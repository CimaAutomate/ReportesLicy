using System;
using DevExpress.XtraReports.UI;

namespace LicyReportingSystem.Reports
{
    public partial class ImpresionesPorMunicipioReport : XtraReport
    {
        public ImpresionesPorMunicipioReport()
        {
            InitializeComponent();

            startDate.Value = DateTime.Now;
            endDate.Value = DateTime.Now;


        }
    }
}
