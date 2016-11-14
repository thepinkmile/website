using System;
using GBT.Web.Core.Bases;

namespace GBT.Web.Core.Model.ContentItems
{
    public class Story : ContentItem
    {
        public DateTime? When { get; set; }

        public DateTime? Until { get; set; }
    }
}
