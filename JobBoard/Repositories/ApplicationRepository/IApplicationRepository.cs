using JobBoard.Models;

public interface IApplicationRepository
{
    Task<List<Application>> GetAllApplicationsAsync();
   
}