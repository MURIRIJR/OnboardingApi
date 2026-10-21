using OnboardingApi.DTOs.Onboarding;

namespace OnboardingApi.Services.Interfaces;

public interface IOnboardingService
{
    Task<IEnumerable<OnboardingResponseDto>> GetAllAsync();

    Task<OnboardingResponseDto?> GetByIdAsync(int id);

    Task<OnboardingResponseDto> CreateAsync(CreateOnboardingDto dto);

    Task<bool> UpdateAsync(int id, UpdateOnboardingDto dto);

    Task<bool> DeleteAsync(int id);
}