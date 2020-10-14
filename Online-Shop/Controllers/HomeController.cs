using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Online_Shop.Models;

namespace Online_Shop.Controllers
{
    public class HomeController : Controller
    {
        private BookShopContext _context;

        public HomeController(BookShopContext context)
        {
            this._context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult BookGallery()
        {
            var books = _context.Books.ToList();
            return View(books);
        }

        [HttpGet]
        public IActionResult LogIn()
        {
            return View();
       
        }

        [HttpGet]
        public IActionResult Registration()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Registration(User user, string foreName, string surName)
        {
            if (user != null && foreName!=null && surName!=null)
            {
                user.FullName = foreName + surName;
                _context.Users.Add(user);
                _context.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}
