using System.Linq;
using GBT.Web.Core.Bases;

namespace GBT.Web.Core.Extensions
{
    public static class PageExtensions
    {
        public static string DisplayTitle(this Page page)
        {
            return page.ShortTitle ?? page.Title;
        }

        public static bool HasDescription(this Page page)
        {
            return !(string.IsNullOrEmpty(page.Description) || string.IsNullOrWhiteSpace(page.Description));
        }

        public static bool HasFullText(this Page page)
        {
            return !(string.IsNullOrEmpty(page.FullText) || string.IsNullOrWhiteSpace(page.FullText));
        }

        public static bool HasMarquee(this Page page)
        {
            return !(string.IsNullOrEmpty(page.Marquee) || string.IsNullOrWhiteSpace(page.Marquee));
        }

        public static bool HasStories(this Page page)
        {
            return (page.Stories?.Count ?? 0) != 0;
        }

        public static bool HasDocuments(this Page page)
        {
            return (page.Documents?.Count ?? 0) != 0;
        }

        public static bool HasPoll(this Page page)
        {
            return (page.Polls?.Count ?? 0) != 0;
        }

        public static bool IsActive(this Page page, long activeId)
        {
            return activeId == page.Id || page.ChildPages.Any(childPage => childPage.IsActive(activeId));
        }
    }
}
