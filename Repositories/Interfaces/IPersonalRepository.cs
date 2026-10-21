using OnboardingApi.Models;

namespace OnboardingApi.Repositories.Interfaces;

public interface IPersonalRepository
{
    Task<IEnumerable<Personal>> GetAllAsync();

    Task<Personal?> GetByIdAsync(int id);

    Task<Personal> CreateAsync(Personal personal);

    Task UpdateAsync(Personal personal);

    Task DeleteAsync(Personal personal);
}