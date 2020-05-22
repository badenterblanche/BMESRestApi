using BMESRestApi.Models.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BMESRestApi.Models
{
    public class Brand :BaseObject
    {
        [Key]
        public int BrandID { get; set; }
        public string BrandName { get; set; }
        public string Slug { get; set; }
        public string Description { get; set; }
        public string MetaKeyWords { get; set; }
        public BrandStatus BrandStatus { get; set; }
        public string MetaDescription { get; set; }
        public string MetaKeywords { get; set; }
    }
}
