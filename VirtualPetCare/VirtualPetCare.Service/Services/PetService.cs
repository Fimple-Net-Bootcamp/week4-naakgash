using VirtualPetCare.Core.IRepositories;
using VirtualPetCare.Core.IServices;
using VirtualPetCare.Core.Models;

namespace VirtualPetCare.Service.Services;

public class PetService : IPetService
{
    private readonly IPetRepository _petRepository;
    public PetService(IPetRepository petRepository)
    {
        _petRepository = petRepository;
    }

    public async Task<Pet> CreateAsync(Pet pet)
    {
        return await _petRepository.CreateAsync(pet);
    }

    public async Task<Pet> FeedAsync(Pet pet)
    {
        return await _petRepository.FeedAsync(pet);
    }

    public async Task<IEnumerable<Activity>> GetActivitiesByIdAsync(int id)
    {
        return await _petRepository.GetActivitiesByIdAsync(id);
    }

    public async Task<IEnumerable<Pet>> GetAllAsync()
    {
        return await _petRepository.GetAllAsync();
    }

    public async Task<Pet> GetByIdAsync(int id)
    {
        return await _petRepository.GetByIdAsync(id);
    }

    public async Task<HealthStatus> GetHealthStatusByIdAsync(int id)
    {
        return await _petRepository.GetHealthStatusByIdAsync(id);
    }

    public async Task<Pet> UpdateAsync(Pet pet)
    {
        return await _petRepository.UpdateAsync(pet);
    }

    public async Task<Pet> UpdateHealthStatusAsync(Pet pet)
    {
        return await _petRepository.UpdateHealthStatusAsync(pet);
    }
}
