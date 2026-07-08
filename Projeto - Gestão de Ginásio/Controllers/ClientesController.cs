using Microsoft.AspNetCore.Mvc;
using Projeto___Gestão_de_Ginásio.Models.Requests;
using Projeto___Gestão_de_Ginásio.Models.Responses;
using Projeto___Gestão_de_Ginásio.Verdades;

namespace Projeto___Gestão_de_Ginásio.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClientesController : ControllerBase
    {
        private readonly APIContext _context;
        public ClientesController(APIContext context) 
        {
            _context = context;
        }

        [HttpPost("Criar_Editar")]
        public JsonResult Criar_Editar(CreateClienteRequest request)
        {
            if (request.ID == 0)
            {
                _context.Clientes.Add(request);
            }
            else
            {
                var DB = _context.Clientes.Find(request.ID);
                if (DB == null)
                {
                    return new JsonResult(NotFound());
                }
                DB = request;
            }
            _context.SaveChanges();

            return new JsonResult(Ok(request));
        }

        [HttpGet("Mostrar_DB")]
        public JsonResult GetAll()
        {
            var result = _context.Clientes.ToList();
            return new JsonResult(Ok(result));
        }
    }
}
