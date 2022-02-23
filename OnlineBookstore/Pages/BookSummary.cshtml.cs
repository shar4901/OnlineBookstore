using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OnlineBookstore.Models;

namespace OnlineBookstore.Pages
{
    public class BookSummaryModel : PageModel
    {
        private IBookStoreRepository repo;

        public BookSummaryModel(IBookStoreRepository temp) => repo = temp;
        public void OnGet()
        {
        }

        public IActionResult OnPost(int bookId)
        {
            Book b = repo.Books.FirstOrDefault(x => x.BookId == bookId);

            return RedirectToPage();
        }
    }
}
