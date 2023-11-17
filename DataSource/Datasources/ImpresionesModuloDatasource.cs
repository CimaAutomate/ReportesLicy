using DataSource.DatasourceModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSource.Datasources
{
    public class ImpresionesModuloDatasource
    {
        public List<ImpresionesModuloModel> GetImpresionesModuloModel(int municipioId, int tipoTrmiteId, int CapturistaId)
        {
            return GenerarDatosEstaticos();
        }

        private static List<ImpresionesModuloModel> GenerarDatosEstaticos()
        {
            return new List<ImpresionesModuloModel>
    {
        new ImpresionesModuloModel { Fecha = new DateTime(2023, 1, 1), Impresiones = 10, Modulo = "Modulo1", Capturista = "Capturista1", TipoImpresion = "Tipo1" },
        new ImpresionesModuloModel { Fecha = new DateTime(2023, 1, 2), Impresiones = 15, Modulo = "Modulo1", Capturista = "Capturista2", TipoImpresion = "Tipo2" },
        new ImpresionesModuloModel { Fecha = new DateTime(2023, 1, 3), Impresiones = 20, Modulo = "Modulo2", Capturista = "Capturista3", TipoImpresion = "Tipo3" },
        new ImpresionesModuloModel { Fecha = new DateTime(2023, 1, 4), Impresiones = 25, Modulo = "Modulo2", Capturista = "Capturista4", TipoImpresion = "Tipo4" },
        new ImpresionesModuloModel { Fecha = new DateTime(2023, 1, 5), Impresiones = 30, Modulo = "Modulo3", Capturista = "Capturista5", TipoImpresion = "Tipo1" },
        new ImpresionesModuloModel { Fecha = new DateTime(2023, 1, 6), Impresiones = 35, Modulo = "Modulo3", Capturista = "Capturista1", TipoImpresion = "Tipo2" },
        new ImpresionesModuloModel { Fecha = new DateTime(2023, 1, 7), Impresiones = 40, Modulo = "Modulo1", Capturista = "Capturista2", TipoImpresion = "Tipo3" },
        new ImpresionesModuloModel { Fecha = new DateTime(2023, 1, 8), Impresiones = 45, Modulo = "Modulo1", Capturista = "Capturista3", TipoImpresion = "Tipo4" },
        new ImpresionesModuloModel { Fecha = new DateTime(2023, 1, 9), Impresiones = 50, Modulo = "Modulo2", Capturista = "Capturista4", TipoImpresion = "Tipo1" },
        new ImpresionesModuloModel { Fecha = new DateTime(2023, 1, 10), Impresiones = 55, Modulo = "Modulo2", Capturista = "Capturista5", TipoImpresion = "Tipo2" },
        new ImpresionesModuloModel { Fecha = new DateTime(2023, 1, 11), Impresiones = 60, Modulo = "Modulo3", Capturista = "Capturista1", TipoImpresion = "Tipo3" },
        new ImpresionesModuloModel { Fecha = new DateTime(2023, 1, 12), Impresiones = 65, Modulo = "Modulo3", Capturista = "Capturista2", TipoImpresion = "Tipo4" },
        new ImpresionesModuloModel { Fecha = new DateTime(2023, 1, 13), Impresiones = 70, Modulo = "Modulo1", Capturista = "Capturista3", TipoImpresion = "Tipo1" },
        new ImpresionesModuloModel { Fecha = new DateTime(2023, 1, 14), Impresiones = 75, Modulo = "Modulo1", Capturista = "Capturista4", TipoImpresion = "Tipo2" },
        new ImpresionesModuloModel { Fecha = new DateTime(2023, 1, 15), Impresiones = 80, Modulo = "Modulo2", Capturista = "Capturista5", TipoImpresion = "Tipo3" },
        new ImpresionesModuloModel { Fecha = new DateTime(2023, 1, 16), Impresiones = 85, Modulo = "Modulo2", Capturista = "Capturista1", TipoImpresion = "Tipo4" }
            };
        }
    }
}
