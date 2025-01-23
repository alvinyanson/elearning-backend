using ELearning_API.Data.Repositories.Interfaces;
using ELearning_API.DTOs.Course;
using ELearning_API.Models;
using ELearning_API.Models.Base;
using Mapster;
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
                (!request.IsPublished.HasValue || course.IsPublished == request.IsPublished)
                );

            result.SearchKeyword = request.SearchKeyword;

            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateCourseDTO request)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            bool isExisting = await _unitOfWork.Course.GetByName(request.Title) != null;

            if(isExisting)
                return BadRequest("Course title must be unique.");

            Course course = request.Adapt<Course>();

            bool successAdd = await _unitOfWork.Course.Add(course);

            if(!successAdd)
                return BadRequest();

            bool successSave = await _unitOfWork.CompleteAsync();

            if(!successSave)
                return BadRequest();

            GetCourseDTO courseDTO = course.Adapt<GetCourseDTO>();

            return CreatedAtAction(nameof(GetCourse), new { id = courseDTO.Id }, courseDTO);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateCourseDTO request)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            Course course = request.Adapt<Course>();

            bool successUpdate = await _unitOfWork.Course.Update(course);

            if (!successUpdate)
                return BadRequest();

            bool successSave = await _unitOfWork.CompleteAsync();

            if (!successSave)
                return BadRequest();

            return NoContent();
        }

        [HttpDelete]
        [Route("{id:Guid}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            Course? course = await _unitOfWork.Course.GetById(id);

            if(course == null)
                return NotFound();

            bool successDelete = await _unitOfWork.Course.Delete(id);

            if (!successDelete)
                return BadRequest();

            bool successSave = await _unitOfWork.CompleteAsync();

            if (!successSave)
                return BadRequest();

            return NoContent();
        }

        [HttpGet]
        [Route("{id:Guid}")]
        public async Task<IActionResult> GetCourse(Guid id)
        {
            Course? course = await _unitOfWork.Course.GetById(id);

            if (course == null)
                return NotFound();

            GetCourseDTO courseDTO = course.Adapt<GetCourseDTO>();

            return Ok(courseDTO);
        }
    }
}
