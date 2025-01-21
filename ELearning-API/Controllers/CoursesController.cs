using ELearning_API.Data.Repositories.Interfaces;
using ELearning_API.DTOs.Course;
using ELearning_API.Models.Base;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ELearning_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public CoursesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        [HttpGet]
        public IActionResult Get(PaginatedRequest request)
        {
            PaginatedResult<GetCourseDTO> result = _unitOfWork.Course.GetPaginated(
                request.PageNumber,
                PaginatedRequest.ITEMS_PER_PAGE,
                course => course.Title.Contains(request.SearchKeyword ?? string.Empty) &&
                (!request.IsPublished.HasValue || course.IsPublised == request.IsPublished)
                );

            result.SearchKeyword = request.SearchKeyword;

            return Ok(result);
        }
    }
}
