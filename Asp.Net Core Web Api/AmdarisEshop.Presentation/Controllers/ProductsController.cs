using AmdarisEshop.Application;
using AmdarisEshop.Application.Commands;
using AmdarisEshop.Application.Queries;
using AmdarisEshop.Presentation.Dto;
using AmdarisEshop.Presentation.Services;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace AmdarisEshop.Presentation.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;
        private readonly ISingletonService _singletonService;
        private readonly IScopedService _scopedService;
        private readonly ITransientService _transientService;

        private readonly MySettingsSection _settings;

        public ProductsController(IMediator mediator, IMapper mapper,
            IOptions<MySettingsSection> options, ISingletonService singletonService, 
            IScopedService scopedService, ITransientService transientService)
        {
            _mediator = mediator;
            _mapper = mapper;

            _singletonService = singletonService;
            _scopedService = scopedService;
            _transientService = transientService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct([FromBody] ProductPutPostDto product)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var command = _mapper.Map<CreateProduct>(product);

            var created = await _mediator.Send(command);
            var dto = _mapper.Map<ProductGetDto>(created);

            return CreatedAtAction(nameof(GetById), new { productId = created.ProductId}, dto);
        }

        [HttpGet]
        public async Task<IActionResult> Getall()
        {
            var query = new GetAllProducts();
            var result = await _mediator.Send(query);
            var mappedResult = _mapper.Map<List<ProductGetDto>>(result);
            return Ok(mappedResult);
        }

        [HttpGet]
        [Route("{productId}")]
        public async Task<IActionResult> GetById(int productId)
        {
            var query = new GetProductById { ProductId = productId };
            var result = await _mediator.Send(query);

            if (result == null)
                return NotFound();

            var mappedResult = _mapper.Map<ProductGetDto>(result);
            return Ok(mappedResult);
        }

        [HttpPut]
        [Route("{productId}")]
        public IActionResult UpdateProduct(int productId, [FromBody] ProductPutPostDto updated)
        {
            var command = new UpdateProduct
            {
                ProductId = productId,
                Name = updated.Name,
                Description = updated.Description,
                Quantity = updated.Quantity,
                Price = updated.Price
            };
            var result = _mediator.Send(command);

            if (result == null)
                return NotFound();

            return NoContent();
        }

        [Route("{productId}")]
        [HttpDelete]
        public async Task<IActionResult> DeleteProduct(int productId)
        {
            var command = new DeleteProduct { ProductId = productId };
            var result = await _mediator.Send(command);

            if (result == null)
                return NotFound();

            return NoContent();
        }

        [HttpPost]
        [Route("{productId}/categories/{categoryId}")]
        public async Task<IActionResult> AddCategoryToProduct(int productId, int categoryId)
        {
            var command = new AddCategoryToProduct
            {
                CategoryId = categoryId,
                ProductId = productId
            };

            var product = await _mediator.Send(command);

            if (product == null)
                return NotFound();

            return Ok(_mapper.Map<ProductGetDto>(product));
        }

        [HttpDelete]
        [Route("{productId}/categories/{categoryId}")]
        public async Task<IActionResult> RemoveCategoryFromProduct(int productId, int categoryId)
        {
            var command = new RemoveCategoryFromProduct { ProductId = productId, CategoryId = categoryId };
            var product = await _mediator.Send(command);

            if (product == null)
                return NotFound();

            return Ok(_mapper.Map<ProductGetDto>(product));

        }

    }
}
