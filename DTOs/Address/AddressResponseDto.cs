namespace OnboardingApi.DTOs.Address;

public class AddressResponseDto
{
    public int Id { get; set; }

    public int PersonalId { get; set; }

    public string AddressType { get; set; } = string.Empty;

    public string Street { get; set; } = string.Empty;

    public string City { get; set; } = string.Empty;

    public string Region { get; set; } = string.Empty;

    public string PostalCode { get; set; } = string.Empty;

    public string Country { get; set; } = string.Empty;
}