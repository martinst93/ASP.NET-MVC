using E_Store.Services.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Store.Controllers
{
    public class OrderController : Controller
    {
        private IProductOrderService _productService;

        public OrderController(IProductOrderService productService)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
