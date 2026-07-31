using ApiDarioProjetoFinal.Data;
using ApiDarioProjetoFinal.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ApiDarioProjetoFinal.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class FilmesController : ControllerBase
    {
        [HttpGet]
        public IActionResult ObterTodos()
        {
            return Ok(ArmazenamentoDados.Filmes);
        }

        [HttpGet("{id}")]
        public IActionResult ObterPorId(int id)
        {
            var filme = ArmazenamentoDados.Filmes.FirstOrDefault(f => f.Id == id);

            if (filme == null)
                return NotFound();

            return Ok(filme);
        }

        [HttpPost]
        public IActionResult Criar(Filme filme)
        {
            ArmazenamentoDados.Filmes.Add(filme);

            return CreatedAtAction(nameof(ObterPorId), new { id = filme.Id }, filme);
        }

        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, Filme filmeAtualizado)
        {
            var filme = ArmazenamentoDados.Filmes.FirstOrDefault(f => f.Id == id);

            if (filme == null)
                return NotFound();

            filme.Titulo = filmeAtualizado.Titulo;
            filme.Genero = filmeAtualizado.Genero;
            filme.Duracao = filmeAtualizado.Duracao;
            filme.ClassificacaoEtaria = filmeAtualizado.ClassificacaoEtaria;
            filme.PrecoBilhete = filmeAtualizado.PrecoBilhete;

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Eliminar(int id)
        {
            var filme = ArmazenamentoDados.Filmes.FirstOrDefault(f => f.Id == id);

            if (filme == null)
                return NotFound();

            ArmazenamentoDados.Filmes.Remove(filme);

            return NoContent();
        }
    }
}