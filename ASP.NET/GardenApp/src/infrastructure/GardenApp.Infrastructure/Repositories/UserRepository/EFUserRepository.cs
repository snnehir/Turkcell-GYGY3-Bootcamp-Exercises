using GardenApp.Entities;
using GardenApp.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace GardenApp.Infrastructure.Repositories.UserRepository
{
    public class EFUserRepository : IUserRepository
    {
        private readonly GardenAppDbContext context;
        public EFUserRepository(GardenAppDbContext context)
        {
            this.context = context;
        }
        public async Task CreateAsync(User entity)
        {
            await context.Users.AddAsync(entity);
            await context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var user = await context.Users.FindAsync(id);
            context.Users.Remove(user);
            await context.SaveChangesAsync();
        }

        public User? Get(int id)
        {
            return context.Users.SingleOrDefault(u => u.Id == id);
        }

        public IList<User?> GetAll()
        {
            return context.Users.AsNoTracking().ToList();
        }

        public async Task<IList<User?>> GetAllAsync()
        {
            return await context.Users.AsNoTracking().ToListAsync();
        }

        public IList<User> GetAllWithPredicate(Expression<Func<User, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public async Task<User?> GetAsync(int id)
        {
            return await context.Users.SingleOrDefaultAsync(u => u.Id == id);
        }

        public async Task<User> GetUserByUsername(string username)
        {
            return await context.Users.SingleOrDefaultAsync(u => u.Username.Equals(username));
        }

        public async Task UpdateAsync(User entity)
        {
            context.Users.Update(entity);
            await context.SaveChangesAsync();

        }
    }
}
