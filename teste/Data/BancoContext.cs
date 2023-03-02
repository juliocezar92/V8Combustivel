using Microsoft.EntityFrameworkCore;
using teste.Models;

namespace teste.Data
{
    public class BancoContext : DbContext

    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {
        }
        public DbSet<RelatorioModel> Relatorios { get; set; }
    }
}
