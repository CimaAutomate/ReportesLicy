using DataSource.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSource.Repositories
{
    public class UsersRepository
    {

        public List<User> GetUsers()
        {
            return GetDummyData();
        }

        private List<User> GetDummyData()
        {
            return new List<User>()
            {
                new User()
                {
                  IdUsuario = 1,
                  NombreUsuario = "Usuario 1",
                  Nombres = "Nombres 1",
                  ApellidoPaterno = "Apellido Paterno 1",
                  ApellidoMaterno = "Apellido Materno 1",
                  fk_Rol = 1,
                  fk_Huella = 1,
                  Eliminado = false,
                  HasAuthFingerPrint = true
                },
                new User()
                {
                  IdUsuario = 2,
                  NombreUsuario = "Usuario 2",
                  Nombres = "Nombres 2",
                  ApellidoPaterno = "Apellido Paterno 2",
                  ApellidoMaterno = "Apellido Materno 2",
                  fk_Rol = 2,
                  fk_Huella = 2,
                  Eliminado = false,
                  HasAuthFingerPrint = true
                },
                new User()
                {
                  IdUsuario = 3,
                  NombreUsuario = "Usuario 3",
                  Nombres = "Nombres 3",
                  ApellidoPaterno = "Apellido Paterno 3",
                  ApellidoMaterno = "Apellido Materno 3",
                  fk_Rol = 3,
                  fk_Huella = 3,
                  Eliminado = false,
                  HasAuthFingerPrint = true
                },
            };  
        }
    }
}
