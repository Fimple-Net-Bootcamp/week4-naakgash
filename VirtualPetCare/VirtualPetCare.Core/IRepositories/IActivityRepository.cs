using VirtualPetCare.Core.Models;

namespace VirtualPetCare.Core.IRepositories;

public interface IActivityRepository
{
    Task<Activity> CreateAsync(Activity activity);
}
