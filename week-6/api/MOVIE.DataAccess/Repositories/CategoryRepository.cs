using MOVIE.DataAccess.Abstracts;
using MOVIE.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOVIE.DataAccess.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly MovieDbContext _dbContext;
        public CategoryRepository(MovieDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Category CreateCategory(Category category)
        {
            _dbContext.Categories.Add(category);
            _dbContext.SaveChanges();
            return category;
        }

        public void DeleteCategory(int id)
        {
            var deletedItem = GetCategoryById(id);
            _dbContext.Categories.Remove(deletedItem);
            _dbContext.SaveChanges();
        }

        public List<Category> GetAllCategories()
        {
            return _dbContext.Categories.ToList();
        }

        public Category GetCategoryById(int id)
        {
            return _dbContext.Categories.Find(id);
        }

        public Category UpdateCategory(Category category)
        {
            _dbContext.Categories.Update(category);
            _dbContext.SaveChanges();
            return category;
        }
    }
}
