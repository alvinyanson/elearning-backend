using ELearning_API.Data.Repositories.Interfaces;
using ELearning_API.DTOs.Subject;
using ELearning_API.Models;
using ELearning_API.Models.Base;
using Mapster;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace ELearning_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public class SubjectsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public SubjectsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        //[HttpGet]
        //public async Task<IActionResult> Get()
        //{
        //    List<Subject> subjects = await _unitOfWork.Subject.All();

        //    List<GetSubjectDTO> subjectsDTO = subjects.Adapt<List<GetSubjectDTO>>();

        //    return Ok(subjectsDTO);
        //}

        [HttpGet]
        public IActionResult Get(PaginatedRequest request)
        {
            PaginatedResult<GetSubjectDTO> result = _unitOfWork.Subject.GetPaginated(
               request.PageNumber,
               PaginatedRequest.ITEMS_PER_PAGE,
               subjects => subjects.Name.Contains(request.SearchKeyword ?? string.Empty)
               );

            result.SearchKeyword = request.SearchKeyword;

            return Ok(result);
        }

        [HttpGet]
        [Route("{id:Guid}")]
        public async Task<IActionResult> GetSubject(Guid id)
        {
            Subject? subject = await _unitOfWork.Subject.GetById(id);

            if (subject == null)
                return NotFound();

            GetSubjectDTO subjectDTO = subject.Adapt<GetSubjectDTO>();

            return Ok(subjectDTO);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateSubjectDTO request)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            Subject subject = request.Adapt<Subject>();

            await _unitOfWork.Subject.Add(subject);

            await _unitOfWork.CompleteAsync();

            GetSubjectDTO subjectDTO = subject.Adapt<GetSubjectDTO>();

            return CreatedAtAction(nameof(GetSubject), new { id = subjectDTO.Id }, subjectDTO);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateSubjectDTO request)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            Subject subject = request.Adapt<Subject>();

            await _unitOfWork.Subject.Update(subject);

            await _unitOfWork.CompleteAsync();

            return NoContent();
        }

        [HttpDelete("{id:Guid}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            Subject? subject = await _unitOfWork.Subject.GetById(id);

            if (subject == null)
                return NotFound();

            await _unitOfWork.Subject.Delete(id);

            await _unitOfWork.CompleteAsync();

            return NoContent();
        }
    }
}
