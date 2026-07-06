namespace Projeto___Gestão_de_Ginásio.Models.Responses
{
    public class ClienteResponse
    {
        public int ID { get; set; }

        public string? Nome { get; set; }

        public int Idade { get; set; }
        public char Sexo { get; set; }

        public int GinasioId { get; set; }
    }
}
