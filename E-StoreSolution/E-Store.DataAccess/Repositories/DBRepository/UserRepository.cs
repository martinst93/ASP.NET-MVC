using E_Store.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Store.DataAccess.Repositories.DBRepository
{
    public class UserRepository : IRepository<User>
    {
        public void DeleteById(int id)
        {
            User user = StaticDB.Users.FirstOrDefault(x => x.Id == id);

            if(user != null)
            {
                StaticDB.Users.Remove(user);
            }
        }

        public List<User> GetAll()
        {
            return StaticDB.Users;
        }

        public User GetById(int id)
        {
            return StaticDB.Users.FirstOrDefault(x => x.Id == id);
        }

        public void Insert(User entity)
        {
            StaticDB.UserId++;
            _ = entity.Id == StaticDB.UserId;
            StaticDB.Users.Add(entity);
        }

        public void Update(User entity)
        {
            User user = StaticDB.Users.FirstOrDefault(x => x.Id == entity.Id);

            if(user != null)
            {
                int indexOfUser = StaticDB.Users.IndexOf(user);
                StaticDB.Users[indexOfUser] = entity;

                //user.FirstName = entity.FirstName;
                //user.LastName = entity.LastName;
                //user.PhoneNumber = entity.PhoneNumber;
                //user.Email = entity.Email;
                //user.AccountName = entity.AccountName;
            }
        }
    }
}
