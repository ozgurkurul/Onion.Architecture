namespace ProductApp.Application.Wrappers
{
    public class PagedResponse<T> : ServiceResponse<T>
    {
        public int PageNumber { get; set; }//current page
        public int PageSize { get; set; }//max page size limit
        public int TotalCount { get; set; }//total data count
        public int TotalPages { get; set; }//total page number
        public PagedResponse()
        {
            PageNumber = 1;
            PageSize = 10;
        }
        public PagedResponse(T value, int pageNumber, int pageSize, int totalCount) : base(value)
        {
            PageNumber = pageNumber < 1 ? 1 : pageNumber;
            PageSize = pageSize < 10 ? 10 : pageSize;
            TotalCount = totalCount;
            TotalPages = Convert.ToInt32(Math.Ceiling((double)totalCount / (double)pageSize));
        }
    }
}
