using GardenApp.DataTransferObjects.Requests;
using GardenApp.Entities;
using GardenApp.Infrastructure.Repositories.UserRepository;

namespace GardenApp.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;
        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }
        public async Task<User?> ValidateUser(UserLoginRequest request)
        {
            var user = await userRepository.GetUserByUsername(request.Username);
            if (user != null && user.Password.Equals(request.Password))
            {
                return user;
            }
            return null;
        }
    }
}
