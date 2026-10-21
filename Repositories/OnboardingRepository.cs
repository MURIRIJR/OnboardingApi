using Microsoft.EntityFrameworkCore;
using OnboardingApi.Data;
using OnboardingApi.Models;
using OnboardingApi.Repositories.Interfaces;

namespace OnboardingApi.Repositories;

public class OnboardingRepository : IOnboardingRepository
{
    private readonly ApplicationDbContext _context;

    public OnboardingRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Onboarding>> GetAllAsync()
    {
        return await _context.Onboardings.ToListAsync();
    }

    public async Task<Onboarding?> GetByIdAsync(int id)
    {
        return await _context.Onboardings.FindAsync(id);
    }

    public async Task<Onboarding> CreateAsync(Onboarding onboarding)
    {
        _context.Onboardings.Add(onboarding);
        await _context.SaveChangesAsync();

        return onboarding;
    }

    public async Task UpdateAsync(Onboarding onboarding)
    {
        _context.Onboardings.Update(onboarding);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Onboarding onboarding)
    {
        _context.Onboardings.Remove(onboarding);
        await _context.SaveChangesAsync();
    }
}