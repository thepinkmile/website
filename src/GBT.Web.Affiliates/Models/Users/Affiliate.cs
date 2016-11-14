using System.Collections.Generic;
using GBT.Web.Affiliates.Models.ContentItems;
using GBT.Web.Affiliates.Relationships;
using GBT.Web.Core.Model.LibraryItems;
using GBT.Web.Core.Model.Users;

namespace GBT.Web.Affiliates.Models.Users
{
    public class Affiliate : Visitor
    {
        public string Organisation { get; set; }

        public ICollection<AffiliateContactDetail> ContactDetails { get; set; }

        public Image Logo { get; set; }

        public string Description { get; set; }

        public string FullText { get; set; }

        public string Marquee { get; set; }

        public ICollection<AffiliateStory> Stories { get; set; }

        public ICollection<AffiliateDocument> Documents { get; set; }
    }
}
