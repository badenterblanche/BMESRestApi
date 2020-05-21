using BMESRestApi.Messages.DataTransferObjects.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BMESRestApi.Messages.Response.Brand
{
    public class DeleteCategoryRequest: ResponseBase
    {
        public BrandDTO locBrandDTO { get; set; }
    }
}
