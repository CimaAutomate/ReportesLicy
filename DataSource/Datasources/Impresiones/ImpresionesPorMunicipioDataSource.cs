using DataSource.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataSource.Datasources.Impresiones
{
    public class ImpresionesPorMunicipioDataSource 
    {
        public List<ImpresionesPorMunicipio> GetData(DateTime startDate, DateTime endDate, int municipioID)
        {
            return GenerateDummyData();
        }

        private List<ImpresionesPorMunicipio> GenerateDummyData()
        {

            var fechaCaptrua1 = DateTime.Now.Date;
            var fechaCaptrua2 = DateTime.Now.AddDays(-1).Date;
            var fechaCaptrua3 = DateTime.Now.AddDays(-2).Date;
            var fechaCaptrua4 = DateTime.Now.AddDays(-3).Date;

            var fechaPago1 = DateTime.Now.AddDays(1).Date;
            var fechaPago2 = DateTime.Now.AddDays(2).Date;

            List<ImpresionesPorMunicipio> listaImpresiones = new List<ImpresionesPorMunicipio>
                {

                    // Municipio 1, 4 registros
                    new ImpresionesPorMunicipio { Municipio = "Municipio 1", Impresiones = 100 },
                    new ImpresionesPorMunicipio { Municipio = "Municipio 1", Impresiones = 150 },
                    new ImpresionesPorMunicipio { Municipio = "Municipio 1", Impresiones = 200 },
                    new ImpresionesPorMunicipio { Municipio = "Municipio 1", Impresiones = 250 },

                    // Municipio 2, 4 registros
                    new ImpresionesPorMunicipio { Municipio = "Municipio 2", Impresiones = 300 },
                    new ImpresionesPorMunicipio { Municipio = "Municipio 2", Impresiones = 350 },
                    new ImpresionesPorMunicipio { Municipio = "Municipio 2", Impresiones = 400 },
                    new ImpresionesPorMunicipio { Municipio = "Municipio 2", Impresiones = 450 },

                    // Municipio 3, 4 registros
                    new ImpresionesPorMunicipio { Municipio = "Municipio 3", Impresiones = 500 },
                    new ImpresionesPorMunicipio { Municipio = "Municipio 3", Impresiones = 550 },
                    new ImpresionesPorMunicipio { Municipio = "Municipio 3", Impresiones = 600 },
                    new ImpresionesPorMunicipio { Municipio = "Municipio 3", Impresiones = 650 }
                };

                        return listaImpresiones;
                    }

            }
}
