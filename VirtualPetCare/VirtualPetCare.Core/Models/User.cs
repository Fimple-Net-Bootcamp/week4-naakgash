using VirtualPetCare.Core.Models.Abstracts;

namespace VirtualPetCare.Core.Models;

public sealed class User : BaseEntity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }

    public ICollection<Pet>? Pets { get; set; }
}
