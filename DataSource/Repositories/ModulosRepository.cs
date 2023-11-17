using DataSource.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSource.Repositories
{
    public class ModulosRepository
    {
        public List<Modulo> GetModulos()
        {
            return GetDummy();
        }

        private List<Modulo> GetDummy()
        {
            return new List<Modulo>
            {
                new Modulo{
                    IdModulo = 1,
                    Nombre = "Modulo 1",
                },
                new Modulo
                {
                    IdModulo = 2,
                    Nombre = "Modulo 2",
                },
                new Modulo
                {
                    IdModulo = 3,
                    Nombre = "Modulo 3",
                },
                new Modulo
                {
                    IdModulo = 4,
                    Nombre = "Modulo 4",
                }

            };

        }
    }
}
