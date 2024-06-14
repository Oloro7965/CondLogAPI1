using CondLogAPI.application.Commands.CreateOcurrenceCommand;
using CondLogAPI.application.Commands.UpdateOcurrenceCommand;
using Microsoft.AspNetCore.Mvc;

namespace CondLogAPI.Controllers
{
    [Route("api/ocurrences")]
    public class OcurrenceController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            return Ok();
        }
        [HttpPost]
        public IActionResult Post([FromBody] CreateOcurrenceCommand command) {
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateOcurrence([FromBody] UpdateOcurrenceCommand command)
        {
            return Ok();
        }
    }
}
