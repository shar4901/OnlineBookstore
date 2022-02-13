using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookstore.Models.ViewModel
{
    public class BookListViewModel
    {
        public IQueryable<Book> Books  { get; set; }
        public PageInfo PageInfo { get; set; }
    }
}
