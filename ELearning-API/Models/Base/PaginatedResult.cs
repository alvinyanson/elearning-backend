namespace ELearning_API.Models.Base
{
    public class PaginatedResult<T>
    {
        public int Page { get; set; }
        public int PageCount { get; set; }
        public string? SearchKeyword { get; set; }
        public IEnumerable<T>? Result { get; set; }
    }
}
