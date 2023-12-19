using VirtualPetCare.Core.Models;

namespace VirtualPetCare.Core.IServices;

public interface IUserService
{
    Task<User> CreateAsync(User user);
    Task<User> GetByIdAsync(int id);
}
