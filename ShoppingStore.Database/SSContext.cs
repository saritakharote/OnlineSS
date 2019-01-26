using ShoppingStore.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingStore.Database
{
    public class SSContext:DbContext,IDisposable
    {
        public SSContext():base("DefaultConnection")
        {
               
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
