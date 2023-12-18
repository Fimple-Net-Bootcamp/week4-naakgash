using Microsoft.EntityFrameworkCore;
using VirtualPetCare.Core.Models;

namespace VirtualPetCare.Repository;

public class PetCareDbContext : DbContext
{
    public PetCareDbContext(DbContextOptions<PetCareDbContext> options) : base(options)
    {
        
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Pet> Pets { get; set; }
    public DbSet<HealthStatus> HealthStatuses { get; set; }
    public DbSet<Food> Foods { get; set; }
    public DbSet<Activity> Activities { get; set; }
    public DbSet<Species> Species { get; set; }
}
