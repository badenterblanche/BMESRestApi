using BMESRestApi.Database;
using BMESRestApi.Models;
using BMESRestApi.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BMESRestApi.Repositories.Implementations
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly BMESDBContext _BMESDBContext;

        public CategoryRepository(BMESDBContext parBMESDBContext)
        {
            _BMESDBContext = parBMESDBContext;
        }
        public bool Create(Category locBaseClass)
        {
            _BMESDBContext.Categories.Add(locBaseClass);
            return Save();
        }

        public bool Delete(Category locBaseClass)
        {
            _BMESDBContext.Categories.Remove(locBaseClass);
            return Save();
        }

        public IEnumerable<Category> FindAll()
        {
            return _BMESDBContext.Categories.ToList();
        }

        public Category FindByID(int parCategoryID)
        {
            return _BMESDBContext.Categories.FirstOrDefault(x => x.CategoryID == parCategoryID);
        }

        public bool Save()
        {
            int intNumberChanged = _BMESDBContext.SaveChanges();
            return intNumberChanged > 0;
        }

        public bool Update(Category locBaseClass)
        {
            _BMESDBContext.Categories.Update(locBaseClass);
            return Save();
        }
    }
}
