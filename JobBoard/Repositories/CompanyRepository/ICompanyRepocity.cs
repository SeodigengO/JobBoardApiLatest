using JobBoard.Models;

public interface ICompanyRepository
{
  Task<List<Company>> GetAllCompanies();

}