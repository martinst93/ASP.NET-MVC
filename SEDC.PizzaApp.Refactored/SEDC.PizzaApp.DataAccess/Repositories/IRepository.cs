using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.PizzaApp.DataAccess.Repositories
{
    public interface IRepository<T>
    {
        T GetT(int id);
        List<T> GetAll();
    }
}
