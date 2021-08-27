using E_Store.Domain.Models;
using E_Store.Models;
using E_Store.Models.Mapper;
using E_Store.Services.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace E_Store.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IProductOrderService _productOrderService;

        public HomeController(ILogger<HomeController> logger, IProductOrderService productOrderService)
        {
            _logger = logger;
            _productOrderService = productOrderService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "This is our About Us page!";
            return View();
        }

        public IActionResult Products()
        {
            List<Product> allProducts = _productOrderService.GetAllProducts();
            List<ProductViewModel> productsViews = new List<ProductViewModel>();

            foreach (Product product in allProducts)
            {
                productsViews.Add(ProductMapper.ProductToShowDetailsViewModel(product));
            }

            AllProductsViewModel model = new AllProductsViewModel
            {
                AllProducts = productsViews
            };

            return View(model);
        }

        public IActionResult Promotions()
        {
            return View();
        }

        public IActionResult BlackFriday()
        {
            List<Product> allProducts = _productOrderService.GetAllProducts();
            List<BlackFridayViewModel> productsViews = new List<BlackFridayViewModel>();

            foreach (Product product in allProducts)
            {
                productsViews.Add(ProductMapper.ProductsOnPromotionBfViewModel(product));
            }

            AllBlackFridayProductsViewModel model = new AllBlackFridayProductsViewModel
            {
                AllBlackFridayViewModels = productsViews
            };

            return View(model);
        }

        public IActionResult CyberMonday()
        {
            List<Product> allProducts = _productOrderService.GetAllProducts();
            List<CyberMondayViewModel> productsViews = new List<CyberMondayViewModel>();

            foreach (Product product in allProducts)
            {
                productsViews.Add(ProductMapper.ProductsOnPromotionCmViewModel(product));
            }

            AllCyberMondayViewModel model = new AllCyberMondayViewModel
            {
                AllCyberMondayProducts = productsViews
            };

            return View(model);
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "This is our contact page!";
            return View();
        }
    }
}
