using Microsoft.AspNetCore.Mvc;
using Projeto___Gestão_de_Ginásio.Models.Requests;
using Projeto___Gestão_de_Ginásio.Models.Responses;

namespace Projeto___Gestão_de_Ginásio.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GinasiosController : ControllerBase
    {
        private static List<GinasioResponse> ginasios = new()
        {
            new GinasioResponse
            {
                ID = 1,
                Nome = "FitnessTime Saldanha",
                Cidade = "Lisboa",
            },
            new GinasioResponse
            {
                ID = 2,
                Nome = "FitnessTime Feijó",
                Cidade = "Almada",
            },
            new GinasioResponse
            {
                ID = 3,
                Nome = "FitnessTime Ribeira",
                Cidade = "Porto",
            },
            new GinasioResponse
            {
                ID = 4,
                Nome = "FitnessTime Universidade",
                Cidade = "Leiria",
            },
            new GinasioResponse
            {
                ID = 5,
                Nome = "FitnessTime Alvalade",
                Cidade = "Lisboa",
            },
            new GinasioResponse
            {
                ID = 6,
                Nome = "FitnessTime Fernão Ferro",
                Cidade = "Seixal",
            }
        };
    }
}
