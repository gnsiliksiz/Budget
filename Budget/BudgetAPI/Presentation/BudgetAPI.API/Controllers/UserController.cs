using BudgetAPI.Application.Repositories;
using BudgetAPI.Application.ViewModels.Users;
using BudgetAPI.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace BudgetAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        readonly private IUserWriteRepository _usertWriteRepository;
        readonly private IUserReadRepository _userReadRepository;

        public UserController(IUserWriteRepository userWriteRepository, IUserReadRepository userReadRepository)
        {
            _usertWriteRepository = userWriteRepository;
            _userReadRepository = userReadRepository;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(_userReadRepository.GetAll(false));
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            return Ok(_userReadRepository.GetByIdAsync(id,false));
        }
        [HttpPost]
       public async Task<IActionResult> Post(VM_Create_User model)
        {
            _usertWriteRepository.AddAsync(new()
            {
                Name=model.Name,
                LastName=model.LastName

            });
            await _usertWriteRepository.SaveAsync();
            return StatusCode((int)HttpStatusCode.Created);
        }
        [HttpPut]
        public async Task<IActionResult> Put(VM_Update_User model)
        {
            User user = await _userReadRepository.GetByIdAsync(model.Id);
            user.Name = model.Name;
            user.LastName = model.LastName;
            await _usertWriteRepository.SaveAsync();
            return Ok();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            
            await _usertWriteRepository.RemoveAsync(id);
            await _usertWriteRepository.SaveAsync();
            return Ok();
        }


    }
}
