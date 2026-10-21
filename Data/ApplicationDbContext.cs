using Microsoft.EntityFrameworkCore;
using OnboardingApi.Models;

namespace OnboardingApi.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Personal> Personals { get; set; }

    public DbSet<Address> Addresses { get; set; }

    public DbSet<Onboarding> Onboardings { get; set; }
}