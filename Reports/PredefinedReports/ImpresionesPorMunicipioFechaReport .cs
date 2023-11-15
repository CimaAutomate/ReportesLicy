using System;
using DevExpress.XtraReports.UI;

namespace LicyReportingSystem.Reports
{
    public partial class ImpresionesPorMunicipioFechaReport : XtraReport
    {
        public ImpresionesPorMunicipioFechaReport()
        {
            InitializeComponent();

            startDate.Value = DateTime.Now;
            endDate.Value = DateTime.Now;
        }
    }
}
