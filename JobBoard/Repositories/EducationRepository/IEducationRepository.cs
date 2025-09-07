
using JobBoard.Models;


public interface IEducationRepository
{
    Task<List<Education>> GetAllEducationAsync();
}
