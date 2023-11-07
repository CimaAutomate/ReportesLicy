using DataSource.Entities;
using DataSource.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSource.Repositories
{
    public interface IMunicipiosRepository : IRepository
    { 
        Task<List<Municipios>> GetAll();



    }

    public class MunicipiosRepository: IMunicipiosRepository
    {
        public Task<List<Municipios>> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
