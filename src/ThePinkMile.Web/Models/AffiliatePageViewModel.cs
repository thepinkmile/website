using System.Collections.Generic;
using GBT.Web.Affiliates.Models.ContentItems;

namespace ThePinkMile.Web.Models
{
    public class AffiliatePageViewModel : StandardPageViewModel
    {
        public ICollection<AffiliateContactDetail> ContactDetails { get; set; }
    }
}
