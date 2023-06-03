using Gardens.Entitiy;
using Microsoft.EntityFrameworkCore;

namespace Gardens.Data.Repositories
{
    public class EFGardenRepository : IGardenRepository
    {
        private readonly GardenDbContext gardenDbContext;
        public EFGardenRepository(GardenDbContext gardenDbContext)
        {
            this.gardenDbContext = gardenDbContext;
        }

        public async Task CreateAsync(Garden entity)
        {
            await gardenDbContext.Gardens.AddAsync(entity);
            await gardenDbContext.SaveChangesAsync(); // Persistance API
        }

        public async Task DeleteAsync(int id)
        {
            var garden = await gardenDbContext.Gardens.AsNoTracking().FirstOrDefaultAsync(g => g.Id == id);
            gardenDbContext.Gardens.Remove(garden);
            await gardenDbContext.SaveChangesAsync();
        }

        public async Task<IList<Garden>> GetAllAsync()
        {
            return await gardenDbContext.Gardens.AsNoTracking().Include(go => go.Owners)
                                                               .ThenInclude(o => o.Owner)
                                                               .ToListAsync();  
        }

        public async Task<Garden?> GetByIdAsync(int id)
        {
            return await gardenDbContext.Gardens.AsNoTracking().FirstOrDefaultAsync(g => g.Id == id);
        }

        public async Task<IList<Garden>> SearchGardenByName(string name)
        {
            return await gardenDbContext.Gardens.AsNoTracking()
                                         .Where(g => g.Name.Contains(name))
                                         .ToListAsync();   
        }

        public async Task UpdateAsync(Garden entity)
        {
            gardenDbContext.Gardens.Update(entity);
            await gardenDbContext.SaveChangesAsync();
        }
    }
}
