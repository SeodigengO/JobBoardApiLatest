

using JobBoard.Models;

public static class SearchHelper
    {
        public static IQueryable<Job> ApplySearchFilter(this IQueryable<Job> query, string search)
        {
            return query.Where(x =>
                x.JobTitle.ToLower().Contains(search) ||
                x.JobCategory.ToLower().Contains(search) ||
                x.JobType.ToLower().Contains(search)      
            );
        }
    }