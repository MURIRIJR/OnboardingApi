using OnboardingApi.Models;

namespace OnboardingApi.Repositories.Interfaces;

public interface IAddressRepository
{
    Task<IEnumerable<Address>> GetAllAsync();

    Task<Address?> GetByIdAsync(int id);

    Task<Address> CreateAsync(Address address);

    Task UpdateAsync(Address address);

    Task DeleteAsync(Address address);
}