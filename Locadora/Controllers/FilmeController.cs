using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ApiLocadora.Dtos;
using ApiLocadora.Models;
using ApiLocadora.DbContext;
using System.Collections.Generic;

namespace ApiLocadora.Controllers
{
    [Route("filmes")]
    [ApiController]
    public class FilmeController : ControllerBase
    {
        [HttpGet]
        public IActionResult Buscar()
        {
            return Ok(Listar.Filmes);
        }

        [HttpPost]
        public IActionResult Cadastrar([FromBody] FilmeDto item)
        {
            var filme = new Filme();
            filme.Nome = item.Titulo;
            filme.Diretor = item.Diretor;
            filme.AnoLancamento = item.AnoLancamento;
            filme.Diretor = item.Diretor;
            filme.Genero = item.Genero;
            filme.Estudio = item.Estudio;
            filme.IMDB = item.IMDB;

            Listar.Filmes.Add(filme);

            return Ok(filme);
        }

        [HttpPut("{id}")]
        public IActionResult Atualizar(Guid id, [FromBody] FilmeDto item)
        {
            if(id != Guid.NewGuid())
            {
                return NotFound();
            }

            return Ok();
        }
        
        [HttpDelete("{id}")]
        public IActionResult Remover(Guid id)
        {
            return Ok();
        }
    }
}
