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
    public class UserService : IUserService
    {
        private IRepository<User> _userRepository;

        public UserService(IRepository<User> userRepository)
        {
            _userRepository = userRepository;
        }

        public int AddNewUser(User entity)
        {
            return _userRepository.Insert(entity);
        }

        public string GetLastUser()
        {
            return _userRepository.GetAll().LastOrDefault()?.FirstName;
        }

        public List<User> GetUsers()
        {
            return _userRepository.GetAll();
        }
    }
}
