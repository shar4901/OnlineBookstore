using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookstore.Models.ViewModel
{
    public class PageInfo
    {
        public int TotalBooks { get; set; }
        public int BooksPerPage { get; set; }
        public int CurrentPage { get; set; }

        //Get Total Number of Pages needed to Pagenate
        public int TotalPages => (int)Math.Ceiling((double)TotalBooks / BooksPerPage);
    }
}
    