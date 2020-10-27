using Gym.Entities;
using Gym.Persistence;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Gym.Controllers
{
    [ApiController]
    [Route("api/Unidades")]
    public class UnidadesController : ControllerBase
    {
        private readonly GymDbContext _gymDbContext;

        public UnidadesController(GymDbContext gymDbContext)
        {
            _gymDbContext = gymDbContext;
        }

        //api/Unidades
        [HttpGet]
        public IActionResult Get()
        {
            var unidades = _gymDbContext.Unidades.ToList();
            return Ok(unidades);
        }

        //api/Unidades/1
        [HttpGet("{id}")]
        public IActionResult GetId(int id)
        {
            var unidade = _gymDbContext.Unidades.SingleOrDefault(a => a.Id == id);
            if (unidade == null)
                return NotFound();

            return Ok(unidade);
        }

        //api/Unidades
        [HttpPost]
        public IActionResult Post([FromBody] Unidade unidade)
        {
            _gymDbContext.Unidades.Add(unidade);
            _gymDbContext.SaveChanges();
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