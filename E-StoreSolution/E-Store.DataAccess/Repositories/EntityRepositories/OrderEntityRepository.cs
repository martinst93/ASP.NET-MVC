using E_Store.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Store.DataAccess.Repositories.EntityRepositories
{
    public class OrderEntityRepository : IRepository<Order>
    {
        private EStoreDbContext _contextDb;
        public OrderEntityRepository(EStoreDbContext contextDb)
        {
            _contextDb = contextDb;
        }
        public void DeleteById(int id)
        {
            Order order = _contextDb.Orders.FirstOrDefault(x => x.Id == id);

            if (order != null)
            {
                _contextDb.Orders.Remove(order);
                _contextDb.SaveChanges();
            }
        }

        public List<Order> GetAll()
        {
            return _contextDb.Orders.ToList();
        }

        public Order GetById(int id)
        {
            return _contextDb.Orders.FirstOrDefault(x => x. Id == id);
        }

        public int Insert(Order entity)
        {
            _contextDb.Orders.Add(entity);
            int id = _contextDb.SaveChanges();
            return id;
        }

        public void Update(Order entity)
        {
            Order order = _contextDb.Orders.FirstOrDefault(x => x.Id == entity.Id);

            if (order != null)
            {
                entity.Id = order.Id;
                _contextDb.Orders.Update(entity);
            }
        }
    }
}
