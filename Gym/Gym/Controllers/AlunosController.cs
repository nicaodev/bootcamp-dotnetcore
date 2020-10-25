﻿using Gym.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Gym.Controllers
{
    [Route("api/alunos")]
    [ApiController]
    public class AlunosController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var alunos = new List<Aluno>
            {
                new Aluno("Nicolas", "Rua 3", DateTime.Now),
                new Aluno("Nicolas Alexandre", "Rua 3", DateTime.Now),
                new Aluno("Nicolas Pereira", "Rua 3", DateTime.Now)
            };

            return Ok(alunos);
        }

        //api/alunos/4
        [HttpGet("{id}")]
        public IActionResult GetId(int id)
        {
            return Ok();
        }

        //api/alunos
        [HttpPost]
        public IActionResult Post()
        {
            return Ok();
        }

        //api/alunos/4
        [HttpPut("{id}")]
        public IActionResult Put(int id)
        {
            return Ok();
        }

        //api/alunos/4
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok();
        }
    }
}