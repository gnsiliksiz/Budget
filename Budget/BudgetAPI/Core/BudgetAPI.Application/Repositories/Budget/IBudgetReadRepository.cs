using BudgetAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetAPI.Application.Repositories
{
    public interface IBudgetReadRepository:IReadRepository<Budget>
    {
    }
}
