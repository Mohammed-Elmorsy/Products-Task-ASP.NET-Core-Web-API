using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductsTaskWebAPI_MohammedElmorsy.Models;

namespace ProductsTaskWebAPI_MohammedElmorsy.Repositories
{
    public class ProductRepository : Repository<Product> 
    {
        private ProductsDBContext db;
        private DbSet<Product> Products;
        public ProductRepository(ProductsDBContext db) : base(db)
        {
            this.db = db;
            Products = this.db.Set<Product>();
        }

    }
}
