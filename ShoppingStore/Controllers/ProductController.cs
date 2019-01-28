using ShoppingStore.Services;
using System.Web.Mvc;
using ShoppingStore.Entities;


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