namespace OnboardingApi.DTOs.Onboarding;

public class CreateOnboardingDto
{
    public int PersonalId { get; set; }

    public string Status { get; set; } = "DRAFT";

    public int CurrentStep { get; set; }
}