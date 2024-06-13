using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace CondLogAPI.Controllers
{
    [Route("Api/users")]
    public class UserController : ControllerBase
    {
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
