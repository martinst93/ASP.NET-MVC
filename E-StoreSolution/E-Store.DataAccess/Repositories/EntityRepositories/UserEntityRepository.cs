using E_Store.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Store.DataAccess.Repositories.EntityRepositories
{
    public class UserEntityRepository : IRepository<User>
    {
        private EStoreDbContext _contextDb;
        public UserEntityRepository(EStoreDbContext contextDb)
        {
            _contextDb = contextDb;
        }
        public void DeleteById(int id)
        {
            User user = _contextDb.Users.FirstOrDefault(x => x.Id == id);

            if (user != null)
            {
                _contextDb.Users.Remove(user);
                _contextDb.SaveChanges();
            }
        }

        public List<User> GetAll()
        {
            return _contextDb.Users.ToList();
        }

        public User GetById(int id)
        {
            return _contextDb.Users.FirstOrDefault(x => x.Id == id);
        }

        public int Insert(User entity)
        {
            _contextDb.Users.Add(entity);
            int id = _contextDb.SaveChanges();
            return id;
        }

        public void Update(User entity)
        {
            User user = _contextDb.Users.FirstOrDefault(x => x.Id == entity.Id);

            if (user != null)
            {
                entity.Id = user.Id;
                _contextDb.Users.Update(entity);
            }
        }
    }
}
