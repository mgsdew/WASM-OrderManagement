using Microsoft.EntityFrameworkCore;
using OrderManagement.DAL.Entities;

namespace OrderManagement.DAL.Data
{
    public class OrderRepository : IRepository<OrderDto>
    {
        private readonly OrderMgtDbContext _dbContext;

        public OrderRepository(OrderMgtDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public async Task<List<OrderDto>> GetAllAsync()
        {
            return await _dbContext.Order.Include(o=>o.State).ToListAsync();
        }

        public async Task<OrderDto> GetByIdAsync(int Id)
        {
            return await _dbContext.Order.Include(o => o.State).SingleOrDefaultAsync(x => x.Id == Id);
        }

        public async Task<OrderDto> CreateAsync(OrderDto _object)
        {
            var obj = await _dbContext.Order.AddAsync(_object);
            _dbContext.SaveChanges();
            return obj.Entity;
        }

        public async Task UpdateAsync(OrderDto _object)
        {
            _dbContext.Order.Update(_object);
            await _dbContext.SaveChangesAsync();
        }
    }
}
