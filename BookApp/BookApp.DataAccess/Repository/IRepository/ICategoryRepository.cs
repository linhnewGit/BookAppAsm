using BookAppWeb.Repository;
using BookAppWeb.Models;

namespace BookAppWeb.Repository.IRepository
{
    public interface ICategoryRepository : IRepository<Category>
    {
        void Update(Category category);
    }
}