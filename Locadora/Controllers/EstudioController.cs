using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ApiLocadora.Dtos;
using ApiLocadora.Models;
using ApiLocadora.DbContext;

namespace ApiLocadora.Controllers
{
    [Route("Estudios")]
    [ApiController]
    public class EstudioController : ControllerBase
    {
        [HttpGet]
        public IActionResult Buscar()
        {
            return Ok(Listar.Estudios);
        }

        [HttpPost]
        public IActionResult Cadastrar([FromBody] EstudioDto item)
        {
            var Estudio = new Estudio();
            Estudio.Nome = item.Nome;
            Estudio.Distribuidor = item.Distribuidora;

            Listar.Estudios.Add(Estudio);

            return Ok(Estudio);
        }

        [HttpPut("{id}")]
        public IActionResult Atualizar(Guid id, [FromBody] EstudioDto item)
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
