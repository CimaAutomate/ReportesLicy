using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace Reports.PredefinedReports
{
    public partial class ImpresionesPorMunicipioFechaReport : DevExpress.XtraReports.UI.XtraReport
    {
        public ImpresionesPorMunicipioFechaReport()
        {
            InitializeComponent();

            startDate.Value = DateTime.Now;
            endDate.Value = DateTime.Now;
        }
    }
}
