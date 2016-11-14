using GBT.Web.Affiliates.Models.ContentItems;
using GBT.Web.Affiliates.Models.Pages;
using GBT.Web.Affiliates.Models.Users;
using GBT.Web.Affiliates.Relationships;
using GBT.Web.Core.Bases;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace GBT.Web.Affiliates
{
    public static class AffiliateDalRegistration
    {
        public static void RegisterAffiliateEntities(this ModelBuilder modelBuilder)
        {
            #region Model Types

            modelBuilder.Entity<Affiliate>(e =>
            {
                e.ToTable("Users");
                e.HasKey(u => u.Id);
                e.Property(u => u.Organisation).IsRequired();
                e.Property(u => u.Description).HasDefaultValue(null);
                e.Property(u => u.Marquee).HasDefaultValue(null);
                e.HasMany(u => u.ContactDetails).WithOne(d => d.Affiliate).OnDelete(DeleteBehavior.Cascade);
                e.HasOne(u => u.Avatar).WithOne().OnDelete(DeleteBehavior.Cascade);
                e.HasDiscriminator<string>("Type")
                    .HasValue<Affiliate>(nameof(Affiliate));
            });

            modelBuilder.Entity<AffiliateContactDetail>(e =>
            {
                e.ToTable("AffiliateContactDetails");
                e.HasKey(d => d.Id);
                e.HasOne(d => d.Affiliate).WithMany(a => a.ContactDetails).OnDelete(DeleteBehavior.Restrict);
                e.HasIndex(d => new { d.AffiliateId, d.DetailType }).IsUnique();
            });

            modelBuilder.Entity<AffilliatePage>(e =>
            {
                e.ToTable("Pages");
                e.HasKey(p => p.Id);
                e.HasOne(p => p.Affiliate).WithMany(a => a.Pages).IsRequired().OnDelete(DeleteBehavior.Restrict);
                e.HasDiscriminator<string>("Type")
                    .HasValue<AffilliatePage>(nameof(AffilliatePage));
            });

            #endregion

            #region Relationships

            modelBuilder.Entity<Relationship<Affiliate, LibraryItem>>(e =>
            {
                e.ToTable("UserLibraryAssocs");
                e.HasKey(r => new { r.ParentId, r.ChildId });
                e.HasOne(r => r.Parent).WithMany();
                e.HasOne(r => r.Child).WithMany();
                e.HasDiscriminator<string>("Type")
                    .HasValue<AffiliateDocument>(nameof(AffiliateDocument));
            });

            modelBuilder.Entity<Relationship<Affiliate, ContentItem>>(e =>
            {
                e.ToTable("UserContentAssocs");
                e.HasKey(r => new { r.ParentId, r.ChildId });
                e.HasOne(r => r.Parent).WithMany();
                e.HasOne(r => r.Child).WithMany();
                e.HasDiscriminator<string>("Type")
                    .HasValue<AffiliateStory>(nameof(AffiliateStory));
            });

            #endregion
        }
    }
}
