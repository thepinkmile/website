using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using GBT.Web.Core.DataAnnotations;
using GBT.Web.Core.Model.ContentItems;
using GBT.Web.Core.Relationships;

namespace GBT.Web.Core.Bases
{
    public abstract class Page : Identity
    {
        protected Page()
        {
            Stories = new HashSet<PageStory>();
            Documents = new HashSet<PageDocument>();
            Polls = new HashSet<Poll>();
            ChildPages = new HashSet<Page>();
        }

        [MaxLength(255)]
        public string Title { get; set; }

        [MaxLength(150)]
        public string ShortTitle { get; set; }

        public string Description { get; set; }

        public string FullText { get; set; }

        public string Marquee { get; set; }

        [MaxCount(3)]
        public ICollection<PageStory> Stories { get; set; }

        public ICollection<PageDocument> Documents { get; set; }

        [MaxCount(2)]
        public ICollection<Poll> Polls { get; set; }

        #region Hierarchy

        public Page ParentPage { get; set; }
        public long? ParentPageId { get; set; }
        
        public ICollection<Page> ChildPages { get; set; }

        #endregion
    }
}
