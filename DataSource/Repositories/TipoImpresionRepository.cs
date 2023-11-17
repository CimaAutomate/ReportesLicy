using DataSource.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSource.Repositories
{
    public class TipoImpresionRepository
    {
        public List<TipoImpresion> GetTipoImpresion()
        {
          return GetDummyData();
        }

        private static List<TipoImpresion> GetDummyData()
        {
            List<TipoImpresion> tipoImpresion = new List<TipoImpresion>();
            tipoImpresion.Add(new TipoImpresion { Id = 1, Descripcion = "Impresión" });
            tipoImpresion.Add(new TipoImpresion { Id = 2, Descripcion = "Reimpresión sin cobro" });
            tipoImpresion.Add(new TipoImpresion { Id = 2, Descripcion = "Impresión con cobro" });
            return tipoImpresion;
        }
    }
}
