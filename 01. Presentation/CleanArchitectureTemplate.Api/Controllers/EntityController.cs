using AutoMapper;
using CleanArchitectureTemplate.Application.Features;
using CleanArchitectureTemplate.Application.Persitence;
using CleanArchitectureTemplate.Application.ViewModels;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitectureTemplate.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EntityController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public EntityController(IMediator mediator,
            IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllEntity([FromRoute] Guid id)
        {
            var entity = await _mediator.Send(new GetEntityQuery(id));
            var viewModel = entity
                .Select(x => _mapper.Map<EntityViewModels>(x))
                .ToList();

            return Ok(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> PostEntity([FromBody] EntityViewModels viewModels)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var commandModel = _mapper.Map<PostEntityCommand>(viewModels);
            var result = await _mediator.Send(commandModel);
            return Ok(result);
        }

    }
}
