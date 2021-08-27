using E_Store.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Store.DataAccess.Repositories.DBRepository
{
    public class OrderRepository : IRepository<Order>
    {
        public void DeleteById(int id)
        {
            Order order = StaticDB.Orders.FirstOrDefault(x => x.Id == id);

            if(order != null)
            {
                StaticDB.Orders.Remove(order);
            }
        }

        public List<Order> GetAll()
        {
            return StaticDB.Orders;
        }

        public Order GetById(int id)
        {
            return StaticDB.Orders.FirstOrDefault(x => x.Id == id);
        }

        public int Insert(Order entity)
        {
            StaticDB.OrderId++;
            _ = entity.Id == StaticDB.OrderId;
            StaticDB.Orders.Add(entity);

            return entity.Id;
        }

        public void Update(Order entity)
        {
            Order order = StaticDB.Orders.FirstOrDefault(x => x.Id == entity.Id);

            if (order != null)
            {
                int indexOfOrder = StaticDB.Orders.IndexOf(order);
                StaticDB.Orders[indexOfOrder] = entity;
            }
        }
    }
}
