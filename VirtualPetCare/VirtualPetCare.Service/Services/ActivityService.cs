using VirtualPetCare.Core.IRepositories;
using VirtualPetCare.Core.IServices;
using VirtualPetCare.Core.Models;

namespace VirtualPetCare.Service.Services;

public class ActivityService : IActivityService
{
    private readonly IActivityRepository _activityRepository;
    public ActivityService(IActivityRepository activityRepository)
    {
        _activityRepository = activityRepository;
    }
    public Task<Activity> CreateAsync(Activity activity)
    {
        return _activityRepository.CreateAsync(activity);
    }
}
