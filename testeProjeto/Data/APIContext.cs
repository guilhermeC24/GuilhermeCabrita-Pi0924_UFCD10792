using Microsoft.EntityFrameworkCore;
using Projeto___Gestão_de_Ginásio.Models.Requests;

namespace Projeto___Gestão_de_Ginásio.Verdades
{
    public class APIContext : DbContext
    {
        public DbSet<CreateClienteRequest> Clientes { get; set; }
        public APIContext(DbContextOptions<APIContext> option) : base(option)
        {
        
        }
    }
}
