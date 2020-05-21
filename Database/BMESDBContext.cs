using BMESRestApi.Models;
using BMESRestApi.Models.Product;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BMESRestApi.Database
{
    public class BMESDBContext :DbContext
    {
        public BMESDBContext(DbContextOptions<BMESDBContext> options) : base(options)
        {

        }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
