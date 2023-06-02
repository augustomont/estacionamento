using Microsoft.EntityFrameworkCore;

namespace estacionamento.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options) { }
        public DbSet<EstoqueModel> Estoque { get; set; }
    }
}
