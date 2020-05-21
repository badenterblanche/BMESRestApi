using BMESRestApi.Messages.DataTransferObjects.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BMESRestApi.Messages.Request.Brand
{
    public class UpdateBrandRequest
    {
        public int BrandID { get; set; }
        public BrandDTO locBrandDTO { get; set; }
    }
}
