using Microsoft.AspNetCore.Mvc;

namespace ELearning_API.Models.Base
{
    public class PaginatedRequest
    {
        public const int ITEMS_PER_PAGE = 10;

        [FromQuery(Name = "page")]
        public int PageNumber { get; set; } = 1;

        [FromQuery(Name = "search")]
        public string? SearchKeyword { get; set; }
    }
}
