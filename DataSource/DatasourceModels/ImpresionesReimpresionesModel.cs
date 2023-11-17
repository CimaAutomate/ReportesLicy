using DataSource.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSource.DatasourceModels
{
    public class ImpresionesReimpresionesModel
    {
        public string ModuloTramite { get; set; }
        public string Capturista { get; set; }
        public string ModuloImpresion { get; set; }
        public string UsuarioImpresion { get; set; }
        public DateTime Fecha { get; set; }
        public string Tipo { get; set; }
        public string Folio { get; set; }
        public string NumeroLicencia { get; set; }
        public string Motivo { get; set; }

    }
}
