using BMESRestApi.Messages.Request.Brand;
using BMESRestApi.Messages.Response.Brand;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BMESRestApi.Services
{
    public interface IBrandService
    {
        CreateBrandResponse SaveBrand(CreateBrandRequest parBrandRequest);
    }
}
