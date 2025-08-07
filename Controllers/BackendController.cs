using Microsoft.AspNetCore.Mvc;

namespace BrokenApiApp.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class BackendController : ControllerBase
    {
        private readonly string _conn = "Server=localhost;Database=Test;User Id=admin;Password=Password123!";

        private readonly ILogger<BackendController> _logger;

        public BackendController(ILogger<BackendController> logger)
        {
            _logger = logger;
        }
    }
}
