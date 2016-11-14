using System;

namespace GBT.Web.Core.DataAnnotations
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
    public class MaxCountAttribute : Attribute
    {
        public int Max;

        public MaxCountAttribute(int max = int.MaxValue)
        {
            Max = max;
        }
    }
}
