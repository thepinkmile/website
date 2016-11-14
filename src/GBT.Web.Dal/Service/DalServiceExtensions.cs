using GBT.Web.Dal.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GBT.Web.Dal.Service
{
    public static class DalServiceExtensions
    {
        public static void ConfigureDatabaseService<T, TContext>(this IServiceCollection services, IConfiguration config)
            where T : DalConfigurator<TContext>, new()
            where TContext : DbContext
        {
            var configurator = new T
            {
                Config = config
            };
            configurator.ConfigureDatabaseService(services);

            services.AddSingleton<IDatabaseConfigurator>(configurator);
        }
    }
}