using VirtualPetCare.Core.IRepositories;
using VirtualPetCare.Core.Models;

namespace VirtualPetCare.Repository.Repositories;

public class FoodRepository : IFoodRepository
{
    private readonly IFoodRepository _foodRepository;
    public FoodRepository(IFoodRepository foodRepository)
    {
        _foodRepository = foodRepository;
    }
    public async Task<IEnumerable<Food>> GetAllAsync()
    {
        return await _foodRepository.GetAllAsync();
    }
}
