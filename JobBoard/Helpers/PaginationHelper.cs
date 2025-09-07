public static class PaginationHelper
    {
        public static IQueryable<T> Paginate<T>(this IQueryable<T> query, int pageNumber, int pageSize)
        {
            var skip = (pageNumber - 1) * pageSize;
            return query.Skip(skip).Take(pageSize);
        }
    }