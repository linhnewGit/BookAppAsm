using BookAppWeb.Data;
using BookAppWeb.Models;
using BookAppWeb.Repository.IRepository;

namespace BookAppWeb.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly ApplicationDBContext _dbContext;
        public CategoryRepository(ApplicationDBContext dBContext) : base(dBContext)
        {
            _dbContext = dBContext;
        }

        public void Update(Category category)
        {
            _dbContext.Update(category);
        }
    }
}