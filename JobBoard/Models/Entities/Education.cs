namespace JobBoard.Models;

  public class Education
{
  public Guid EducationId { get; set; }
  public Guid ApplicantId { get; set; }
  public Applicant Applicant { get; set; }
  public string University { get; set; }
  public string Qualification { get; set; }
  public DateTime DateFrom { get; set; }
  public DateTime DateTo { get; set; }
}