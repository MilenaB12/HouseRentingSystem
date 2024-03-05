using HouseRentingSystem.Infrastructure.Data.Models;
using HouseRentingSystem.Infrastructure.Data.SeedDb;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HouseRentingSystem.Ifrastructure.Data;

public class HouseDbContext : IdentityDbContext
{
    public HouseDbContext(DbContextOptions<HouseDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfiguration(new UserConfiguration());
        builder.ApplyConfiguration(new AgentConfiguration());
        builder.ApplyConfiguration(new CategoryConfiguration());
        builder.ApplyConfiguration(new HouseConfiguration());

        base.OnModelCreating(builder);
    }

    public DbSet<Agent> Agents { get; set; } = null!;

    public DbSet<House> Houses { get; set; } = null!;

    public DbSet<Category> Categories { get; set; } = null!;

}

