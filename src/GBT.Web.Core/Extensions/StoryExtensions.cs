using System;
using GBT.Web.Core.Model.ContentItems;

namespace GBT.Web.Core.Extensions
{
    public static class StoryExtensions
    {
        public static DateTime? EndDate(this Story story)
        {
            return story.Until ?? story.When;
        }

        public static bool HasDocuments(this Story story)
        {
            return (story.Documents?.Count ?? 0) != 0;
        }
    }
}
