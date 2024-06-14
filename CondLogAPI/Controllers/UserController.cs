using CondLogAPI.application.Commands.CreateUserCommand;
using CondLogAPI.application.Commands.UpdateUserCommand;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace CondLogAPI.Controllers
{
    [Route("Api/users")]
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public IActionResult GetAllUsers()
        {
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetUserById(Guid id) {
            return Ok();
        }

        [HttpPost]
        public IActionResult Post([FromBody] CreateUserCommand command)
        {
            return Ok();
        }
        [HttpPut]
        public IActionResult Update([FromBody] UpdateUserCommand command)
        {
            return Ok();
        }
        [HttpDelete]
        public IActionResult Delete(Guid id) {
            return Ok();
        }
    }
}
