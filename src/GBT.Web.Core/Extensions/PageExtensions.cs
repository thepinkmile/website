using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using GBT.Web.Core.Bases;
using GBT.Web.Core.Model.PageItems;
using GBT.Web.Core.TypeAnnotation;
using Microsoft.AspNetCore.Routing;

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

        public static string NavigationLink(this Page page)
        {
            if (page is NavigationPage)
            {
                return ((NavigationPage)page).NavigateToPage.NavigationLink();
            }
            if (page is LinkedPage)
            {
                return ((LinkedPage) page).Link;
            }
            var attr = page.GetType().GetTypeInfo().GetCustomAttribute<NavigationAttribute>();
            if (attr == null)
            {
                throw new MissingFieldException($"Navigation details are missing for the type {page.GetType().Name}");
            }
            //return Url.Action(attr.Action, attr.Controller, new {id = page.Id});
            return null; // ToDo: must figure out how to do this
        }
    }
}
