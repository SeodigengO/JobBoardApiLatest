using JobBoard.Models;

public interface IApplicantRepository
{
  Task<Applicant> AddApplicant(Applicant applicant);
}