using System.Collections.Generic;
using System.Linq;
using GBT.Web.Affiliates.Models.ContentItems;
using GBT.Web.Affiliates.Models.Users;
using GBT.Web.Core.Bases;
using GBT.Web.Core.Model.LibraryItems;

namespace GBT.Web.Affiliates.Models.Pages
{
    public class AffilliatePage : Page
    {
        public Affiliate Affiliate { get; set; }
        public long AffiliateId { get; set; }

        public new string Title => Affiliate.Organisation;

        public Image Logo => Affiliate.Logo;

        public ICollection<AffiliateContactDetail> ContactDetails => Affiliate.ContactDetails;

        public new string Description => Affiliate.Description;

        public new string FullText => Affiliate.FullText;

        public new string Marquee => Affiliate.Marquee;

        public new ICollection<Document> Documents => Affiliate.Documents.Select(ad => ad.Child).ToList();
    }
}
