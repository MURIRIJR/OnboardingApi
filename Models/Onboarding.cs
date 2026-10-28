namespace OnboardingApi.Models;

public class Onboarding
{
    public int Id { get; set; }

    public int PersonalId { get; set; }

    public string Status { get; set; } = "DRAFT";

    public int CurrentStep { get; set; }

    public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

    public DateTime UpdatedDate { get; set; } = DateTime.UtcNow;

    public DateTime? SubmittedDate { get; set; }

    public Personal? Personal { get; set; }
}