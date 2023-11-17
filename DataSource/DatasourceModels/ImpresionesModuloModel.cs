using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSource.DatasourceModels
{
    public class ImpresionesModuloModel
    {
        public DateTime Fecha { get; set; }
        public int Impresiones { get; set; }
        public string Modulo { get; set; }
        public string Capturista { get; set; }
        public string TipoImpresion { get; set;}

    }
}
