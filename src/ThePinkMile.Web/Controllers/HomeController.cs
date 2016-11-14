using Microsoft.AspNetCore.Mvc;

namespace ThePinkMile.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
    }
}
