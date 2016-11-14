using System.Collections.Generic;
using GBT.Web.Core.Model.ContentItems;
using GBT.Web.Core.Model.LibraryItems;

namespace ThePinkMile.Web.Models
{
    public class StandardPageViewModel
    {
        public string ShortTitle { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string FullText { get; set; }

        public string Marquee { get; set; }

        public ICollection<Story> Stories { get; set; }

        public ICollection<Document> Documents { get; set; }

        public Poll Poll { get; set; }
    }
}
