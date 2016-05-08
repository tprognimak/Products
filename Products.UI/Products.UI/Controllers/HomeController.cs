using Products.DAL.Model;
using Products.Services;
using System.Web.Mvc;

namespace Products.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductService _productService;

        public HomeController()
        {
            _productService = new ProductService();
        }

        public ActionResult Index()
        {
            var products = _productService.GetProducts();

            ViewBag.Products = products;

            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            return PartialView();
        }

        [HttpPost]
        public ActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                var products = _productService.Create(product);

                return RedirectToAction("Index");
            }
            return PartialView(product);
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var products = _productService.Delete(id);

            return PartialView(products);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            var products = _productService.DeleteConfirmed(id);

            return RedirectToAction("Index");
        }


    }
}