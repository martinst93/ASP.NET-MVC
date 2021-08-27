using SEDC.PizzaApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.PizzaApp.DataAccess.Repositories.CacheRepository
{
    public class FeedbackRepository : IRepository<Feedback>
    {
        public void DeleteById(int id)
        {
            Feedback feedback = CacheDb.Feedbacks.FirstOrDefault(x => x.Id == id);

            if(feedback != null)
            {
                CacheDb.Feedbacks.Remove(feedback);
            }
        }

        public List<Feedback> GetAll()
        {
            return CacheDb.Feedbacks.ToList();
        }

        public Feedback GetById(int id)
        {
            return CacheDb.Feedbacks.FirstOrDefault(x => x.Id == id);
        }

        public void Insert(Feedback entity)
        {
            CacheDb.FeedbacksId++;
            entity.Id = CacheDb.FeedbacksId;
            CacheDb.Feedbacks.Add(entity);
        }

        public void Update(Feedback entity)
        {
            Feedback feedback = CacheDb.Feedbacks.FirstOrDefault(x => x.Id == entity.Id);
        }
    }
}
