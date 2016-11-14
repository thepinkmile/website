using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace GBT.Web.Dal.Interfaces
{
    public interface IDatabaseConfigurator
    {
        void ConfigureDatabaseService(IServiceCollection services);
        void Configure(DbContextOptionsBuilder optionsBuilder);
    }
}