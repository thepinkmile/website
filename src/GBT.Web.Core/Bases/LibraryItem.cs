using System.ComponentModel.DataAnnotations;

namespace GBT.Web.Core.Bases
{
    public abstract class LibraryItem : Identity
    {
        public string Name { get; set; }

        public string Location { get; set; }

        public string ExternalLink { get; set; }

        [MaxLength(10)]
        public string Type { get; set; }
    }
}
