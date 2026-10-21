using OnboardingApi.DTOs.Personal;

namespace OnboardingApi.Services.Interfaces;

public interface IPersonalService
{
    Task<IEnumerable<PersonalResponseDto>> GetAllAsync();

    Task<PersonalResponseDto?> GetByIdAsync(int id);

    Task<PersonalResponseDto> CreateAsync(CreatePersonalDto dto);

    Task<bool> UpdateAsync(int id, UpdatePersonalDto dto);

    Task<bool> DeleteAsync(int id);
}