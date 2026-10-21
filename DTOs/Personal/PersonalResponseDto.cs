namespace OnboardingApi.DTOs.Personal;

public class PersonalResponseDto
{
    public int Id { get; set; }

    public string Title { get; set; } = string.Empty;

    public string FirstName { get; set; } = string.Empty;

    public string MiddleName { get; set; } = string.Empty;

    public string LastName { get; set; } = string.Empty;

    public DateTime DateOfBirth { get; set; }

    public string Gender { get; set; } = string.Empty;

    public string MaritalStatus { get; set; } = string.Empty;

    public string Nationality { get; set; } = string.Empty;

    public string EmploymentStatus { get; set; } = string.Empty;

    public string IdType { get; set; } = string.Empty;

    public string IdNumber { get; set; } = string.Empty;

    public DateTime? IdExpiryDate { get; set; }

    public string Email { get; set; } = string.Empty;

    public string MobileNumber { get; set; } = string.Empty;

    public string Occupation { get; set; } = string.Empty;
}