using DataSource.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSource.Repositories
{
    public class TipoLicenciaRepository
    {
        public List<TipoLicencia> GetTipoLicencias()
        {
            return GetDummy();
        }

        private static List<TipoLicencia> GetDummy()
        {
            // Create a list to hold the dummy data
            List<TipoLicencia> dummyList = new List<TipoLicencia>();

            // Add a few dummy TipoLicencia objects to the list
            dummyList.Add(new TipoLicencia { IdTipoLicencia = 1, Descripcion = "Tipo 1", Activo = true, Clave = "C1", NombreCorto = "T1", Autoriza = "Autor1" });
            dummyList.Add(new TipoLicencia { IdTipoLicencia = 2, Descripcion = "Tipo 2", Activo = false, Clave = "C2", NombreCorto = "T2", Autoriza = "Autor2" });
            dummyList.Add(new TipoLicencia { IdTipoLicencia = 3, Descripcion = "Tipo 3", Activo = true, Clave = "C3", NombreCorto = "T3", Autoriza = "Autor3" });

            // Return the list of dummy data
            return dummyList;
        }

    }
}
