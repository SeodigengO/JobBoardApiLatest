using JobBoard.Models;

public interface IWorkExperienceRepository
{
    Task<List<WorkExperience>> GetAllWorkExperiencesAsync();
}