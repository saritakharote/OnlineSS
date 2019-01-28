using ShoppingStore.Database;
using ShoppingStore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingStore.Services
{
    public class ProductService
    {
        //edit categoroy
        public Product GetProduct(int ID)
        {
            using (var context = new SSContext())
            {
                return context.Products.Find(ID);
            }
        }

        //add product
        public List<Product> GetProducts()
        {
            using (var context = new SSContext())
            {
                return context.Products.ToList();
            }
        }

        //create
        public void SaveProduct(Product product)
        {
            using (var context = new SSContext())
            {
                context.Products.Add(product);
                context.SaveChanges();
            }
        }

        //update
        public void UpdateProduct(Product product)
        {
            using (var context = new SSContext())
            {
                context.Entry(product).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();

            }
        }

        //delete


        public void DeleteProduct(Product product)
        {
            using (var context = new SSContext())
            {
                //product = context.Products.Find(ID);
                //context.Entry(product).State = System.Data.Entity.EntityState.Deleted;
                //OR
                context.Products.Remove(product);
                context.SaveChanges();

            }
        }
    }
}
