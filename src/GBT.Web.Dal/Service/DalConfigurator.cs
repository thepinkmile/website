using GBT.Web.Dal.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GBT.Web.Dal.Service
{
    public abstract class DalConfigurator<T> : IDatabaseConfigurator
        where T : DbContext
    {
        public IConfiguration Config { get; set; }

        public void ConfigureDatabaseService(IServiceCollection services)
        {
            services.AddDbContext<T>(Configure);
        }

        protected string ConnectionString => Config?.GetConnectionString("DefaultConnection");

        protected string Dialect => Config?.GetSection("Database")["Dialect"];

        public abstract void Configure(DbContextOptionsBuilder optionsBuilder);
    }
}
