using GBT.Web.Core.Bases;
using GBT.Web.Core.Model.ContentItems;
using GBT.Web.Core.Model.LibraryItems;
using GBT.Web.Core.Model.PageItems;
using GBT.Web.Core.Model.Statistics;
using GBT.Web.Core.Model.Users;
using GBT.Web.Core.Relationships;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace GBT.Web.Core
{
    public static class CoreDalRegistration
    {
        public static void RegisterCoreEntities(this ModelBuilder modelBuilder)
        {
            #region Model Types

            modelBuilder.Entity<Identity>(e =>
            {
                e.Property(i => i.Enabled).IsRequired().HasDefaultValue(false);
                e.Property(i => i.Timestamp).ValueGeneratedOnAddOrUpdate();
            });

            modelBuilder.Entity<Page>(e =>
            {
                e.ToTable("Pages");
                e.HasKey(p => p.Id);
                e.Property(p => p.Title).IsRequired();
                e.Property(p => p.Description).HasDefaultValue(null);
                e.Property(p => p.Marquee).HasDefaultValue(null);
                e.Property(p => p.Ordinal).HasDefaultValue(0);
                e.HasOne(p => p.ParentPage).WithMany(pp => pp.ChildPages).OnDelete(DeleteBehavior.Restrict);
                e.HasMany(p => p.Documents).WithOne(r => r.Parent).OnDelete(DeleteBehavior.Cascade);
                e.HasMany(p => p.Polls).WithOne(q => q.Page).OnDelete(DeleteBehavior.Cascade);
                e.HasDiscriminator<string>("Type")
                    .HasValue<NavigationRoot>(nameof(NavigationRoot))
                    .HasValue<StandardPage>(nameof(StandardPage))
                    .HasValue<NewsSection>(nameof(NewsSection))
                    .HasValue<EventsSection>(nameof(EventsSection))
                    .HasValue<LinkedPage>(nameof(LinkedPage));
            });

            modelBuilder.Entity<NewsSection>(e =>
            {
                e.HasMany(n => n.Items).WithOne(i => i.Page).OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<EventsSection>(e =>
            {
                e.HasMany(n => n.Items).WithOne(i => i.Page).OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<LibraryItem>(e =>
            {
                e.ToTable("LibraryItems");
                e.HasKey(d => d.Id);
                e.HasDiscriminator<string>("Type")
                    .HasValue<Document>(nameof(Document))
                    .HasValue<Image>(nameof(Image));
            });

            modelBuilder.Entity<ContentItem>(e =>
            {
                e.ToTable("ContentItems");
                e.HasKey(c => c.Id);
                e.Property(c => c.Title).IsRequired();
                e.Property(c => c.Description).HasDefaultValue(null);
                e.HasMany(c => c.Documents).WithOne(r => r.Parent);
                e.HasDiscriminator<string>("Type")
                    .HasValue<NewsItem>(nameof(NewsItem))
                    .HasValue<EventItem>(nameof(EventItem))
                    .HasValue<Poll>(nameof(Poll))
                    .HasValue<PollAnswer>(nameof(PollAnswer))
                    .HasValue<Story>(nameof(Story));
            });

            modelBuilder.Entity<NewsItem>(e =>
            {
                e.HasOne(n => n.Page).WithMany(p => p.Items).OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<EventItem>(e =>
            {
                e.HasOne(n => n.Page).WithMany(p => p.Items).OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<Poll>(e =>
            {
                e.HasMany(p => p.Answers).WithOne(a => a.Poll).OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<PollAnswer>(e =>
            {
                e.HasOne(a => a.Poll).WithMany(p => p.Answers).OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<Statistic>(e =>
            {
                e.ToTable("Statistics");
                e.HasKey(s => new { s.ParentId, s.ChildId });
                e.HasDiscriminator<string>("Type")
                    .HasValue<PollStatistic>(nameof(PollStatistic));
            });

            modelBuilder.Entity<PollStatistic>(e =>
            {
                e.HasOne(s => s.Parent).WithMany().OnDelete(DeleteBehavior.Restrict);
                e.HasOne(s => s.Child).WithMany().OnDelete(DeleteBehavior.Restrict);
                e.HasOne(s => s.Response).WithMany().OnDelete(DeleteBehavior.Restrict);
                e.HasIndex(s => new { s.ParentId, s.PersonId }).IsUnique();
            });

            modelBuilder.Entity<User>(e =>
            {
                e.ToTable("Users");
                e.HasKey(u => u.Id);
                e.Property(u => u.Email).IsRequired();
                e.HasOne(u => u.Avatar).WithOne().OnDelete(DeleteBehavior.Cascade);
                e.HasDiscriminator<string>("Type")
                    .HasValue<Visitor>(nameof(Visitor))
                    .HasValue<Administrator>(nameof(Administrator));
            });

            #endregion

            #region Relationships

            modelBuilder.Entity<Relationship<Page, LibraryItem>>(e =>
            {
                e.ToTable("PageLibraryAssocs");
                e.HasKey(r => new { r.ParentId, r.ChildId });
                e.HasOne(r => r.Parent).WithMany().OnDelete(DeleteBehavior.Restrict);
                e.HasOne(r => r.Child).WithMany().OnDelete(DeleteBehavior.Restrict);
                e.HasDiscriminator<string>("Type")
                    .HasValue<PageDocument>(nameof(PageDocument))
                    .HasValue<PageStory>(nameof(PageStory));
            });

            modelBuilder.Entity<Relationship<ContentItem, LibraryItem>>(e =>
            {
                e.ToTable("ContentLibraryAssocs");
                e.HasKey(r => new { r.ParentId, r.ChildId });
                e.HasOne(r => r.Parent).WithMany().OnDelete(DeleteBehavior.Restrict);
                e.HasOne(r => r.Child).WithMany().OnDelete(DeleteBehavior.Restrict);
                e.HasDiscriminator<string>("Type")
                    .HasValue<NewsDocument>(nameof(NewsDocument))
                    .HasValue<EventDocument>(nameof(EventDocument))
                    .HasValue<NewsImage>(nameof(NewsImage))
                    .HasValue<EventImage>(nameof(EventImage));
            });

            #endregion
        }
    }
}
