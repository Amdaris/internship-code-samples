using AmdarisEshop.Application;
using AmdarisEshop.Application.Commands;
using AmdarisEshop.Application.Queries;
using AmdarisEshop.Presentation.Dto;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace AmdarisEshop.Presentation.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        public readonly IMapper _mapper;
        public readonly IMediator _mediator;

        private readonly MySettingsSection _settings;

        public CategoriesController(IMapper mapper, IMediator mediator,
            IOptions<MySettingsSection> options)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> CreateCategory([FromBody] CategoryPutPostDto category)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var command = new CreateCategory
            {
                CategoryDescription = category.CategoryDescription,
                CategoryName = category.CategoryName,   
            };

            var result = await _mediator.Send(command);
            var mappedResult = _mapper.Map<CategoryGetDto>(result);

            return CreatedAtAction(nameof(GetById), new { id = mappedResult.CategoryId}, mappedResult);
        }

        [HttpGet]
        public async Task<IActionResult> GetCategories()
        {
            var result = await _mediator.Send(new GetAllCategories());
            var mappedResult = _mapper.Map<List<CategoryGetDto>>(result); 
            return Ok(mappedResult);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var query = new GetCategoryById { CategoryId = id };
            var result = await _mediator.Send(query);

            if (result == null)
                return NotFound();

            var mappedResult = _mapper.Map<CategoryGetDto>(result);
            return Ok(mappedResult);
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> UpdateCategory(int id, [FromBody] CategoryPutPostDto updatedCategory)
        {
            var command = new UpdateCategory
            {
                CatetgoryId = id,
                CategoryName = updatedCategory.CategoryName,
                CategoryDescription = updatedCategory.CategoryDescription
            };

            var result = await _mediator.Send(command);

            if (result == null)
                return NotFound();

            return NoContent();
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            var command = new DeleteCategory { CategoryId = id };
            var result = await _mediator.Send(command);

            if (result == null)
                return NotFound();

            return NoContent();
        }
    }
}
