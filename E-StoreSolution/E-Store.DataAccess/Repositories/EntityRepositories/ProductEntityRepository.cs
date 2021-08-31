using E_Store.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Store.DataAccess.Repositories.EntityRepositories
{
    public class ProductEntityRepository : IRepository<Product>
    {
        private EStoreDbContext _contextDb;
        public ProductEntityRepository(EStoreDbContext contextDb)
        {
            _contextDb = contextDb;
        }
        public void DeleteById(int id)
        {
            Product product = _contextDb.Products.FirstOrDefault(x => x.Id == id);

            if (product != null)
            {
                _contextDb.Products.Remove(product);
                _contextDb.SaveChanges();
            }
        }

        public List<Product> GetAll()
        {
            return _contextDb.Products.ToList();
        }

        public Product GetById(int id)
        {
            return _contextDb.Products.FirstOrDefault(x => x.Id == id);
        }

        public int Insert(Product entity)
        {
            _contextDb.Products.Add(entity);
            int id = _contextDb.SaveChanges();
            return id;
        }

        public void Update(Product entity)
        {
            Product product = _contextDb.Products.FirstOrDefault(x => x.Id == entity.Id);

            if (product != null)
            {
                entity.Id = product.Id;
                _contextDb.Products.Update(product);
            }
        }
    }
}
