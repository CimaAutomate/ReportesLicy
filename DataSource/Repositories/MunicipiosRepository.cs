using DataSource.Entities;
using DataSource.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSource.Repositories
{
    public class MunicipiosRepository
    {
        public List<Municipios> GetAll()
        {
            return GetDummnyMunicipios();
        }

        public static List<Municipios> GetDummnyMunicipios()
        {
            return DummyMunicipios;

        }

        public static List<Municipios> DummyMunicipios = new List<Municipios>
            {
                new Municipios{ IdMunicipio = 1, Nombre = "Municipio 1" },
                new Municipios{ IdMunicipio = 2, Nombre = "Municipio 2" },
                new Municipios{ IdMunicipio = 3, Nombre = "Municipio 3" },
                new Municipios{ IdMunicipio = 4, Nombre = "Municipio 4" },
                new Municipios{ IdMunicipio = 5, Nombre = "Municipio 5" }
            };
    }
}
