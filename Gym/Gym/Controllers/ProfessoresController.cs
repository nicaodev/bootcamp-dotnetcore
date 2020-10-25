using Microsoft.AspNetCore.Mvc;

namespace Gym.Controllers
{
    [ApiController]
    [Route("api/professores")]
    public class ProfessoresController : ControllerBase
    {
        //api/professores
        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }

        //api/professores/2
        [HttpGet("{id}")]
        public IActionResult GetId(int id)
        {
            return Ok();
        }

        //api/professores
        [HttpPost]
        public IActionResult Post()
        {
            return Ok();
        }

        //api/professores/2
        [HttpPut]
        public IActionResult Put()
        {
            return Ok();
        }

        //api/professores/2
        [HttpDelete]
        public IActionResult Delete()
        {
            return Ok();
        }
    }
}