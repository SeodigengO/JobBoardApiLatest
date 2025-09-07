namespace JobBoard.Models;

 public class Company
{
  public Guid CompanyId { get; set; }
  public string CompanyName { get; set; }
  public string Location { get; set; }
  public ICollection<Job> Jobs { get; set; }
}