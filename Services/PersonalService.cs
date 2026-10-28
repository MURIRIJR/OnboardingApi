using AutoMapper;
using OnboardingApi.DTOs.Personal;
using OnboardingApi.Models;
using OnboardingApi.Repositories.Interfaces;
using OnboardingApi.Services.Interfaces;

namespace OnboardingApi.Services;

public class PersonalService : IPersonalService
{
    private readonly IPersonalRepository _repository;
    private readonly IMapper _mapper;

    public PersonalService(
        IPersonalRepository repository,
        IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<IEnumerable<PersonalResponseDto>> GetAllAsync()
    {
        var personals = await _repository.GetAllAsync();
        return _mapper.Map<IEnumerable<PersonalResponseDto>>(personals);
    }

    public async Task<PersonalResponseDto?> GetByIdAsync(int id)
    {
        var personal = await _repository.GetByIdAsync(id);

        if (personal == null)
            return null;

        return _mapper.Map<PersonalResponseDto>(personal);
    }

    public async Task<PersonalResponseDto> CreateAsync(CreatePersonalDto dto)
    {
        var personal = _mapper.Map<Personal>(dto);

        personal.DateOfBirth = DateTime.SpecifyKind(
            personal.DateOfBirth,
            DateTimeKind.Utc);

        if (personal.IdExpiryDate.HasValue)
        {
            personal.IdExpiryDate = DateTime.SpecifyKind(
                personal.IdExpiryDate.Value,
                DateTimeKind.Utc);
        }

        var createdPersonal = await _repository.CreateAsync(personal);

        return _mapper.Map<PersonalResponseDto>(createdPersonal);
    }

    public async Task<bool> UpdateAsync(int id, UpdatePersonalDto dto)
    {
        var personal = await _repository.GetByIdAsync(id);

        if (personal == null)
            return false;

        _mapper.Map(dto, personal);

        personal.DateOfBirth = DateTime.SpecifyKind(
            personal.DateOfBirth,
            DateTimeKind.Utc);

        if (personal.IdExpiryDate.HasValue)
        {
            personal.IdExpiryDate = DateTime.SpecifyKind(
                personal.IdExpiryDate.Value,
                DateTimeKind.Utc);
        }

        await _repository.UpdateAsync(personal);

        return true;
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var personal = await _repository.GetByIdAsync(id);

        if (personal == null)
            return false;

        await _repository.DeleteAsync(personal);

        return true;
    }
}