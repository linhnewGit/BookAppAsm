using BookAppWeb.Repository;
using BookAppWeb.Models;

namespace BookShopWeb.Repository.IRepository
{
    public interface IBookRepository : IRepository<Book>
    {
        void Update(Book book);
    }
}