namespace JobBoard.Models.Dto;
public class JobDtoResponse
{
  public string JobTitle { get; set; }
  public string JobType { get; set; }
  public string JobCategory { get; set; }
  public DateTime PostedDate { get; set; }
  public int? MinSalary { get; set; }
  public int? MaxSalary { get; set; }
  public string Description { get; set; }
  public CompanyResponseDto CompanyResponseDto { get; set; }
}