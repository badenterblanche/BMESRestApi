using BMESRestApi.Messages.DataTransferObjects.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BMESRestApi.Messages.Response.Product
{
    public class CreateProductResponse : ResponseBase
    {
        public ProductDTO locProductDTO { get; set; }
    }
}
