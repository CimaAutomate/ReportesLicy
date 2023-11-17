using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSource.Entities
{
    public class Vigencia
    {
        public int IdVigencia { get; set; }
        public int Anios { get; set; }
        public decimal Monto { get; set; }
        public bool Activo { get; set; }
    }
}
