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
    public class ProductOrderService : IProductOrderService
    {
        private IRepository<Product> _productRepository;
        private IRepository<Order> _orderRepository;

        public ProductOrderService(IRepository<Product> productRepository, IRepository<Order> orderRepository)
        {
            _productRepository = productRepository;
            _orderRepository = orderRepository;
        }

        public List<Product> GetAllProducts()
        {
            return _productRepository.GetAll();
        }
        public Order GetLastOrder()
        {
            return _orderRepository.GetAll().LastOrDefault();
        }

        public string GetMostPopularProduct()
        {
            throw new NotImplementedException();
        }

        public Order GetOrderById(int id)
        {
            return _orderRepository.GetById(id);
        }

        public int GetOrderCount()
        {
            return _orderRepository.GetAll().Count;
        }

        public List<Order> GetOrders()
        {
            return _orderRepository.GetAll();
        }

        public void MakeNewOrder(Order order)
        {
            _orderRepository.Insert(order);
        }
    }
}
