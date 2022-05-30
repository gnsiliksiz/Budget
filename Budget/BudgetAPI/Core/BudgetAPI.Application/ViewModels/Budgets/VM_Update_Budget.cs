using BudgetAPI.Domain.Entities;
using BudgetAPI.Domain.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetAPI.Application.ViewModels.Budgets
{
    public class VM_Update_Budget
    {
        public string Id { get; set; }
        public Double Quantity { get; set; }
        public DateTime BudgetDate { get; set; }

        public BudgetType BudgetType { get; set; }
        
    }
}
