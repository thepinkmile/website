using System.Linq;
using GBT.Web.Core.Extensions;
using Microsoft.AspNetCore.Mvc;
using ThePinkMile.Dal;
using ThePinkMile.Web.Models;

namespace ThePinkMile.Web.ViewComponents
{
    public class MenuViewComponent : ViewComponent
    {
        private readonly WebsiteContext _context;

        public MenuViewComponent(WebsiteContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke(long rootId, long currentPageId)
        {
            var navigationRoot = _context.Pages.Single(x => x.Id == rootId);
            var model = new MenuComponentViewModel();
            foreach (var childPage in navigationRoot.ChildPages)
            {
                var item = new MenuComponentItemViewModel
                {
                    DisplayName = childPage.DisplayTitle(),
                    IsActive = childPage.IsActive(currentPageId),
                    Link = childPage.NavigationLink(),
                    ChildNavigation = childPage.IsActive(currentPageId) ? Invoke(childPage.Id, currentPageId).ToString() : ""
                };
                model.Items.Add(item);
            }
            return View(model);
        }
    }
}
