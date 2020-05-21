using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BMESRestApi.Messages.Request.Product
{
    public class FetchProductRequest
    {
        public int PageNumber { get; set; }
        public int ProductsPerPage { get; set; }
        public string CategortSlug { get; set; }
        public string BrandSlug { get; set; }
    }
}
