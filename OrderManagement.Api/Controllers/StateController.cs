using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrderManagement.BLL.Models;
using OrderManagement.BLL.Services;

namespace OrderManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StateController : ControllerBase
    {
        private readonly IStateService _stateService;

        public StateController(IStateService stateService)
        {
            _stateService = stateService;
        }

        [HttpGet("{id}")]
        public ActionResult<State> State(int id)
        {
            try
            {
                var response = this._stateService.GetStateById(id).Result;

                if (response == null)
                {
                    return NotFound();
                }

                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("States")]
        public ActionResult<IEnumerable<State>> StateList()
        {
            try
            {
                var response = this._stateService.GetStates().Result;

                if (response == null)
                {
                    return NotFound();
                }

                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("")]
        public async Task<StateUpdateResponse> Create([FromBody] State state)
        {
            return await _stateService.Create(state);
        }

        [HttpPut("{id}")]
        public async Task<bool> Update(int id, [FromBody] State state)
        {
            await _stateService.Update(id, state);
            return true;
        }
    }
}
