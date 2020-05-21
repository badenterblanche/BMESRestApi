using BMESRestApi.Messages.DataTransferObjects.Product;
using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BMESRestApi.Messages.Response.Brand
{
    public class GetBrandByIDResponse: ResponseBase
    {
        public BrandDTO locBrandDTO { get; set; }
    }
}
