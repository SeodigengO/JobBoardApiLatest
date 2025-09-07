using JobBoard.Models;

public class PostApplicantDto
{
public string Name { get; set; }
  public string Surname { get; set; }
  public DateTime DateOfBirth { get; set; }
  public string Email { get; set; }
  public string PhoneNumber { get; set; }
  public string Gender { get; set; }
  public string StreetAddress { get; set; }
  public string City { get; set; }
  public string Province { get; set; }
  public string Country { get; set; }
  public string PostalCode { get; set; }
  public string CurrentPosition { get; set; }
  public List<PostEducationDto> EducationHistory { get; set; }
  public List<PostWorkExperienceDto> WorkExperiences { get; set; }
}
