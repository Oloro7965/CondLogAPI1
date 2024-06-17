using CondLogAPI.application.Commands.CreateOcurrenceCommand;
using CondLogAPI.application.Commands.UpdateOcurrenceCommand;
using CondLogAPI.application.Queries.GetAllOcurrences;
using CondLogAPI.application.Queries.GetAllUsers;
using CondLogAPI.application.Queries.GetOcurrence;
using CondLogAPI.application.Queries.GetUser;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CondLogAPI.Controllers
{
    [Route("api/ocurrences")]
    [ApiController]
    public class OcurrenceController : ControllerBase
    {
        private readonly IMediator _mediator;

        public OcurrenceController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var Query = new GetAllOcurrencesQuery();

            var ocurrences = await _mediator.Send(Query);

            return Ok(ocurrences);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var query = new GetOcurrenceQuery(id);

            var ocurrence = await _mediator.Send(query);

            return Ok(ocurrence);
        }
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateOcurrenceCommand command) {
            var ocurrenceId = await _mediator.Send(command);

            return CreatedAtAction(nameof(GetById), new { id = ocurrenceId }, command);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateOcurrence([FromBody] UpdateOcurrenceCommand command)
        {
            await _mediator.Send(command);

            return NoContent();
        }
    }
}
