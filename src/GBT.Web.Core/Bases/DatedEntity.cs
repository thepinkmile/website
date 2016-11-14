using System;

namespace GBT.Web.Core.Bases
{
    public abstract class DatedEntity : ContentItem
    {
        public DateTime Start { get; set; }

        public DateTime? End { get; set; }
    }
}
