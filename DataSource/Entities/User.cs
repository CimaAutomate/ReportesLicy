using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DataSource.Entities
{
    public class User
    {
        public int IdUsuario { get; set; }

        public string NombreUsuario { get; set; }

        public string Nombres { get; set; }

        public string ApellidoPaterno { get; set; }

        public string ApellidoMaterno { get; set; }

        public int fk_Rol { get; set; }

        public int? fk_Huella { get; set; }

        public string NombreCompleto => $"{Nombres} {ApellidoPaterno} {ApellidoMaterno}";

        public bool Eliminado { get; set; }

        public bool HasAuthFingerPrint { get; set; }

}
