using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BMESRestApi.Messages.DataTransferObjects.Product
{
    public class BrandDTO
    {
        public int BrandID { get; set; }
        public string BrandName { get; set; }
        public string Slug { get; set; }
        public string Description { get; set; }
        public string MetaKeyWords { get; set; }
        public BrandStatus BrandStatus { get; set; }
    }
}
