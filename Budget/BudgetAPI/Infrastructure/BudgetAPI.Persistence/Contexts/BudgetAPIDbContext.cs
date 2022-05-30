using BudgetAPI.Domain.Entities;
using BudgetAPI.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetAPI.Persistence.Contexts
{
    public  class BudgetAPIDbContext: DbContext
    {
        public BudgetAPIDbContext (DbContextOptions options): base(options)
        {}
        public DbSet<Budget> Budgets { get; set; }
        public DbSet<User> Users { get; set; }
      
        //public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        //{
        //    var datas = ChangeTracker
        //        .Entries<BaseEntity>();

        //    foreach(var data in datas)
        //    {
        //         _ = data.State switch
        //        {
        //            EntityState.Added => data.Entity.CreatedDate=DateTime.UtcNow,
                   
                  
        //        };
        //    }
        //    return await base.SaveChangesAsync(cancellationToken);
        //}
    }
}
