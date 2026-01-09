using Microsoft.AspNetCore.Mvc;
using SqlSugar;

namespace EntityGenerator.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GeneratorController(MainClass mainClass, ILogger<GeneratorController> logger) : ControllerBase
    {
        [HttpGet("StartGenerator")]
        public IActionResult StartGenerator()
        {
            mainClass.GeneratorDBModel();
            return Ok("Success!");
        }

        [HttpGet("[action]")]
        public IActionResult GeneratorFromTableName(string tableName)
        {
            mainClass.GeneratorDBModel(tableName);
            return Ok("Success!");
        }
    }
}
