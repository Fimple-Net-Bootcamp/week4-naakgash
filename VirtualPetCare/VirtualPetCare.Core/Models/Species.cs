using VirtualPetCare.Core.Models.Abstracts;

namespace VirtualPetCare.Core.Models;

public sealed class Species : BaseItemEntity
{
    public ICollection<Pet>? Pets { get; set; }
}
