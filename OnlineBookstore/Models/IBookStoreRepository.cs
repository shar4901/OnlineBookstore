using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookstore.Models
{
    public interface IBookStoreRepository
    {
        IQueryable<Book> Books { get; }

        void SaveProduct(Book b);
        void CreateProduct(Book b);
        void DeleteProduct(Book b);
    }
}
