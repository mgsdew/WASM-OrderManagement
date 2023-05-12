using Microsoft.EntityFrameworkCore;
using OrderManagement.DAL.Entities;

namespace OrderManagement.DAL.Data
{
    public class ElementTypeRepository : IRepository<ElementTypeDto>
    {
        private readonly OrderMgtDbContext _dbContext;

        public ElementTypeRepository(OrderMgtDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public async Task<List<ElementTypeDto>> GetAllAsync()
        {
            return await _dbContext.ElementType.ToListAsync();
        }
        public async Task<ElementTypeDto> GetByIdAsync(int Id)
        {
            return await _dbContext.ElementType.FirstOrDefaultAsync(x => x.Id == Id);
        }

        public async Task<ElementTypeDto> CreateAsync(ElementTypeDto _object)
        {
            var obj = await _dbContext.ElementType.AddAsync(_object);
            _dbContext.SaveChanges();
            return obj.Entity;
        }
        public async Task UpdateAsync(ElementTypeDto _object)
        {
            _dbContext.ElementType.Update(_object);
            await _dbContext.SaveChangesAsync();
        }
    }
}
