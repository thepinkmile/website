using System;

namespace GBT.Web.Core.TypeAnnotation
{
    [AttributeUsage(AttributeTargets.Class)]
    public class NavigationAttribute : Attribute
    {
        public string Controller { get; set; }

        public string Action { get; set; }
    }
}
