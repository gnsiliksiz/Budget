using BudgetAPI.Application.Repositories;
using BudgetAPI.Domain.Entities;
using BudgetAPI.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetAPI.Persistence.Repositories
{
    public  class BudgetReadRepository :ReadRepository<Budget>, IBudgetReadRepository
    {
        public BudgetReadRepository(BudgetAPIDbContext context) : base(context)
    {
    }
}
}
