using VirtualPetCare.Core.Models;

namespace VirtualPetCare.Core.IRepositories;

public interface IFoodRepository
{
    Task<IEnumerable<Food>> GetAllAsync();
}
