using Gardens.Entitiy;

namespace Gardens.Data.Repositories
{
    public class EFGardenRepository : IGardenRepository
    {
        public Task CreateAsync(Garden entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Garden entity)
        {
            throw new NotImplementedException();
        }

        public Task<IList<Garden>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Garden> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IList<Garden>> SearchGardenByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Garden entity)
        {
            throw new NotImplementedException();
        }
    }
}
