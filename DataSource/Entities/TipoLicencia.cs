using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSource.Entities
{
    public class TipoLicencia
    {
        public int IdTipoLicencia { get; set; }
        public string Descripcion { get; set; }
        public bool Activo { get; set; }
        public string Clave { get; set; }
        public string NombreCorto { get; set; }
        public string Autoriza { get; set; }
    }
}
