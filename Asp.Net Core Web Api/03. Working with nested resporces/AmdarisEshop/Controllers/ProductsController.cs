using AmdarisEshop.Application.Commands;
using AmdarisEshop.Application.Queries;
using AmdarisEshop.Dto;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AmdarisEshop.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;
        public ProductsController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
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

            await _mediator.Send(command);

            return NoContent();
        }

        [HttpDelete]
        [Route("{productId}/categories/{categoryId}")]
        public async Task<IActionResult> RemoveCategoryFromProduct(int productId, int categoryId)
        {
            var command = new RemoveCategoryFromProduct { ProductId = productId, CategoryId = categoryId };
            await _mediator.Send(command);

            return NoContent();
        }
    }
}
