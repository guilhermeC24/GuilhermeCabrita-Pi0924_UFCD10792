using ApiDarioProjetoFinal.Data;
using ApiDarioProjetoFinal.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApiDarioProjetoFinal.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UtilizadoresController : ControllerBase
    {
        [HttpGet]
        public IActionResult ObterTodos()
        {
            return Ok(ArmazenamentoDados.Utilizadores);
        }

        [HttpGet("{id}")]
        public IActionResult ObterPorId(int id)
        {
            var utilizador = ArmazenamentoDados.Utilizadores.FirstOrDefault(u => u.Id == id);

            if (utilizador == null)
                return NotFound();

            return Ok(utilizador);
        }

        [HttpPost]
        public IActionResult Criar(Utilizador utilizador)
        {
            ArmazenamentoDados.Utilizadores.Add(utilizador);

            return CreatedAtAction(nameof(ObterPorId), new { id = utilizador.Id }, utilizador);
        }

        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, Utilizador utilizadorAtualizado)
        {
            var utilizador = ArmazenamentoDados.Utilizadores.FirstOrDefault(u => u.Id == id);

            if (utilizador == null)
                return NotFound();

            utilizador.Nome = utilizadorAtualizado.Nome;
            utilizador.Email = utilizadorAtualizado.Email;
            utilizador.Password = utilizadorAtualizado.Password;
            utilizador.Perfil = utilizadorAtualizado.Perfil;

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Eliminar(int id)
        {
            var utilizador = ArmazenamentoDados.Utilizadores.FirstOrDefault(u => u.Id == id);

            if (utilizador == null)
                return NotFound();

            ArmazenamentoDados.Utilizadores.Remove(utilizador);

            return NoContent();
        }
    }
}