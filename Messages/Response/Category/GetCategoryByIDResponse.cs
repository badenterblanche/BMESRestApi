using BMESRestApi.Messages.DataTransferObjects.Product;
using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BMESRestApi.Messages.Response.Category
{
    public class GetProductByIDResponse: ResponseBase
    {
        public CategoryDTO locCategoryDTO { get; set; }
    }
}
