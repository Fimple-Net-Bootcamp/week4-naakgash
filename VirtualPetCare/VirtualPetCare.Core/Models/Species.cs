using VirtualPetCare.Core.Models.Abstracts;

namespace VirtualPetCare.Core.Models;

public sealed class Species : BaseItemEntity
{
    public string ScientificName { get; set; }
    public ICollection<Pet>? Pets { get; set; }
}
