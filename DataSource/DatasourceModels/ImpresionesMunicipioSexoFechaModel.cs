using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSource.DatasourceModels
{
    public class ImpresionesMunicipioSexoFechaModel
    {
        public string Municipio { get; set; }
        public int IdMunicipio { get; set; }
        public int Impresiones { get; set; }
        public DateTime FechaDePago { get; set; }
        public DateTime FechaDeCaptura { get; set; }
        public string Genero { get; set; }
        public int IdGenero { get; set; }


    }
}
