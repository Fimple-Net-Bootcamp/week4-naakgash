using VirtualPetCare.Core.IRepositories;
using VirtualPetCare.Core.IServices;
using VirtualPetCare.Core.Models;

namespace VirtualPetCare.Service.Services;

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;
    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }
    public async Task<User> GetByIdAsync(int id)
    {
        return await _userRepository.GetByIdAsync(id);
    }

    public async Task<User> CreateAsync(User user)
    {
        return await _userRepository.CreateAsync(user);
    }
}
