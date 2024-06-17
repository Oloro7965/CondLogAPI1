using CondLogAPI.application.Commands.CreateUserCommand;
using CondLogAPI.application.Commands.DeleteUserCommand;
using CondLogAPI.application.Commands.UpdateUserCommand;
using CondLogAPI.application.Queries.GetAllUsers;
using CondLogAPI.application.Queries.GetUser;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace CondLogAPI.Controllers
{
    [Route("Api/users")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllUsers()
        {
            var Query = new GetAllUsersQuery();

            var users = await _mediator.Send(Query);

            return Ok(users);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserById(Guid id) {

            var query = new GetUserQuery(id);

            var user = await _mediator.Send(query);

            return Ok(user);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateUserCommand command)
        {
            var userId = await _mediator.Send(command);

            return CreatedAtAction(nameof(GetUserById), new { id = userId }, command);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update([FromBody] UpdateUserCommand command)
        {
            //command.Id = id;

            await _mediator.Send(command);

            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id) {

            var command = new DeleteUserCommand(id);

            await _mediator.Send(command);

            //_userService.Delete(id);
            return Ok();
        }
    }
}
