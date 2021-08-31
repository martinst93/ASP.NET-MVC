using E_Store.DataAccess;
using E_Store.DataAccess.Repositories;
using E_Store.DataAccess.Repositories.EntityRepositories;
using E_Store.Domain.Models;
using E_Store.Services.Services;
using E_Store.Services.Services.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Store.Services.Helpers
{
    public static class DIModule
    {
        public static IServiceCollection RegisterRepositories(IServiceCollection services, string connectionString)
        {
            services.AddTransient<IRepository<User>, UserEntityRepository>();
            services.AddTransient<IRepository<Product>, ProductEntityRepository>();
            services.AddTransient<IRepository<Order>, OrderEntityRepository>();

            services.AddDbContext<EStoreDbContext>(x => x.UseSqlServer(connectionString));

            return services;
        }
    }
}
