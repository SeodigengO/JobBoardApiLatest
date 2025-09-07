namespace JobBoard.Models;

public class Job
{
  public Guid JobId { get; set; }
  public Guid CompanyId { get; set; }

  public string JobTitle { get; set; }
  public string JobType { get; set; }
  public string JobCategory { get; set; }
  public DateTime PostedDate { get; set; }
  public int? MinSalary { get; set; }
  public int? MaxSalary { get; set; }
  public string Description { get; set; }
  public Company Company { get; set; }
  public ICollection<Application> Applications { get; set; }
}