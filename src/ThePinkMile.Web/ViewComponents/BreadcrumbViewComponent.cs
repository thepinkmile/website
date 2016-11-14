using Microsoft.AspNetCore.Mvc;
using ThePinkMile.Dal;

namespace ThePinkMile.Web.ViewComponents
{
    public class BreadcrumbViewComponent : ViewComponent
    {
        private readonly WebsiteContext _context;

        public BreadcrumbViewComponent(WebsiteContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke(long rootId, long currentPageId)
        {

            return View();
        }
    }
}
