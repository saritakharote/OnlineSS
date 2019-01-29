using ShoppingStore.Services;
using System.Web.Mvc;
using ShoppingStore.Entities;
using System.Linq;

namespace ShoppingStore.Controllers
{
    public class ProductController : Controller
    {
        ProductService prodserv = new ProductService();
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ProductTable(string search)
        {
            var products = prodserv.GetProducts();
          
            if (string.IsNullOrEmpty(search)==false)
            {
                products = products.Where(p=> p.Name!=null && p.Name.ToLower().Contains(search.ToLower())).ToList();
            }

            return PartialView(products);
        }

        //Create
        [HttpGet]
        public ActionResult Create()
        {
            return PartialView();
        }

        [HttpPost]
        public ActionResult Create(Product product)
        {
            prodserv.SaveProduct(product);
            return RedirectToAction("ProductTable");
        }
    }
}