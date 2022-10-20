using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_Core_MVC_Intro.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public IActionResult Index()
        {
            IEnumerable<Product> products = _productRepository.GetAllProducts();
            return View(products);
        }
    }
}
