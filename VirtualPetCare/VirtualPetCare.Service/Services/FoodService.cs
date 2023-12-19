using VirtualPetCare.Core.IRepositories;
using VirtualPetCare.Core.IServices;
using VirtualPetCare.Core.Models;

namespace VirtualPetCare.Service.Services;

public class FoodService : IFoodService
{
    private readonly IFoodRepository _foodRepository;
    public FoodService(IFoodRepository foodRepository)
    {
        _foodRepository = foodRepository;
    }
    public async Task<IEnumerable<Food>> GetAllAsync()
    {
        return await _foodRepository.GetAllAsync();
    }
}
