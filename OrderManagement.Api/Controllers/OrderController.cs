using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrderManagement.BLL.Models;
using OrderManagement.BLL.Services;

namespace OrderManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet("Order/{id}")]
        public ActionResult<Order> GetOrder(int id)
        {
            try
            {
                var response = this._orderService.GetOrderById(id).Result;

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

        [HttpGet("OrderList")]
        public ActionResult<IEnumerable<Order>> GetOrders()
        {
            try
            {
                var response = this._orderService.GetOrders().Result;

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
        public async Task<OrderUpdateResponse> Create([FromBody] Order newOrder)
        {
            return await _orderService.Create(newOrder);
        }

        [HttpPut("{id}")]
        public async Task<bool> Update(int id, [FromBody] Order order)
        {
            await _orderService.Update(id, order);
            return true;
        }
    }
}
