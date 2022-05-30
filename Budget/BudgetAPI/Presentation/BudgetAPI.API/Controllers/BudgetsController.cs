using BudgetAPI.Application.Repositories;
using BudgetAPI.Application.ViewModels.Budgets;
using BudgetAPI.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace BudgetAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BudgetsController : ControllerBase
    {
        readonly private IBudgetWriteRepository _budgetWriteRepository;
        readonly private IBudgetReadRepository _budgetReadRepository;
        readonly private IUserReadRepository _userReadRepository;

        public BudgetsController(IBudgetWriteRepository budgetWriteRepository,IBudgetReadRepository budgetReadRepository, IUserReadRepository userReadRepository)
        {
            _budgetWriteRepository = budgetWriteRepository;
            _budgetReadRepository = budgetReadRepository;
            _userReadRepository = userReadRepository;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(_budgetReadRepository.GetAll(false).Select(p => new
            {
                p.Id,
                p.BudgetType,
                p.BudgetDate,
                p.Quantity
            }));
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            return Ok(_budgetReadRepository.GetByIdAsync(id, false));
        }
        [HttpPost]
        public async Task<IActionResult> Post(VM_Create_Budget model)
        {
           
            var d = _userReadRepository.GetWhere(x => x.Id == model.UserId).FirstOrDefault();
            try
            {
             
                await _budgetWriteRepository.AddAsync(new()
                {
                    Quantity = model.Quantity,
                    BudgetDate =DateTime.UtcNow,
                    BudgetType = model.BudgetType,
                    UserId = model.UserId                                                        

                });
              
                await _budgetWriteRepository.SaveAsync();
                return StatusCode((int)HttpStatusCode.Created);
            }
            catch (Exception e)
            {

                throw  e;
            }

          
        }
        [HttpPut]
        public async Task<IActionResult> Put(VM_Update_Budget model)
        {
            Budget budget = await _budgetReadRepository.GetByIdAsync(model.Id);
            budget.Quantity = model.Quantity;
            budget.BudgetDate = model.BudgetDate;
            budget.BudgetType = model.BudgetType;

            await _budgetWriteRepository.SaveAsync();
            return Ok();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {

            await _budgetWriteRepository.RemoveAsync(id);
            await _budgetWriteRepository.SaveAsync();
            return Ok();
        }


    }
}
