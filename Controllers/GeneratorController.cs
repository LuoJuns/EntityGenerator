using Microsoft.AspNetCore.Mvc;
using SqlSugar;

namespace EntityGenerator.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GeneratorController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<GeneratorController> _logger;
        private readonly SqlSugarClient _sqlSugarClient;

        public GeneratorController(ILogger<GeneratorController> logger, SqlSugarClient sqlSugarClient)
        {
            _logger = logger;
            _sqlSugarClient = sqlSugarClient;
        }

        [HttpGet("StartGenerator")]
        public IActionResult StartGenerator()
        {
            MainClass o = new MainClass();
            o.GeneratorDBModel();
            return Ok("Success!");
        }
    }
}
