using Microsoft.AspNetCore.Mvc;
using OrderManagement.BLL.Models;
using OrderManagement.BLL.Services;

namespace OrderManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ElementTypeController : ControllerBase
    {
        private readonly IElementTypeService _eTypeService;

        public ElementTypeController(IElementTypeService eTypeService)
        {
            _eTypeService = eTypeService;
        }

        [HttpGet("{id}")]
        public async Task<ElementType> ElementType(int id)
        {
            return await this._eTypeService.GetElementTypeById(id);
        }

        [HttpGet("ElementTypes")]
        public async Task<IEnumerable<ElementType>> ElementTypeList()
        {
            IEnumerable<ElementType> response;

            response = await this._eTypeService.GetElementTypes();

            if (response == null)
            {
                return null;
            }

            return response;
        }

        [HttpPost("")]
        public async Task<ElementTypeUpdateResponse> Create([FromBody] ElementType element)
        {
            return await _eTypeService.Create(element);
        }

        [HttpPut("{id}")]
        public async Task<bool> Update(int id, [FromBody] ElementType Object)
        {
            await _eTypeService.Update(id, Object);
            return true;
        }
    }
}
