using DataSource.DatasourceModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSource.Datasources.Impresiones
{
    public class ImpresionesPorCapturistaSinHuellaDatasource
    {
        public List<ImpresionesPorCapturistaSinHuellaModel> GetImpresionesPorCapturistaSinHuellaModels(DateTime fechaInicio, DateTime fechaFin, int municipioID, int CapturistaID)
        {
            return GetDummyData();

        }

        private List <ImpresionesPorCapturistaSinHuellaModel> GetDummyData()
        {
            return new List<ImpresionesPorCapturistaSinHuellaModel>
            {
                new ImpresionesPorCapturistaSinHuellaModel
                {
                    Municipio = "Municipio 1",
                    Capturista = "Capturista 4",
                    ImpresionesSinhuella = 1
                },
                new ImpresionesPorCapturistaSinHuellaModel
                {
                    Municipio = "Municipio 1",
                    Capturista = "Capturista 2",
                    ImpresionesSinhuella = 3
                },
                new ImpresionesPorCapturistaSinHuellaModel
                {
                    Municipio = "Municipio 1",
                    Capturista = "Capturista 3",
                    ImpresionesSinhuella = 3
                },

                new ImpresionesPorCapturistaSinHuellaModel
                {
                    Municipio = "Municipio 2",
                    Capturista = "Capturista 2",
                    ImpresionesSinhuella = 2
                },
                new ImpresionesPorCapturistaSinHuellaModel
                {
                    Municipio = "Municipio 2",
                    Capturista = "Capturista 3",
                    ImpresionesSinhuella = 3
                },
                new ImpresionesPorCapturistaSinHuellaModel
                {
                    Municipio = "Municipio 2",
                    Capturista = "Capturista 4",
                    ImpresionesSinhuella = 4
                },

                new ImpresionesPorCapturistaSinHuellaModel
                {
                    Municipio = "Municipio 3",
                    Capturista = "Capturista 3",
                    ImpresionesSinhuella = 3
                },
                new ImpresionesPorCapturistaSinHuellaModel
                {
                    Municipio = "Municipio 3",
                    Capturista = "Capturista 4",
                    ImpresionesSinhuella = 4
                },
                new ImpresionesPorCapturistaSinHuellaModel
                {
                    Municipio = "Municipio 3",
                    Capturista = "Capturista 2",
                    ImpresionesSinhuella = 2
                },

            };

        }

    }
}
