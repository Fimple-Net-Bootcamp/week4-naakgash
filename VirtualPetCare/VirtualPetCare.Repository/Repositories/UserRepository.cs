using VirtualPetCare.Core.IRepositories;
using VirtualPetCare.Core.Models;

namespace VirtualPetCare.Repository.Repositories;

public class UserRepository : IUserRepository
{
    private readonly PetCareDbContext _petCareDbContext;
    public UserRepository(PetCareDbContext petCareDbContext)
    {
        _petCareDbContext = petCareDbContext;
    }
    public async Task<User> GetByIdAsync(int id)
    {
        var user = await _petCareDbContext.Users.FindAsync(id);
        return user;
    }

    public async Task<User> CreateAsync(User user)
    {
        await _petCareDbContext.Users.AddAsync(user);
        await _petCareDbContext.SaveChangesAsync();
        return user;
    }
}
