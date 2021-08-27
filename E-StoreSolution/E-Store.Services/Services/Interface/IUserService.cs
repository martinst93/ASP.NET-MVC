using E_Store.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Store.Services.Services.Interface
{
    public interface IUserService
    {
        List<User> GetUsers();
        int AddNewUser(User entity);
        string GetLastUser();
    }
}
