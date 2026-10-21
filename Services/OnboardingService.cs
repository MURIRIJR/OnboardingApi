using AutoMapper;
using OnboardingApi.DTOs.Onboarding;
using OnboardingApi.Models;
using OnboardingApi.Repositories.Interfaces;
using OnboardingApi.Services.Interfaces;

namespace OnboardingApi.Services;

public class OnboardingService : IOnboardingService
{
    private readonly IOnboardingRepository _repository;
    private readonly IMapper _mapper;

    public OnboardingService(
        IOnboardingRepository repository,
        IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<IEnumerable<OnboardingResponseDto>> GetAllAsync()
    {
        var onboardings = await _repository.GetAllAsync();
        return _mapper.Map<IEnumerable<OnboardingResponseDto>>(onboardings);
    }

    public async Task<OnboardingResponseDto?> GetByIdAsync(int id)
    {
        var onboarding = await _repository.GetByIdAsync(id);

        if (onboarding == null)
            return null;

        return _mapper.Map<OnboardingResponseDto>(onboarding);
    }

    public async Task<OnboardingResponseDto> CreateAsync(CreateOnboardingDto dto)
    {
        var onboarding = _mapper.Map<Onboarding>(dto);

        var createdOnboarding = await _repository.CreateAsync(onboarding);

        return _mapper.Map<OnboardingResponseDto>(createdOnboarding);
    }

    public async Task<bool> UpdateAsync(int id, UpdateOnboardingDto dto)
    {
        var onboarding = await _repository.GetByIdAsync(id);

        if (onboarding == null)
            return false;

        _mapper.Map(dto, onboarding);

        await _repository.UpdateAsync(onboarding);

        return true;
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var onboarding = await _repository.GetByIdAsync(id);

        if (onboarding == null)
            return false;

        await _repository.DeleteAsync(onboarding);

        return true;
    }
}