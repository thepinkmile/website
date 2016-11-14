using GBT.Web.Core.Bases;
using GBT.Web.Core.Model.ContentItems;
using GBT.Web.Core.Model.Users;

namespace GBT.Web.Core.Model.Statistics
{
    public class PollStatistic : Statistic
    {
        public Poll Parent { get; set; }

        public Visitor Child { get; set; }

        public PollAnswer Response { get; set; }
        public long PersonId { get; set; }
    }
}
