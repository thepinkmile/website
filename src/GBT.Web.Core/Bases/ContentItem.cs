using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using GBT.Web.Core.Relationships;

namespace GBT.Web.Core.Bases
{
    public abstract class ContentItem : Identity
    {
        [MaxLength(255)]
        public string Title { get; set; }

        public string Description { get; set; }

        public string FullText { get; set; }

        public ICollection<ContentDocument> Documents { get; set; }

        public ICollection<ContentImage> Images { get; set; }
    }
}
