using BMESRestApi.Messages.DataTransferObjects.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BMESRestApi.Messages.Response.Category
{
    public class CreateCategoryResponse : ResponseBase
    {
        public CategoryDTO locCategoryDTO { get; set; }
    }
}
