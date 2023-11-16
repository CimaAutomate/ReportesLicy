using DataSource.Datasources.Impresiones;
using DevExpress.DataAccess.Sql;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Text;

namespace Reports.PredefinedReports
{
    public partial class ImpresionesPorMunicipioFechaReport : DevExpress.XtraReports.UI.XtraReport
    {
        public ImpresionesPorMunicipioFechaReport()
        {
            InitializeComponent();

            startDate.Value = DateTime.Now;
            endDate.Value = DateTime.Now;
            DataSourceDemanded += XtraReport1_DataSourceDemanded;
        }

        void XtraReport1_DataSourceDemanded(object sender, EventArgs e)
        {
            //Parameter startDateParameter = new Parameter("startDate", typeof(DateTime), startDate.Value);
            //Parameter endDateParameter = new QueryParameter("endDate", typeof(DateTime), endDate.Value);
            //Parameter municipioIDParameter = new QueryParameter("municipioID", typeof(int), municipio.Value);


            //ImpresionesPorMunicipioFecha.Parameters.Clear();
            //ImpresionesPorMunicipioFecha.Parameters.AddRange(new QueryParameter[] { startDateParameter, endDateParameter, municipioIDParameter });

        }
    }
}
