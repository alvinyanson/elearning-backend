using Azure.Core;
using ELearning_API.Data.Repositories.Interfaces;
using ELearning_API.DTOs.Course;
using ELearning_API.DTOs.Module;
using ELearning_API.Filters;
using ELearning_API.Models;
using ELearning_API.Models.Base;
using Mapster;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ELearning_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ServiceFilter(typeof(CustomExceptionFilter))]
    public class ModulesController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public ModulesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        [HttpGet]
        public async Task<IActionResult> Get(PaginatedRequest request)
        {
            PaginatedResult<GetModuleDTO> result = _unitOfWork.Module.GetPaginated(
            request.PageNumber,
            PaginatedRequest.ITEMS_PER_PAGE,
            course => course.Title.Contains(request.SearchKeyword ?? string.Empty) &&
            (!request.IsPublished.HasValue || course.IsPublished == request.IsPublished)
                );

            result.SearchKeyword = request.SearchKeyword;

            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateModuleDTO request)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            
            bool isExisting = await _unitOfWork.Module.GetByName(request.Title) != null;

            if(isExisting)
                return BadRequest("Module title must be unique.");

            Module module = request.Adapt<Module>();

            bool successAdd = await _unitOfWork.Module.Add(module);

            if (!successAdd)
                return BadRequest();

            bool successSave = await _unitOfWork.CompleteAsync();

            if(!successAdd)
                return BadRequest();

            GetModuleDTO moduleDTO = module.Adapt<GetModuleDTO>();

            return CreatedAtAction(nameof(GetModule), new { id = moduleDTO.Id }, moduleDTO);
        }

        [HttpGet]
        [Route("{id:Guid}")]
        public async Task<IActionResult> GetModule(Guid id)
        {
            Module? module = await _unitOfWork.Module.GetById(id);

            if (module == null)
                return NotFound();

            GetModuleDTO moduleDTO = module.Adapt<GetModuleDTO>();

            return Ok(moduleDTO);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateModuleDTO request)
        {
            if (!ModelState.IsValid)
                return BadRequest();


            Module module = request.Adapt<Module>();

            bool successUpdate = await _unitOfWork.Module.Update(module);

            if(!successUpdate)
                return BadRequest();

            bool successSave = await _unitOfWork.CompleteAsync(); 

            if(!successSave)
                return BadRequest();

            return NoContent();

        }



        [HttpDelete]
        [Route("{id:Guid}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            Module? module = await _unitOfWork.Module.GetById(id);

            if (module == null)
                return NotFound();

            bool successDelete = await _unitOfWork.Module.Delete(id);

            if (!successDelete)
                return BadRequest();

            bool successSave = await _unitOfWork.CompleteAsync();

            if (!successSave)
                return BadRequest();

            return NoContent();
        }

    }
}
