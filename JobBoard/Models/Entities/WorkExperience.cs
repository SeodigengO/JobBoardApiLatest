namespace JobBoard.Models;

public class WorkExperience
{
  public Guid WorkExperienceId { get; set; }
  public Guid ApplicantId { get; set; }
  public Applicant Applicant { get; set; }
  public string Company { get; set; }
  public string Position { get; set; }
  public DateTime DateFrom { get; set; }
  public DateTime DateTo { get; set; }
}