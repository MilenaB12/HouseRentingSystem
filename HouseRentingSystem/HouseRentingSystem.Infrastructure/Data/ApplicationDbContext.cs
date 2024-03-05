using HouseRentingSystem.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HouseRentingSystem.Ifrastructure.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<House>()
            .HasOne(h => h.Category)
            .WithMany(c => c.Houses)
            .HasForeignKey(h => h.CategoryId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.Entity<House>()
        .HasOne(h => h.Agent)
        .WithMany(c => c.Houses)
        .HasForeignKey(h => h.AgentId)
        .OnDelete(DeleteBehavior.Restrict);

        base.OnModelCreating(builder);
    }

    public DbSet<Agent> Agents { get; set; } = null!;

    public DbSet<House> Houses { get; set; } = null!;

    public DbSet<Category> Categories { get; set; } = null!;

}

