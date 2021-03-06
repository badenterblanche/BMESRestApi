﻿using BMESRestApi.Models.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BMESRestApi.Models.Product
{
    public class Product : BaseObject
    {
        [Key]
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string Slug { get; set; }
        public string Description { get; set; }
        public string MetaDescription { get; set; }
        public string MetaKeywords { get; set; }
        public string SKU { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }
        public decimal SalesPrice { get; set; }
        public decimal OldPrice { get; set; }
        public string ImageURL { get; set; }
        public int QuantityInStock { get; set; }
        public bool isBestSeller { get; set; }
        public bool isFeatured { get; set; }
        [ForeignKey("ProductCategoryID")]
        public long CategoryID { get; set; }
        public Category CategoryClass { get; set; }
        [ForeignKey("ProductBrandID")]
        public long BrandID { get; set; }
        public Brand BrandClass { get; set; }
        public ProductStatus ProductStatus { get; set; }

    }
}
