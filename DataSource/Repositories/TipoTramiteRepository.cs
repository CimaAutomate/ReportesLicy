using DataSource.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSource.Repositories
{
    public class TipoTramiteRepository
    {
        public List<TipoTramite> GetTipoTramites()
        {
            return GetDummyData();
        }

        private List<TipoTramite> GetDummyData()
        {
            return new List<TipoTramite>()
            {
                new TipoTramite() {IdTipoTramite = 1, Descripcion = "Tramite 1"},
                new TipoTramite() {IdTipoTramite = 2, Descripcion = "Tramite 2"},
                new TipoTramite() {IdTipoTramite = 3, Descripcion = "Tramite 3"}
            };

        }
    }
}
