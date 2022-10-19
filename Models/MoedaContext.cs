using Microsoft.EntityFrameworkCore;

namespace PesquisaCrypto.Models
{
    public class MoedaContext : DbContext
    {
        public DbSet<Moeda> Moedas { get; set; }
        public MoedaContext(DbContextOptions<MoedaContext> options) : base(options)
        { }
    }
}
