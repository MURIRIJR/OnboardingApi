using AutoMapper;
using OnboardingApi.DTOs.Address;
using OnboardingApi.Models;
using OnboardingApi.Repositories.Interfaces;
using OnboardingApi.Services.Interfaces;

namespace OnboardingApi.Services;

public class AddressService : IAddressService
{
    private readonly IAddressRepository _repository;
    private readonly IMapper _mapper;

    public AddressService(
        IAddressRepository repository,
        IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<IEnumerable<AddressResponseDto>> GetAllAsync()
    {
        var addresses = await _repository.GetAllAsync();
        return _mapper.Map<IEnumerable<AddressResponseDto>>(addresses);
    }

    public async Task<AddressResponseDto?> GetByIdAsync(int id)
    {
        var address = await _repository.GetByIdAsync(id);

        if (address == null)
            return null;

        return _mapper.Map<AddressResponseDto>(address);
    }

    public async Task<AddressResponseDto> CreateAsync(CreateAddressDto dto)
    {
        var address = _mapper.Map<Address>(dto);

        var createdAddress = await _repository.CreateAsync(address);

        return _mapper.Map<AddressResponseDto>(createdAddress);
    }

    public async Task<bool> UpdateAsync(int id, UpdateAddressDto dto)
    {
        var address = await _repository.GetByIdAsync(id);

        if (address == null)
            return false;

        _mapper.Map(dto, address);

        await _repository.UpdateAsync(address);

        return true;
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var address = await _repository.GetByIdAsync(id);

        if (address == null)
            return false;

        await _repository.DeleteAsync(address);

        return true;
    }
}