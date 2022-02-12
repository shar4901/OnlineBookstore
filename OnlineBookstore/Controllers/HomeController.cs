using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OnlineBookstore.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookstore.Controllers
{
    public class HomeController : Controller
    {
        private IBookStoreRepository repo;


        public HomeController(IBookStoreRepository temp)
        {
            repo = temp;
        }

        public IActionResult Index()
        {

            IQueryable<Book> booklist = repo.Books
                .OrderBy(x => x.Title)
                .Take(10);

            return View(booklist);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
