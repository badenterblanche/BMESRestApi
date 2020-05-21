using BMESRestApi.Messages.DataTransferObjects.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BMESRestApi.Messages.Request.Product
{
    public class UpdateProductRequest
    {
        public int ProductID { get; set; }
        public ProductDTO locProductDTO { get; set; }
    }
}
