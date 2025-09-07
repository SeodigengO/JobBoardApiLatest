public class ApplicationResponseDto
{
    public Guid ApplicationId { get; set; }
    public string Status { get; set; }
    public DateTime AppliedOn { get; set; }

    public JobDto Job { get; set; }
    public ApplicantDto Applicant { get; set; }
}