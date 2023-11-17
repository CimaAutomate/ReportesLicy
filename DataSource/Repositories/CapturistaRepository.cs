using DataSource.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSource.Repositories
{
    public class CapturistaRepository
    {
        public List<User> GetCapturistas()
        {
            return GetDummyData();
        }

        private List<User> GetDummyData()
        {
            return new List<User>
            {
                new User
                {
                    IdUsuario = 1,
                    Nombres = "Capturista 1",
                    ApellidoPaterno = "Apellido Paterno 1",
                    ApellidoMaterno = "Apellido Materno 1"
                },
                new User
                {
                    IdUsuario = 2,
                    Nombres = "Capturista 2",
                    ApellidoPaterno = "Apellido Paterno 2",
                    ApellidoMaterno = "Apellido Materno 2"
                },
                new User
                {
                    IdUsuario = 3,
                    Nombres = "Capturista 3",
                    ApellidoPaterno = "Apellido Paterno 3",
                    ApellidoMaterno = "Apellido Materno 3"
                }
            };
           
        }
    }
}
