using BMESRestApi.Database;
using BMESRestApi.Models;
using BMESRestApi.Repositories.Contracts;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BMESRestApi.Repositories.Implementations
{
    public class BrandRepository : IBrandRepository
    {
        private readonly BMESDBContext _BMESDBContext;
        public BrandRepository(BMESDBContext parBMESDBContext)
        {
            _BMESDBContext = parBMESDBContext;
        }

        public bool Create(Brand locBaseClass)
        {
            _BMESDBContext.Brands.Add(locBaseClass);
            return Save();

        }

        public bool Delete(Brand locBaseClass)
        {
            _BMESDBContext.Brands.Remove(locBaseClass);
            return Save();
        }

        public IEnumerable<Brand> FindAll()
        {
            var varBrands = _BMESDBContext.Brands;
            return varBrands;
        }

        public Brand FindByID(int parBrandID)
        {
            var varBrands = _BMESDBContext.Brands.Find(parBrandID);
            return varBrands;
        }

        public bool Save()
        {
            int intNoChanges = _BMESDBContext.SaveChanges();
            return intNoChanges > 0;
        }

        public bool Update(Brand locBaseClass)
        {
            _BMESDBContext.Brands.Update(locBaseClass);
            return Save();
        }
    }
}
