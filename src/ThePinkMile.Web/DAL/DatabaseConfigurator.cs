using System;
using System.Reflection;
using GBT.Web.Dal.Service;
using Microsoft.EntityFrameworkCore;

namespace ThePinkMile.Web.DAL
{
    public class DatabaseConfigurator<T> : DalConfigurator<T>
        where T : DbContext
    {
        public override void Configure(DbContextOptionsBuilder optionsBuilder)
        {
            switch (Dialect)
            {
                case "MSSQL":
                    optionsBuilder.UseSqlServer(ConnectionString, b => b.MigrationsAssembly(Assembly.GetEntryAssembly().FullName));
                    break;
                default:
                    throw new InvalidOperationException("An invalid database dialect is configured");
            }
        }
    }
}
