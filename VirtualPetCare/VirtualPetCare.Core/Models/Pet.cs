using VirtualPetCare.Core.Models.Abstracts;

namespace VirtualPetCare.Core.Models;

public sealed class Pet : BaseEntity
{
    public string Name { get; set; }
    public int Age { get; set; }

    public int HealthStatusId { get; set; }
    public HealthStatus HealthStatus { get; set; }

    public int SpeciesId { get; set; }
    public Species Species { get; set; }

    public int? OwnerId { get; set; }
    public User? Owner { get; set; }

    public ICollection<Activity>? Activities { get; set; }
    public ICollection<Food>? Foods { get; set; }
}
