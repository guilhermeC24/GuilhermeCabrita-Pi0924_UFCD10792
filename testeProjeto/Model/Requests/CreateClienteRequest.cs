using System.Text.Json.Serialization;

namespace Projeto___Gestão_de_Ginásio.Models.Requests
{
    public class CreateClienteRequest
    {
        public int ID { get; set; }
        public string? Nome { get; set; }

        public int Idade { get; set; }
        public string? Sexo { get; set; }

        public int GinasioId { get; set; }
    }
}
