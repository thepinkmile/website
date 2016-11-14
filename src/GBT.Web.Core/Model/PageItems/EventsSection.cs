using System.ComponentModel;
using GBT.Web.Core.Bases;
using GBT.Web.Core.Model.ContentItems;
using GBT.Web.Core.TypeAnnotation;

namespace GBT.Web.Core.Model.PageItems
{
    [DisplayName("Events Section"), Navigation(Controller = "Events", Action = "Index")]
    public class EventsSection : ListingPage<EventItem>
    {
    }
}
