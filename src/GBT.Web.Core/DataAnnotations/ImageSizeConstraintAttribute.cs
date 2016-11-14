using System;

namespace GBT.Web.Core.DataAnnotations
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
    public class ImageSizeConstraintAttribute : Attribute
    {
        public int MinWidth { get; set; }

        public int MaxWidth { get; set; }

        public int MinHeight { get; set; }

        public int MaxHeight { get; set; }

        public ImageSizeConstraintAttribute()
        {
            MinWidth = int.MinValue;
            MaxWidth = int.MaxValue;
            MinHeight = int.MinValue;
            MaxHeight = int.MaxValue;
        }
    }
}
