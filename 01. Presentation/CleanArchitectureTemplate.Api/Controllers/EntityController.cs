using Microsoft.AspNetCore.Mvc;

namespace CleanArchitectureTemplate.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EntityController : ControllerBase
    {
        public EntityController()
        {
            
        }

        [HttpGet]
        public async Task<IActionResult> GetAllEntity([FromRoute] string id)
        {
            throw new NotImplementedException();
        }
    }
}
