using VirtualPetCare.Core.Models;

namespace VirtualPetCare.Core.IServices;

public interface IFoodService
{
    Task<IEnumerable<Food>> GetAllAsync();
}
