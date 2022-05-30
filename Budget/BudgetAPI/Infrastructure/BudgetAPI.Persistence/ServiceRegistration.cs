using BudgetAPI.Persistence.Contexts;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BudgetAPI.Application.Repositories;
using BudgetAPI.Persistence.Repositories;

namespace BudgetAPI.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<BudgetAPIDbContext>(options => options.UseNpgsql(Configuration.ConncetionString));

            services.AddScoped<IUserReadRepository,UserReadRepository>();
            services.AddScoped<IUserWriteRepository, UserWriteRepository>();

            services.AddScoped<IBudgetReadRepository, BudgetReadRepository>();
            services.AddScoped<IBudgetWriteRepository, BudgetWriteRepository>();
           
        }
    }
}
