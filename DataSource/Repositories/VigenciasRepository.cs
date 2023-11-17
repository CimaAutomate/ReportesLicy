using DataSource.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSource.Repositories
{
    public class VigenciasRepository
    {
        public List<Vigencia> GetVigencias()
        {
            return getDummy();
        }

        private List<Vigencia> getDummy()
        {
            return new List<Vigencia>(){
                new Vigencia()
                {
                  IdVigencia = 1,
                  Activo = true,
                  Anios = 1,
                  Monto = 1000,

                },
                new Vigencia()
                {
                  IdVigencia = 2,
                  Activo = true,
                  Anios = 2,
                  Monto = 2000,

                },
                new Vigencia()
                {
                  IdVigencia = 3,
                  Activo = true,
                  Anios = 3,
                  Monto = 3000,

                },
            }

        }

    }
}
