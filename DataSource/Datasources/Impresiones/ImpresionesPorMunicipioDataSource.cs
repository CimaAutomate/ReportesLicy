using DataSource.Common.Attributes;
using DataSource.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataSource.Datasources.Impresiones
{
    [ReportDataSource]
    public class ImpresionesPorMunicipioDataSource 
    {
        public List<ImpresionesPorMunicipio> GetData(DateTime startDate, DateTime endDate)
        {
            return GenerateDummyData();
        }

        private List<ImpresionesPorMunicipio> GenerateDummyData()
        {
            List<ImpresionesPorMunicipio> listaImpresiones = new List<ImpresionesPorMunicipio>
            {
                new ImpresionesPorMunicipio { Municipio = "Municipio 1", Impresiones = 100 },
                new ImpresionesPorMunicipio { Municipio = "Municipio 2", Impresiones = 200 },
                new ImpresionesPorMunicipio { Municipio = "Municipio 3", Impresiones = 300 },
                new ImpresionesPorMunicipio { Municipio = "Municipio 4", Impresiones = 400 },
                new ImpresionesPorMunicipio { Municipio = "Municipio 5", Impresiones = 500 },
                new ImpresionesPorMunicipio { Municipio = "Municipio 6", Impresiones = 600 },
                new ImpresionesPorMunicipio { Municipio = "Municipio 7", Impresiones = 700 },
                new ImpresionesPorMunicipio { Municipio = "Municipio 8", Impresiones = 800 },
                new ImpresionesPorMunicipio { Municipio = "Municipio 9", Impresiones = 900 },
                new ImpresionesPorMunicipio { Municipio = "Municipio 10", Impresiones = 1000 }
            };

            return listaImpresiones;
        }
    }
}
