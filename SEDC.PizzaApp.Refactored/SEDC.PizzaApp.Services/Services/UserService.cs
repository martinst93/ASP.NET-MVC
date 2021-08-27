using SEDC.PizzaApp.DataAccess;
using SEDC.PizzaApp.DataAccess.Repositories;
using SEDC.PizzaApp.Domain.Models;
using SEDC.PizzaApp.Services.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.PizzaApp.Services.Services
{
    public class UserService : IUserService
    {
        private IRepository<User> _userRepository;

        public UserService(IRepository<User> userRepository)
        {
            _userRepository = userRepository;
        }

        public List<Feedback> GetFeedback(Feedback feedback)
        {
            Feedback feedback1 = (Feedback)CacheDb.Feedbacks.Where(x => x.Id < feedback.Id).Select(x => x);

            return feedback1;


        }

        public List<User> GetUsers()
        {
            return _userRepository.GetAll();
        }

        public void GiveFeedback(Feedback feedback)
        {
            CacheDb.FeedbacksId++;
            feedback.Id = CacheDb.FeedbacksId;
            CacheDb.Feedbacks.Add(feedback);
        }
    }
}
