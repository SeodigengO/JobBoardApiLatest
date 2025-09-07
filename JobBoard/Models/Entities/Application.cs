namespace JobBoard.Models;

public class Application
{
  public Guid ApplicationId { get; set; }
  public Guid ApplicantId { get; set; }
  public Applicant Applicant { get; set; }
  public Guid JobId { get; set; }
  public Job Job { get; set; }
  public DateTime AppliedOn { get; set; } = DateTime.UtcNow;
  public string Status { get; set; } = "Pending";
}