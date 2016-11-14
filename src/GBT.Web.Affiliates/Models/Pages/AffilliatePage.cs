using GBT.Web.Affiliates.Models.Users;
using GBT.Web.Core.Bases;

namespace GBT.Web.Affiliates.Models.Pages
{
    public class AffilliatePage : Page
    {
        public Affiliate Affiliate { get; set; }
        public long AffiliateId { get; set; }
    }
}
