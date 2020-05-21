using BMESRestApi.Messages.DataTransferObjects.Product;
using BMESRestApi.Repositories.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BMESRestApi.Messages.Response.Brand
{
    public class FetchCategoryResponse: ResponseBase
    {
        public int BrandsPerPage { get; set; }
        public bool isPreviousPages { get; set; }
        public bool isNextPages { get; set; }
        public int CurrentPage { get; set; }
        public int[] Pages { get; set; }
        public IEnumerable<BrandDTO> Brands { get; set; }

    }
}
