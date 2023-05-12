using Microsoft.EntityFrameworkCore;
using OrderManagement.DAL.Entities;

namespace OrderManagement.DAL.Data
{
    public class StateRepository : IRepository<StateDto>
    {
        private readonly OrderMgtDbContext _dbContext;

        public StateRepository(OrderMgtDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public async Task<List<StateDto>> GetAllAsync()
        {
            return await _dbContext.State.ToListAsync();
        }

        public async Task<StateDto> GetByIdAsync(int Id)
        {
            return await _dbContext.State.FirstOrDefaultAsync(x => x.Id == Id);
        }

        public async Task<StateDto> CreateAsync(StateDto _object)
        {
            var obj = await _dbContext.State.AddAsync(_object);
            _dbContext.SaveChanges();
            return obj.Entity;
        }

        public async Task UpdateAsync(StateDto _object)
        {
            _dbContext.State.Update(_object);
            await _dbContext.SaveChangesAsync();
        }

    }
}
