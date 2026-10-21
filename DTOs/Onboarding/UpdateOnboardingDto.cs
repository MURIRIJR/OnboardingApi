namespace OnboardingApi.DTOs.Onboarding;

public class UpdateOnboardingDto
{
    public string Status { get; set; } = string.Empty;

    public int CurrentStep { get; set; }
}