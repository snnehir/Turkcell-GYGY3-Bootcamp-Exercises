using GardenApp.Entities;
using GardenApp.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace GardenApp.Infrastructure.Repositories.PlantRepository
{
    public class EFPlantRepository : IPlantRepository
    {
        private readonly GardenAppDbContext _context;
        public EFPlantRepository(GardenAppDbContext context)
        {
            _context = context;
        }
        public async Task CreateAsync(Plant entity)
        {
            await _context.Plants.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var deleting = await _context.Plants.FindAsync(id);
            _context.Plants.Remove(deleting);
            await _context.SaveChangesAsync();
        }

        public Plant? Get(int id)
        {
            return _context.Plants.SingleOrDefault(p => p.Id == id);
        }

        public IList<Plant?> GetAll()
        {
            return _context.Plants.AsNoTracking().ToList();
        }

        public async Task<IList<Plant?>> GetAllAsync()
        {
            return await _context.Plants.AsNoTracking().ToListAsync();
        }

        public IList<Plant> GetAllWithPredicate(Expression<Func<Plant, bool>> predicate)
        {
            return _context.Plants.AsNoTracking().Where(predicate).ToList();
        }

        public async Task<Plant?> GetAsync(int id)
        {
            return await _context.Plants.SingleOrDefaultAsync(p => p.Id == id);
        }

        public IEnumerable<Plant> GetPlantsByName(string name)
        {
            return _context.Plants.AsNoTracking().Where(p => p.Name.Contains(name)).AsEnumerable();
        }

        public IEnumerable<Plant> GetPlantsByType(int plantTypeId)
        {
            return _context.Plants.AsNoTracking().Where(p => p.PlantTypeId == plantTypeId).AsEnumerable();
        }

        public async Task UpdateAsync(Plant entity)
        {
            _context.Plants.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
