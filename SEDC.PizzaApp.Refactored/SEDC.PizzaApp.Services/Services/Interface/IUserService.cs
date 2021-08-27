using SEDC.PizzaApp.Domain.Models;
using System.Collections.Generic;

namespace SEDC.PizzaApp.Services.Services.Interface
{
    public interface IUserService
    {
        List<User> GetUsers();
        void GiveFeedback(Feedback feedback);
        List<Feedback> GetFeedback(Feedback feedback);
    }
}
