using VirtualPetCare.Core.Models;

namespace VirtualPetCare.Core.IServices;

public interface IPetService
{
    Task<Pet> CreateAsync(Pet pet);
    Task<IEnumerable<Pet>> GetAllAsync();
    Task<Pet> GetByIdAsync(int id);
    Task<Pet> UpdateAsync(Pet pet);
    Task<Pet> GetHealthStatusByIdAsync(int id);
    Task<Pet> UpdateHealthStatusAsync(Pet pet);
    Task<Pet> AddActivityAsync(Pet pet);
    Task<Pet> GetActivityByIdAsync(int id);
    Task<Pet> FeedAsync(Pet pet);
}
