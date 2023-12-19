using VirtualPetCare.Core.Models;

namespace VirtualPetCare.Repository.Repositories;

public class ActivityRepository
{
    private readonly PetCareDbContext _petCareDbContext;
    public ActivityRepository(PetCareDbContext petCareDbContext)
    {
        _petCareDbContext = petCareDbContext;
    }

    public async Task<Activity> CreateAsync(Activity activity)
    {
        await _petCareDbContext.Activities.AddAsync(activity);
        await _petCareDbContext.SaveChangesAsync();
        return activity;
    }
}
