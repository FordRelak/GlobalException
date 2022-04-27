using GlobalExceptionHandler.Tests.Service;
using Microsoft.AspNetCore.Mvc;

namespace GlobalExceptionHandler.Tests.Web.Controllers
{
    [ApiController]
    [Route("/")]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        private readonly EntityService _entityService;

        public HomeController(EntityService entityService)
        {
            _entityService = entityService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return Ok(EntityService.GetCollection());
        }

        [HttpGet("notfound")]
        public IActionResult GetNotFound()
        {
            return Ok(EntityService.GetNotFoundException());
        }

        [HttpGet("bad")]
        public IActionResult GetBadRequest()
        {
            return Ok(EntityService.GetBadRequestException());
        }
    }
}