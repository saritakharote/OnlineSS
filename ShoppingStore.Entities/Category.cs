
using System.Collections.Generic;


namespace ShoppingStore.Entities
{
    public class Category:BaseEntity
    {
        public List<Product> Products { get; set; }
    }
}
