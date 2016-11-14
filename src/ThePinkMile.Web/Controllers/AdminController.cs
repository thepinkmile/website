using Microsoft.AspNetCore.Mvc;

namespace ThePinkMile.Web.Controllers
{
    public class AdminController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
    }
}
