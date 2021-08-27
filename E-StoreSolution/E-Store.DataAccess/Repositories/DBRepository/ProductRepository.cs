using E_Store.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Store.DataAccess.Repositories.DBRepository
{
    public class ProductRepository : IRepository<Product>
    {
        public void DeleteById(int id)
        {
            Product product = StaticDB.Products.FirstOrDefault(x => x.Id == id);

            if (product != null)
            {
                StaticDB.Products.Remove(product);
            }
        }

        public List<Product> GetAll()
        {
            return StaticDB.Products;
        }

        public Product GetById(int id)
        {
            return StaticDB.Products.FirstOrDefault(x => x.Id == id);
        }

        public int Insert(Product entity)
        {
            StaticDB.ProductId++;
            _ = entity.Id == StaticDB.ProductId;
            StaticDB.Products.Add(entity);

            return entity.Id;
        }

        public void Update(Product entity)
        {
            Product product = StaticDB.Products.FirstOrDefault(x => x.Id == entity.Id);

            if (product != null)
            {
                int indexOfProduct = StaticDB.Products.IndexOf(product);
                StaticDB.Products[indexOfProduct] = entity;
            }
        }
    }
}
