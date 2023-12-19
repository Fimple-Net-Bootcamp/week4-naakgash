using VirtualPetCare.Core.Models;

namespace VirtualPetCare.Core.IServices;

public interface IActivityService
{
    Task<Activity> CreateAsync(Activity activity);
}
