using E_Store.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Store.Services.Services.Interface
{
    public interface IProductOrderService 
    {
        List<Product> GetAllProducts();
        List<Order> GetOrders();
        Order GetOrderById(int id);
        int GetOrderCount();
        string GetMostPopularProduct();
        Order GetLastOrder();
        void MakeNewOrder(Order order);
    }
}
