using System.ComponentModel;
using GBT.Web.Core.Bases;
using GBT.Web.Core.Model.ContentItems;
using GBT.Web.Core.TypeAnnotation;

namespace GBT.Web.Core.Model.PageItems
{
    [DisplayName("News Section"), Navigation(Controller = "News", Action = "Index")]
    public class NewsSection : ListingPage<NewsItem>
    {
    }
}
