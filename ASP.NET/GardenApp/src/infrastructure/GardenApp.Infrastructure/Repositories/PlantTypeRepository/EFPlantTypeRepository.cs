using GardenApp.Entities;
using GardenApp.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace GardenApp.Infrastructure.Repositories.PlantTypeRepository
{
    public class EFPlantTypeRepository : IPlantTypeRepository
    {
        private readonly GardenAppDbContext _context;
        public EFPlantTypeRepository(GardenAppDbContext context)
        {
            _context = context;
        }
        public async Task CreateAsync(PlantType entity)
        {
            await _context.PlantTypes.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var deleting = await _context.PlantTypes.FindAsync(id);
            _context.PlantTypes.Remove(deleting);
            await _context.SaveChangesAsync();
        }

        public PlantType? Get(int id)
        {
            return _context.PlantTypes.SingleOrDefault(p => p.Id == id);
        }

        public IList<PlantType?> GetAll()
        {
            return _context.PlantTypes.AsNoTracking().ToList();
        }

        public async Task<IList<PlantType?>> GetAllAsync()
        {
            return await _context.PlantTypes.AsNoTracking().ToListAsync();
        }

        public IList<PlantType> GetAllWithPredicate(Expression<Func<PlantType, bool>> predicate)
        {
            return _context.PlantTypes.AsNoTracking().Where(predicate).ToList();
        }

        public async Task<PlantType?> GetAsync(int id)
        {
            return await _context.PlantTypes.SingleOrDefaultAsync(p => p.Id == id);
        }

        public async Task UpdateAsync(PlantType entity)
        {
            _context.PlantTypes.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
