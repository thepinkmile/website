using System.Collections.Generic;

namespace GBT.Web.Core.Bases
{
    public abstract class ListingPage<T> : Page
        where T : Identity
    {
        public ICollection<T> Items { get; set; }
    }
}
