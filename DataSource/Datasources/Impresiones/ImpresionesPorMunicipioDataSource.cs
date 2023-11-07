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
                    // Municipio 1, 4 registros
                    new ImpresionesPorMunicipio { Municipio = "Municipio 1", Impresiones = 100, FechaDeCaptura = DateTime.Now.AddDays(-1), FechaDePago = DateTime.Now.AddDays(1) },
                    new ImpresionesPorMunicipio { Municipio = "Municipio 1", Impresiones = 150, FechaDeCaptura = DateTime.Now.AddDays(-1), FechaDePago = DateTime.Now.AddDays(2) },
                    new ImpresionesPorMunicipio { Municipio = "Municipio 1", Impresiones = 200, FechaDeCaptura = DateTime.Now, FechaDePago = DateTime.Now.AddDays(3) },
                    new ImpresionesPorMunicipio { Municipio = "Municipio 1", Impresiones = 250, FechaDeCaptura = DateTime.Now, FechaDePago = DateTime.Now.AddDays(4) },

                    // Municipio 2, 4 registros
                    new ImpresionesPorMunicipio { Municipio = "Municipio 2", Impresiones = 300, FechaDeCaptura = DateTime.Now.AddDays(-2), FechaDePago = DateTime.Now.AddDays(5) },
                    new ImpresionesPorMunicipio { Municipio = "Municipio 2", Impresiones = 350, FechaDeCaptura = DateTime.Now.AddDays(-2), FechaDePago = DateTime.Now.AddDays(6) },
                    new ImpresionesPorMunicipio { Municipio = "Municipio 2", Impresiones = 400, FechaDeCaptura = DateTime.Now.AddDays(-1), FechaDePago = DateTime.Now.AddDays(7) },
                    new ImpresionesPorMunicipio { Municipio = "Municipio 2", Impresiones = 450, FechaDeCaptura = DateTime.Now.AddDays(-1), FechaDePago = DateTime.Now.AddDays(8) },

                    // Municipio 3, 4 registros
                    new ImpresionesPorMunicipio { Municipio = "Municipio 3", Impresiones = 500, FechaDeCaptura = DateTime.Now.AddDays(-3), FechaDePago = DateTime.Now.AddDays(9) },
                    new ImpresionesPorMunicipio { Municipio = "Municipio 3", Impresiones = 550, FechaDeCaptura = DateTime.Now.AddDays(-3), FechaDePago = DateTime.Now.AddDays(10) },
                    new ImpresionesPorMunicipio { Municipio = "Municipio 3", Impresiones = 600, FechaDeCaptura = DateTime.Now, FechaDePago = DateTime.Now.AddDays(11) },
                    new ImpresionesPorMunicipio { Municipio = "Municipio 3", Impresiones = 650, FechaDeCaptura = DateTime.Now, FechaDePago = DateTime.Now.AddDays(12) }
                };

                        return listaImpresiones;
                    }

            }
}
