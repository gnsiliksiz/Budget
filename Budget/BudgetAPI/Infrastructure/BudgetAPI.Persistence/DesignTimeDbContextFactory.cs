using System;
using Microsoft.EntityFrameworkCore.Design;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BudgetAPI.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace BudgetAPI.Persistence
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<BudgetAPIDbContext>
    {
        public BudgetAPIDbContext CreateDbContext(string[] args)
        {
           
            DbContextOptionsBuilder<BudgetAPIDbContext> dbContextOptionsBuilder = new();
            dbContextOptionsBuilder.UseNpgsql(Configuration.ConncetionString);
            return new(dbContextOptionsBuilder.Options);
        }
    }
}
