using DataSource.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSource.Repositories
{
    public class SexosRepository
    {
        public List<Sexo> GetSexos()
        {
            return _sexos;
        }

        private static List<Sexo> _sexos = new List<Sexo>()
        {
            new Sexo() { IdSexo = 1, Descripcion = "Masculino" },
            new Sexo() { IdSexo = 2, Descripcion = "Femenino" }
        };

    }
}
