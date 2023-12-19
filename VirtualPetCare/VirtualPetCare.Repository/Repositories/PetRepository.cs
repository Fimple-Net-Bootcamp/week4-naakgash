using Microsoft.EntityFrameworkCore;
using VirtualPetCare.Core.IRepositories;
using VirtualPetCare.Core.Models;

namespace VirtualPetCare.Repository.Repositories;

public class PetRepository : IPetRepository
{
    private readonly PetCareDbContext _petCareDbContext;
    public PetRepository(PetCareDbContext petCareDbContext)
    {
        _petCareDbContext = petCareDbContext;
    }

    public async Task<Pet> CreateAsync(Pet pet)
    {
        await _petCareDbContext.Pets.AddAsync(pet);
        await _petCareDbContext.SaveChangesAsync();
        return pet;
    }

    public async Task<Pet> FeedAsync(Pet pet)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<Activity>> GetActivitiesByIdAsync(int id)
    {
        var petActivities = await _petCareDbContext.Pets
                                         .Where(p => p.Id == id)
                                         .SelectMany(p => p.Activities)
                                         .ToListAsync();
        return petActivities;
    }

    public async Task<IEnumerable<Pet>> GetAllAsync()
    {
        var pets = await _petCareDbContext.Pets.ToListAsync();
        return pets;
    }

    public async Task<Pet> GetByIdAsync(int id)
    {
        var pet = await _petCareDbContext.Pets.FindAsync(id);
        return pet;
    }

    public async Task<HealthStatus> GetHealthStatusByIdAsync(int id)
    {
        var petHealthStatus = await _petCareDbContext.Pets
                                           .Where(p => p.Id == id)
                                           .Select(p => p.HealthStatus)
                                           .FirstOrDefaultAsync();
        return petHealthStatus;
    }

    public async Task<Pet> UpdateAsync(Pet pet)
    {
        _petCareDbContext.Update(pet);
        await _petCareDbContext.SaveChangesAsync();
        return pet;
    }

    public async Task<Pet> UpdateHealthStatusAsync(Pet pet)
    {
        throw new NotImplementedException();
    }
}
