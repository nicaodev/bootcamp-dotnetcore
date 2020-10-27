using Gym.Entities;
using Gym.Persistence;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Gym.Controllers
{
    [Route("api/alunos")]
    [ApiController]
    public class AlunosController : ControllerBase
    {
        private readonly GymDbContext _gymDbContext;
        public AlunosController(GymDbContext gymDbContext)
        {
            _gymDbContext = gymDbContext;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var alunos = _gymDbContext
               .Alunos
               .ToList();

            return Ok(alunos);
        }

        //api/alunos/4
        [HttpGet("{id}")]
        public IActionResult GetId(int id)
        {
            var aluno = _gymDbContext.Alunos.SingleOrDefault(a => a.Id == id);

            if (aluno == null)
                return NotFound();

            return Ok(aluno);
        }

        //api/alunos
        [HttpPost]
        public IActionResult Post([FromBody] Aluno aluno)
        {
            _gymDbContext.Alunos.Add(aluno);
            _gymDbContext.SaveChanges();

            return CreatedAtAction(nameof(GetId), aluno, new { id = aluno.Id });
        }

        //api/alunos/4
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Aluno aluno)
        {
            if (!_gymDbContext.Alunos.Any(x => x.Id == id))
                return NotFound();

            _gymDbContext.Alunos.Update(aluno);
            _gymDbContext.SaveChanges();

            return NoContent();
        }

        //api/alunos/4
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var aluno = _gymDbContext.Alunos.SingleOrDefault(x => x.Id == id);

            if (aluno == null)
                return NotFound();

            //_gymDbContext.Alunos.Remove(aluno);
            aluno.tornaInativo();
            _gymDbContext.SaveChanges();

            return NoContent();
        }
    }
}