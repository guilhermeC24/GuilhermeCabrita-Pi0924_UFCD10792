namespace Projeto___Gestão_de_Ginásio.Models.Requests
{
    public class UpdateClienteRequest
    {
        public string? Nome { get; set; }

        public int Idade { get; set; }
        public string? Sexo { get; set; }

        public int GinasioId { get; set; }
    }
}
