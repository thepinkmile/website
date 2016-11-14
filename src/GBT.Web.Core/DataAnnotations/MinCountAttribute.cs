using System;

namespace GBT.Web.Core.DataAnnotations
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
    public class MinCountAttribute : Attribute
    {
        public int Max;

        public MinCountAttribute(int max = int.MaxValue)
        {
            Max = max;
        }
    }
}
