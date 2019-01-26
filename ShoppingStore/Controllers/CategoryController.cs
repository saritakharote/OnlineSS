using ShoppingStore.Entities;
using ShoppingStore.Services;
using System.Web.Mvc;

namespace ShoppingStore.Controllers
{
    public class CategoryController : Controller
    {
        CategoriesService cateserv = new CategoriesService();

        //Bydefault
        [HttpGet]
        public ActionResult Index()
        {
            var categories = cateserv.GetCategories();
            return View(categories);
        }

        //Create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Category category)
        {
            cateserv.SaveCategory(category);
            return RedirectToAction("Index");
        }

        //Edit
        [HttpGet]
        public ActionResult Edit(int ID)
        {
            var category = cateserv.GetCategory(ID);
            return View(category);
        }

        [HttpPost]
        public ActionResult Edit(Category category)
        {
            cateserv.UpdateCategory(category);
            return RedirectToAction("Index");
        }


        //Delete
        [HttpGet]
        public ActionResult Delete(int ID)
        {
            var category = cateserv.GetCategory(ID);

            return View(category);
        }

        [HttpPost]
        public ActionResult Delete(Category category)
        {
            category = cateserv.GetCategory(category.ID);
            cateserv.DeleteCategory(category);
            return RedirectToAction("Index");
        }
    }
}