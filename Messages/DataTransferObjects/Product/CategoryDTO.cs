using BMESRestApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BMESRestApi.Messages.DataTransferObjects.Product
{
    public class CategoryDTO
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Slug { get; set; }
        public string Description { get; set; }
        public string MetaKeyWords { get; set; }
        public CategoryStatus CategoryStatus { get; set; }
    }
}
