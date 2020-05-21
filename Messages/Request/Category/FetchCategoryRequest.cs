using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BMESRestApi.Messages.Request.Category
{
    public class FetchProductRequest
    {
        public int PageNumber { get; set; }
        public int CategorysPerPage { get; set; }
    }
}
