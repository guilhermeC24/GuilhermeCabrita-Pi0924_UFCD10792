namespace Projeto___Gestão_de_Ginásio.Models.Requests
{
    public class CreateClienteRequest
    {
        public string? Nome { get; set; }

        public int Idade { get; set; }
        public char Sexo { get; set; }

        public int GinasioId { get; set; }
    }
}
