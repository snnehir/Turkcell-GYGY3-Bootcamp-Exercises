using GardenApp.DataTransferObjects.Requests;
using GardenApp.Entities;

namespace GardenApp.Services
{
    public interface IUserService
    {
        Task<User?> ValidateUser(UserLoginRequest request);
    }
}
