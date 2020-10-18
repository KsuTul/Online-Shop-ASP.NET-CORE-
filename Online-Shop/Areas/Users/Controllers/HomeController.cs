using Microsoft.AspNetCore.Mvc;
using Online_Shop.Models;

namespace Online_Shop.Areas.Users.Controllers
{
    [Area("Users")]
    public class HomeController : Controller
    {
        private readonly BookShopContext _context;

        public HomeController(BookShopContext context)
        {
            this._context = context;
        }

        [Route("Users/Home/LogIn")]
        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        [Route("Users/Home/Reg")]
        public IActionResult Reg()
        {
            return View();
        }


        [HttpPost]
        [Route("Users/Home/Reg")]
        public IActionResult Reg(User user, string foreName, string surName)
        {
            if (user != null && foreName != null && surName != null)
            {
                user.FullName = foreName + surName;
                _context.Users.Add(user);
                _context.SaveChanges();
            }
            return Redirect("~/Home/Index");
        }
    }
}
