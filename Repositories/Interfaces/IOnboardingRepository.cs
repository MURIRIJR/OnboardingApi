using OnboardingApi.Models;

namespace OnboardingApi.Repositories.Interfaces;

public interface IOnboardingRepository
{
    Task<IEnumerable<Onboarding>> GetAllAsync();

    Task<Onboarding?> GetByIdAsync(int id);

    Task<Onboarding> CreateAsync(Onboarding onboarding);

    Task UpdateAsync(Onboarding onboarding);

    Task DeleteAsync(Onboarding onboarding);
}