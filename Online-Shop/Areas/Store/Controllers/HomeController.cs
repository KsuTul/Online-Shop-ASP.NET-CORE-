using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Online_Shop.Models;

namespace Online_Shop.Areas.Store.Controllers
{
    [Area("Store")]
    public class HomeController : Controller
    {
        private BookShopContext _context;

        public HomeController(BookShopContext context)
        {
            this._context = context;
        }

        [HttpGet]
        [Route("Store/Home/BookGallery")]
        public IActionResult BookGallery()
        {
            var books = _context.Books.ToList();
            return View(books);
        }
    }
}
