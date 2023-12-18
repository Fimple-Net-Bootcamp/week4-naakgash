namespace VirtualPetCare.Core.Models.Abstracts;

public abstract class BaseItemEntity : BaseEntity
{
    public string Name { get; set; }
    public string? Description { get; set; }
}
