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
        }

    }
}

