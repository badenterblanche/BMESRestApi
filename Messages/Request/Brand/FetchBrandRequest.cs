﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BMESRestApi.Messages.Request.Brand
{
    public class FetchCategoryRequest
    {
        public int PageNumber { get; set; }
        public int BrandsPerPage { get; set; }
    }
}
