using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using GBT.Web.Affiliates.Models.ContentItems;
using GBT.Web.Affiliates.Models.Pages;
using GBT.Web.Affiliates.Relationships;
using GBT.Web.Core.Bases;
using GBT.Web.Core.DataAnnotations;
using GBT.Web.Core.Model.LibraryItems;
using GBT.Web.Core.Model.Users;

namespace GBT.Web.Affiliates.Models.Users
{
    public class Affiliate : Visitor
    {
        public Affiliate()
        {
            ContactDetails = new HashSet<AffiliateContactDetail>();
            Stories = new HashSet<AffiliateStory>();
            Documents = new HashSet<AffiliateDocument>();
            Pages = new HashSet<AffilliatePage>();
        }

        [MaxLength(255)]
        public string Organisation { get; set; }

        [MinCount(1)]
        public ICollection<AffiliateContactDetail> ContactDetails { get; set; }

        [ImageSizeConstraint(MinWidth = 160, MaxWidth = 160)]
        public Image Logo { get; set; }

        public string Description { get; set; }

        public string FullText { get; set; }

        public string Marquee { get; set; }

        public ICollection<AffiliateStory> Stories { get; set; }

        public ICollection<AffiliateDocument> Documents { get; set; }

        public ICollection<AffilliatePage> Pages { get; set; }

        public ICollection<Page> SponsoredPages { get; set; }
    }
}
