namespace FourCreate.ClinicalTrials.Infrastructure.Entities;

public class CLinicalTrial
{
    public Guid Id { get; set; }

    public string TrialId { get; set; } = null!;

    public string Title { get; set; } = null!;

    public DateTime StartDate { get; set; }
    
    public DateTime EndDate { get; set; }

    public DateTime CreatedAt { get; set; }
}
