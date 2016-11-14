using GBT.Web.Core.Bases;
using GBT.Web.Core.Model.PageItems;

namespace GBT.Web.Core.Model.ContentItems
{
    public class EventItem : DatedEntity
    {
        public EventsSection Page { get; set; }
        public long PageId { get; set; }
    }
}
