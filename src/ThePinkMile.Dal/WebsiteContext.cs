using GBT.Web.Affiliates;
using GBT.Web.Core;
using GBT.Web.Core.Bases;
using GBT.Web.Dal.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ThePinkMile.Dal
{
    public class WebsiteContext : DbContext
    {
        private readonly IDatabaseConfigurator _configurator;

        public WebsiteContext(DbContextOptions options, IDatabaseConfigurator configurator)
            : base(options)
        {
            _configurator = configurator;
        }

        public DbSet<Page> Pages;

        public DbSet<ContentItem> ContentItems;

        public DbSet<LibraryItem> LibraryItems;

        public DbSet<User> Users;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                _configurator.Configure(optionsBuilder);
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.RegisterCoreEntities();
            modelBuilder.RegisterAffiliateEntities();
        }
    }
}
