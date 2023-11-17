using DataSource.DatasourceModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSource.Datasources.Impresiones
{
    public class ImpresionesMunicipioTipoLicenciaFechaDataSource
    {
        public List<ImpresionesMunicipioTipoLicenciaFechaModel> GetData(DateTime fechaInicio, DateTime fechaFin, int municipioID, int TipoID)
        {
            return GetDummyData();
        }

        private static List<ImpresionesMunicipioTipoLicenciaFechaModel> GetDummyData()
        {
            var listaImpresiones = new List<ImpresionesMunicipioTipoLicenciaFechaModel>();

            // Supongamos que estas son las fechas que mencionaste
            DateTime fechaCaptrua1 = new DateTime(2023, 1, 1); // Ejemplo, ajusta según tus necesidades
            DateTime fechaCaptrua2 = new DateTime(2023, 1, 2); // Ejemplo, ajusta según tus necesidades
            DateTime fechaCaptrua3 = new DateTime(2023, 1, 3); // Ejemplo, ajusta según tus necesidades
            DateTime fechaCaptrua4 = new DateTime(2023, 1, 4); // Ejemplo, ajusta según tus necesidades

            DateTime fechaPago1 = new DateTime(2023, 1, 10); // Ejemplo, ajusta según tus necesidades
            DateTime fechaPago2 = new DateTime(2023, 1, 11); // Ejemplo, ajusta según tus necesidades

            // Datos para Municipio 1
            listaImpresiones.Add(new ImpresionesMunicipioTipoLicenciaFechaModel { Municipio = "Municipio 1", Impresiones = 100, FechaDeCaptura = fechaCaptrua1, FechaDePago = fechaPago1, TipoLicencia = "Tramite 1" });
            listaImpresiones.Add(new ImpresionesMunicipioTipoLicenciaFechaModel { Municipio = "Municipio 1", Impresiones = 150, FechaDeCaptura = fechaCaptrua1, FechaDePago = fechaPago1, TipoLicencia = "Tramite 2" });
            listaImpresiones.Add(new ImpresionesMunicipioTipoLicenciaFechaModel { Municipio = "Municipio 1", Impresiones = 200, FechaDeCaptura = fechaCaptrua2, FechaDePago = fechaPago2, TipoLicencia = "Tramite 3" });
            listaImpresiones.Add(new ImpresionesMunicipioTipoLicenciaFechaModel { Municipio = "Municipio 1", Impresiones = 250, FechaDeCaptura = fechaCaptrua2, FechaDePago = fechaPago2, TipoLicencia = "Tramite 1" });

            // Datos para Municipio 2
            listaImpresiones.Add(new ImpresionesMunicipioTipoLicenciaFechaModel { Municipio = "Municipio 2", Impresiones = 300, FechaDeCaptura = fechaCaptrua1, FechaDePago = fechaPago1, TipoLicencia = "Tramite 2" });
            listaImpresiones.Add(new ImpresionesMunicipioTipoLicenciaFechaModel { Municipio = "Municipio 2", Impresiones = 350, FechaDeCaptura = fechaCaptrua2, FechaDePago = fechaPago1, TipoLicencia = "Tramite 3" });
            listaImpresiones.Add(new ImpresionesMunicipioTipoLicenciaFechaModel { Municipio = "Municipio 2", Impresiones = 400, FechaDeCaptura = fechaCaptrua3, FechaDePago = fechaPago2, TipoLicencia = "Tramite 1" });
            listaImpresiones.Add(new ImpresionesMunicipioTipoLicenciaFechaModel { Municipio = "Municipio 2", Impresiones = 450, FechaDeCaptura = fechaCaptrua4, FechaDePago = fechaPago2, TipoLicencia = "Tramite 2" });

            // Datos para Municipio 3
            listaImpresiones.Add(new ImpresionesMunicipioTipoLicenciaFechaModel { Municipio = "Municipio 3", Impresiones = 500, FechaDeCaptura = fechaCaptrua1, FechaDePago = fechaPago1, TipoLicencia = "Tramite 3" });
            listaImpresiones.Add(new ImpresionesMunicipioTipoLicenciaFechaModel { Municipio = "Municipio 3", Impresiones = 550, FechaDeCaptura = fechaCaptrua2, FechaDePago = fechaPago1, TipoLicencia = "Tramite 1" });
            listaImpresiones.Add(new ImpresionesMunicipioTipoLicenciaFechaModel { Municipio = "Municipio 3", Impresiones = 600, FechaDeCaptura = fechaCaptrua3, FechaDePago = fechaPago2, TipoLicencia = "Tramite 2" });
            listaImpresiones.Add(new ImpresionesMunicipioTipoLicenciaFechaModel { Municipio = "Municipio 3", Impresiones = 650, FechaDeCaptura = fechaCaptrua4, FechaDePago = fechaPago2, TipoLicencia = "Tramite 3" });

            return listaImpresiones;
        }


    }
}
