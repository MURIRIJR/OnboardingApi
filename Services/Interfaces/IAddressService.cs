using OnboardingApi.DTOs.Address;

namespace OnboardingApi.Services.Interfaces;

public interface IAddressService
{
    Task<IEnumerable<AddressResponseDto>> GetAllAsync();

    Task<AddressResponseDto?> GetByIdAsync(int id);

    Task<AddressResponseDto> CreateAsync(CreateAddressDto dto);

    Task<bool> UpdateAsync(int id, UpdateAddressDto dto);

    Task<bool> DeleteAsync(int id);
}