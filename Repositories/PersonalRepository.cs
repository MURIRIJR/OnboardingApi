using Microsoft.EntityFrameworkCore;
using OnboardingApi.Data;
using OnboardingApi.Models;
using OnboardingApi.Repositories.Interfaces;

namespace OnboardingApi.Repositories;

public class PersonalRepository : IPersonalRepository
{
    private readonly ApplicationDbContext _context;

    public PersonalRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Personal>> GetAllAsync()
    {
        return await _context.Personals.ToListAsync();
    }

    public async Task<Personal?> GetByIdAsync(int id)
    {
        return await _context.Personals.FindAsync(id);
    }

    public async Task<Personal> CreateAsync(Personal personal)
    {
        _context.Personals.Add(personal);
        await _context.SaveChangesAsync();

        return personal;
    }

    public async Task UpdateAsync(Personal personal)
    {
        _context.Personals.Update(personal);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Personal personal)
    {
        _context.Personals.Remove(personal);
        await _context.SaveChangesAsync();
    }
}