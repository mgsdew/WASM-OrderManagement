using OrderManagement.BLL.Models;

namespace OrderManagement.BLL.Services
{
    public interface IOrderService
    {
        Task<IEnumerable<Order>> GetOrders();
        Task<Order> GetOrderById(int id);
        Task<OrderUpdateResponse> Create(Order model);
        Task<bool> Update(int id, Order model);
    }
}
