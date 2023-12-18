using VirtualPetCare.Core.Models.Abstracts;

namespace VirtualPetCare.Core.Models;

public sealed class HealthStatus : BaseItemEntity
{
    public ICollection<Pet>? Pets { get; set; }
}
