using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Gym.Controllers
{
    [ApiController]
    [Route("api/Unidades")]
    public class UnidadesController : ControllerBase
    {
        //api/Unidades
        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }

        //api/Unidades/1
        [HttpGet("{id}")]
        public IActionResult GetId(int id)
        {
            return Ok();
        }

        //api/Unidades
        [HttpPost]
        public IActionResult Post()
        {
            return Ok();
        }

        //api/Unidades/1
        [HttpPut("{id}")]
        public IActionResult Put(int id)
        {
            return Ok();
        }

        //api/Unidades/1
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok();
        }
    }
}