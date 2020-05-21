using BMESRestApi.Models.Product;
using BMESRestApi.Repositories.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BMESRestApi.Repositories.Contracts
{
    public interface IProductRepository : IBaseRepository<Product>
    {

    }
}
