using GardenApp.Entities;

namespace GardenApp.Infrastructure.Repositories.UserRepository
{
    public interface IUserRepository: IRepository<User>
    {
        Task<User> GetUserByUsername(string username);
    }
}
