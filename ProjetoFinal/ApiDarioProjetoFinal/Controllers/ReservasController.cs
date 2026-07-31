using ApiDarioProjetoFinal.Data;
using ApiDarioProjetoFinal.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ApiDarioProjetoFinal.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class ReservasController : ControllerBase
    {
        [HttpGet]
        public IActionResult ObterTodas()
        {
            return Ok(ArmazenamentoDados.Reservas);
        }

        [HttpGet("{id}")]
        public IActionResult ObterPorId(int id)
        {
            var reserva = ArmazenamentoDados.Reservas
                .FirstOrDefault(r => r.Id == id);

            if (reserva == null)
                return NotFound();

            return Ok(reserva);
        }

        [HttpPost]
        public IActionResult Criar(Reserva reserva)
        {
            ArmazenamentoDados.Reservas.Add(reserva);

            return CreatedAtAction(
                nameof(ObterPorId),
                new { id = reserva.Id },
                reserva
            );
        }

        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, Reserva reservaAtualizada)
        {
            var reserva = ArmazenamentoDados.Reservas
                .FirstOrDefault(r => r.Id == id);

            if (reserva == null)
                return NotFound();

            reserva.IdFilme = reservaAtualizada.IdFilme;
            reserva.IdUtilizador = reservaAtualizada.IdUtilizador;
            reserva.QuantidadeBilhetes = reservaAtualizada.QuantidadeBilhetes;
            reserva.EstadoPagamento = reservaAtualizada.EstadoPagamento;

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Eliminar(int id)
        {
            var reserva = ArmazenamentoDados.Reservas
                .FirstOrDefault(r => r.Id == id);

            if (reserva == null)
                return NotFound();

            ArmazenamentoDados.Reservas.Remove(reserva);

            return NoContent();
        }
    }
}