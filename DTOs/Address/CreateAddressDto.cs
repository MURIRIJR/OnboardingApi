namespace OnboardingApi.DTOs.Address;

public class CreateAddressDto
{
    public int PersonalId { get; set; }

    public string AddressLine1 { get; set; } = string.Empty;

    public string AddressLine2 { get; set; } = string.Empty;

    public string SuburbArea { get; set; } = string.Empty;

    public string CityTown { get; set; } = string.Empty;

    public string DistrictState { get; set; } = string.Empty;

    public string PostalCode { get; set; } = string.Empty;

    public string Country { get; set; } = string.Empty;

    public string ResidentialStatus { get; set; } = string.Empty;
}