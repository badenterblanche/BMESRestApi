using BMESRestApi.Database;
using BMESRestApi.Models.Product;
using BMESRestApi.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BMESRestApi.Repositories.Implementations
{
    public class ProductRepository : IProductRepository
    {
        private readonly BMESDBContext _BMESDBContext;
        public ProductRepository(BMESDBContext parBMESDBContext)
        {
            _BMESDBContext = parBMESDBContext;
        }

        public bool Create(Product locBaseClass)
        {
            _BMESDBContext.Add(locBaseClass);
            return Save();


        }

        public bool Delete(Product locBaseClass)
        {
            _BMESDBContext.Remove(locBaseClass);
            return Save();
        }

        public IEnumerable<Product> FindAll()
        {
            var varProducts = _BMESDBContext.Products
                .Include(navigationPropertyPath: x => x.BrandClass)
                .Include(navigationPropertyPath: x => x.CategoryClass);

            return varProducts;
        }

        public Product FindByID(int parID)
        {
            return _BMESDBContext.Products.FirstOrDefault(x => x.ProductID == parID);
        }

        public bool Save()
        {
            int intNoChanges = _BMESDBContext.SaveChanges();
            return intNoChanges > 0;
        }

        public bool Update(Product locBaseClass)
        {
            _BMESDBContext.Update(locBaseClass);
            return Save();
        }
    }
}
