using VirtualPetCare.Core.Models;

namespace VirtualPetCare.Core.IServices;

public interface IUserService
{
    Task<User> InsertAsync(User user);
    Task<User> GetByIdAsync(int id);
}
