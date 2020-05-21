using BMESRestApi.Messages.DataTransferObjects.Product;
using BMESRestApi.Repositories.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BMESRestApi.Messages.Response.Product
{
    public class FetchProductResponse: ResponseBase
    {
        public int ProductsPerPage { get; set; }
        public bool isPreviousPages { get; set; }
        public bool isNextPages { get; set; }
        public int CurrentPage { get; set; }
        public int[] Pages { get; set; }
        public IEnumerable<ProductDTO> Products { get; set; }

    }
}
