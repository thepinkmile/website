using System.Collections.Generic;
using GBT.Web.Core.Bases;
using GBT.Web.Core.DataAnnotations;

namespace GBT.Web.Core.Model.ContentItems
{
    public class Poll : ContentItem
    {
        [MinCount(2), MaxCount(20)]
        public ICollection<PollAnswer> Answers { get; set; }

        public Page Page { get; set; }
        public long PageId { get; set; }
    }
}
