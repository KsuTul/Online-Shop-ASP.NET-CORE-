using Microsoft.AspNetCore.Mvc;

namespace Online_Shop.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
