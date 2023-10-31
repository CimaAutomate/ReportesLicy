using DataSource.Common.Attributes;
using DataSource.Datasources.Impresiones;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Microsoft.Extensions.DependencyInjection
{
    public class DataSourceConfig
    {
        public static IServiceCollection AddDatasourceServices(IServiceCollection services)
        {
            return services;
        }

    }
}

