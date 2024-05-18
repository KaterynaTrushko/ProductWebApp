using Microsoft.AspNetCore.Mvc;
using ProductApp.Services.Abstract;

namespace ProductApp.HttpApi.Controllers
    {
    public class ProductController : Controller
        {

        private readonly IProductService _productService;


        public ProductController(IProductService productService) 
            { 
            _productService = productService;
            }
        public IActionResult Index()
            {
            return View();
            }
        }
    }
