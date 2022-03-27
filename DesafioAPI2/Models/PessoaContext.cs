using Microsoft.EntityFrameworkCore;

namespace DesafioAPI2.Models
{
    public class PessoaContext:DbContext
    {

        public PessoaContext(DbContextOptions<PessoaContext> options):base(options)
        {

        }

        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Cidade> Cidades { get; set; }
    }
}
