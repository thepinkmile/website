using GBT.Web.Affiliates.Models.Users;
using GBT.Web.Core;
using GBT.Web.Core.Bases;

namespace GBT.Web.Affiliates.Models.ContentItems
{
    public class AffiliateContactDetail : Identity
    {
        public Affiliate Affiliate { get; set; }
        public long AffiliateId { get; set; }

        public ContactType DetailType { get; set; }

        public string Value { get; set; }

        public string Link { get; set; }
    }
}
