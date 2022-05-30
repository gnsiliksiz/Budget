using BudgetAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetAPI.Domain.Entities
{
    public class User : BaseEntity
    {

        
        public string Name { get; set; }
        public string LastName { get; set; }
        ICollection<Budget> Budgets { get; set; }


    }
}
