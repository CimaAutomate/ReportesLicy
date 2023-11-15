using DataSource.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataSource.Datasources.Impresiones
{
    public class ImpresionesPorMunicipioFechaDataSource 
    {
        public List<ImpresionesPorMunicipioFecha> GetData(DateTime startDate, DateTime endDate)
        {
            return GenerateDummyData();
        }

        private List<ImpresionesPorMunicipioFecha> GenerateDummyData()
        {

            var fechaCaptrua1 = DateTime.Now.Date;
            var fechaCaptrua2 = DateTime.Now.AddDays(-1).Date;
            var fechaCaptrua3 = DateTime.Now.AddDays(-2).Date;
            var fechaCaptrua4 = DateTime.Now.AddDays(-3).Date;

            var fechaPago1 = DateTime.Now.AddDays(1).Date;
            var fechaPago2 = DateTime.Now.AddDays(2).Date;

            List<ImpresionesPorMunicipioFecha> listaImpresiones = new List<ImpresionesPorMunicipioFecha>
                {

                    // Municipio 1, 4 registros
                    new ImpresionesPorMunicipioFecha { Municipio = "Municipio 1", Impresiones = 100, FechaDeCaptura = fechaCaptrua1, FechaDePago = fechaPago1 },
                    new ImpresionesPorMunicipioFecha { Municipio = "Municipio 1", Impresiones = 150, FechaDeCaptura = fechaCaptrua1, FechaDePago = fechaPago1 },
                    new ImpresionesPorMunicipioFecha { Municipio = "Municipio 1", Impresiones = 200, FechaDeCaptura = fechaCaptrua2, FechaDePago = fechaPago2 },
                    new ImpresionesPorMunicipioFecha { Municipio = "Municipio 1", Impresiones = 250, FechaDeCaptura = fechaCaptrua2, FechaDePago = fechaPago2
    },

                    // Municipio 2, 4 registros
                    new ImpresionesPorMunicipioFecha { Municipio = "Municipio 2", Impresiones = 300, FechaDeCaptura = fechaCaptrua1, FechaDePago = fechaPago1 },
                    new ImpresionesPorMunicipioFecha { Municipio = "Municipio 2", Impresiones = 350, FechaDeCaptura = fechaCaptrua2, FechaDePago = fechaPago1 },
                    new ImpresionesPorMunicipioFecha { Municipio = "Municipio 2", Impresiones = 400, FechaDeCaptura = fechaCaptrua3, FechaDePago = fechaPago2 },
                    new ImpresionesPorMunicipioFecha { Municipio = "Municipio 2", Impresiones = 450, FechaDeCaptura = fechaCaptrua4, FechaDePago = fechaPago2 },

                    // Municipio 3, 4 registros
                    new ImpresionesPorMunicipioFecha { Municipio = "Municipio 3", Impresiones = 500, FechaDeCaptura = fechaCaptrua1, FechaDePago = fechaPago1 },
                    new ImpresionesPorMunicipioFecha { Municipio = "Municipio 3", Impresiones = 550, FechaDeCaptura = fechaCaptrua2, FechaDePago = fechaPago1 },
                    new ImpresionesPorMunicipioFecha { Municipio = "Municipio 3", Impresiones = 600, FechaDeCaptura = fechaCaptrua3, FechaDePago = fechaPago2 },
                    new ImpresionesPorMunicipioFecha { Municipio = "Municipio 3", Impresiones = 650, FechaDeCaptura = fechaCaptrua4, FechaDePago = fechaPago2 }
                };

                        return listaImpresiones;
                    }

            }
}
