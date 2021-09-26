using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductsTaskWebAPI_MohammedElmorsy.Models
{
    public class ProductsDBContext: DbContext
    {
        public ProductsDBContext(DbContextOptions<ProductsDBContext> options): base(options) {}

        public DbSet<Product> Products { get; set; }
    }
}
