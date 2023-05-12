using AutoMapper;
using OrderManagement.BLL.Models;
using OrderManagement.DAL.Data;
using OrderManagement.DAL.Entities;

namespace OrderManagement.BLL.Services
{
    public class OrderService : IOrderService
    {
        private readonly IRepository<OrderDto> _orderRepository;
        private IMapper _mapper;

        public OrderService(IRepository<OrderDto> orderRepository, IMapper mapper)
        {
            _orderRepository = orderRepository;
            _mapper = mapper;
        }

        public async Task<Order> GetOrderById(int id)
        {
            var response = new Order();

            var data = await _orderRepository.GetByIdAsync(id);
            response = _mapper.Map<OrderDto, Order>(data);

            return response;
        }

        public async Task<IEnumerable<Order>> GetOrders()
        {
            var data = await _orderRepository.GetAllAsync();
            IEnumerable<Order> response = _mapper.Map<IEnumerable<OrderDto>, IEnumerable<Order>>(data);

            return response;
        }

        public async Task<OrderUpdateResponse> Create(Order model)
        {
            var response = new OrderUpdateResponse();
            var savedModel = new OrderDto();

            OrderDto dto = _mapper.Map<Order, OrderDto>(model);

            if (dto != null)
            {
                savedModel = await _orderRepository.CreateAsync(dto);

                //Save Dto
                if (savedModel == null)
                {
                    response.ErrorMessage = "Order failed to create.";
                }
            }
            else
            {
                response.ErrorMessage = "Error mapping Order to data object";
            }

            //return Order, if create is successful.
            if (response.ErrorMessage == null)
            {
                response.Result = _mapper.Map<OrderDto, Order>(savedModel); ;
            }
            return response;
        }

        public async Task<bool> Update(int id, Order model)
        {
            var data = await _orderRepository.GetByIdAsync(id);
            if (data != null)
            {
                data.Name = model.Name;
                await _orderRepository.UpdateAsync(data);
                return true;
            }
            else
                return false;
        }
    }
}
