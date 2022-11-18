using ColdQuackRealSystem.API.Controllers.Base;
using ColdQuackRealSystem.Commands.FrozenDuck;
using ColdQuackRealSystem.Queries.FrozenDuck;
using Microsoft.AspNetCore.Mvc;

namespace ColdQuackRealSystem.API.Controllers
{
    public class FrozenDuckController : BaseController
    {
        [HttpGet("Ducks")]
        public async Task<IActionResult> GetFrozenDuck([FromQuery] GetFrozenDuckQuery query)
        {
            try
            {
                var response = await Mediator.Send(query);
                return Ok(response);
            }
            catch
            {
                return NotFound();
            }
        }

        [HttpGet("Duck")]
        public async Task<IActionResult> GetFrozenDuckById([FromQuery] GetFrozenDuckByIdQuery query)
        {
            try
            {
                var response = await Mediator.Send(query);
                return Ok(response);
            }
            catch
            {
                return NotFound();
            }
        }

        [HttpPost("Duck")]
        public async Task<IActionResult> CreateFrozenDuck([FromQuery] CreateFrozenDuckCommand query)
        {
            try
            {
                var response = await Mediator.Send(query);
                return Ok(response);
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpPatch("Duck")]
        public async Task<IActionResult> UpdateFrozenDuck([FromQuery] UpdateFrozenDuckCommand query)
        {
            try
            {
                var response = await Mediator.Send(query);
                return Ok(response);
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpDelete("Duck")]
        public async Task<IActionResult> DeleteFrozenDuck([FromQuery] DeleteFrozenDuckCommand query)
        {
            try
            {
                var response = await Mediator.Send(query);
                return Ok(response);
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
