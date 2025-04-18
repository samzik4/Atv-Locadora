using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ApiLocadora.Dtos;
using ApiLocadora.Models;
using ApiLocadora.DbContext;

namespace ApiLocadora.Controllers
{
    [Route("genero")]
    [ApiController]
    public class GeneroController : ControllerBase
    {
       
        [HttpGet]
        public IActionResult Buscar()
        {
            return Ok(Listar.Generos);
        }

        [HttpPost]
        public IActionResult Cadastrar([FromBody] GeneroDto item)
        {
            var Genero = new Genero();
            Genero.Nome = item.Nome;

            Listar.Generos.Add(Genero);

            return Ok(Genero);
        }

        [HttpPut("{id}")]
        public IActionResult Atualizar(Guid id, [FromBody] GeneroDto item)
        {
            if (id != Guid.NewGuid())
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
