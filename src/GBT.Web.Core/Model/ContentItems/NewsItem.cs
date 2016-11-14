using GBT.Web.Core.Bases;
using GBT.Web.Core.Model.PageItems;

namespace GBT.Web.Core.Model.ContentItems
{
    public class NewsItem : DatedEntity
    {
        public NewsSection Page { get; set; }
        public long PageId { get; set; }
    }
}
