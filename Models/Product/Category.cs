using BMESRestApi.Models.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BMESRestApi.Models
{
    public class Category : BaseObject
    {
        public string CategoryName { get; set; }
        public string Slug { get; set; }
        public string Description { get; set; }
        public string MetaKeyWords { get; set; }
        public CategoryStatus CategoryStatus { get; set; }
    }
}
