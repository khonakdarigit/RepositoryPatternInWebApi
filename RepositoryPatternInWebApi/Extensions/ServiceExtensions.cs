using Microsoft.EntityFrameworkCore;
using RepositoryPatternInWebApi.Contracts;
using RepositoryPatternInWebApi.Entities;
using RepositoryPatternInWebApi.Repository;

namespace RepositoryPatternInWebApi.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureMySqlContext(this IServiceCollection services, IConfiguration config)
        {
            var connectionString = config["mySqlConnectionString:AccountOwner"];
            services.AddDbContext<RepositoryContext>(o => o.UseMySql(connectionString,
                MySqlServerVersion.LatestSupportedServerVersion));
        }

        public static void ConfigureRepositoryWrapper(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();
        }
    }
}
