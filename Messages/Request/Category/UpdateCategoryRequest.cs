using BMESRestApi.Messages.DataTransferObjects.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BMESRestApi.Messages.Request.Category
{
    public class UpdateCategoryRequest
    {
        public int CategoryID { get; set; }
        public CategoryDTO locCategoryDTO { get; set; }
    }
}
