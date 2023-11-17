using DataSource.DatasourceModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSource.Datasources.Impresiones
{
    public class ImpresionesPorCapturistaDatasource
    {
        public List<ImpresionesPorCapturistaModel> GetData(DateTime fechaInicio, DateTime fechaFin, int municipioID, int CapturistaID)
        {
            return GetDummyData();
        }

        private List<ImpresionesPorCapturistaModel> GetDummyData()
        {
            return new List<ImpresionesPorCapturistaModel>
            {
                new ImpresionesPorCapturistaModel
                {
                    Capturista = "Capturista 1",
                    Impresiones = 250,
                    Municipio = "Municipio 1",
                },
                new ImpresionesPorCapturistaModel
                {
                    Capturista = "Capturista 1",
                    Impresiones = 300,
                    Municipio = "Municipio 2",
                },
                new ImpresionesPorCapturistaModel
                {
                    Capturista = "Capturista 1",
                    Impresiones = 350,
                    Municipio = "Municipio 3",
                }


            };

        }
    }
}
