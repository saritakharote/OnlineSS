using ShoppingStore.Database;
using ShoppingStore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingStore.Services
{
    public class CategoriesService
    {
        //edit categoroy
        public Category GetCategory(int ID)
        {
            using (var context = new SSContext())
            {
                return context.Categories.Find(ID);
            }
        }

        //add category
        public List<Category>GetCategories()
        {
            using (var context = new SSContext())
            {
                return context.Categories.ToList();
            }
        }

        //create
        public void SaveCategory(Category category)
        {
            using (var context = new SSContext())
            {
                context.Categories.Add(category);
                context.SaveChanges();
            }
        }

        //update
        public void UpdateCategory(Category category)
        {
            using (var context = new SSContext())
            {
                context.Entry(category).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            
            }
        }

        //delete

        
        public void DeleteCategory(Category category)
        {
            using (var context = new SSContext())
            {
                //var category = context.Categories.Find(ID);
                context.Entry(category).State = System.Data.Entity.EntityState.Deleted;
                //OR
                //context.Categories.Remove(category);
                context.SaveChanges();

            }
        }
    }
}
