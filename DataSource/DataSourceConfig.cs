using DataSource.Common.Attributes;
using DataSource.Datasources.Impresiones;
using DataSource.Repositories;
using DataSource.Repositories.Base;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Microsoft.Extensions.DependencyInjection
{
    public class DataSourceConfig
    {
        public static IServiceCollection AddDatasourceServices(IServiceCollection services)
        {

            ConfigureRepositoriesInyection(services);

            return services;


        }

        private static void ConfigureRepositoriesInyection (IServiceCollection services)
        {
            services.AddScoped<IMunicipiosRepository, MunicipiosRepository>();
        }

    }
}

