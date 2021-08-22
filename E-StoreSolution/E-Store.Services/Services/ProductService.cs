using E_Store.DataAccess.Repositories;
using E_Store.Domain.Models;
using E_Store.Services.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Store.Services.Services
{
    public class ProductService : IProductService
    {
        private IRepository<Product> _productRepository;

        public ProductService(IRepository<Product> productRepository)
        {
            _productRepository = productRepository;
        }
        public List<Product> GetProducts()
        {
            return _productRepository.GetAll();
        }
    }
}
