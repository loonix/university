using _05_ASP.NET_core_Layouts_CSS_e_Bootstrap.Models;
using Microsoft.EntityFrameworkCore;

namespace _05_ASP.NET_core_Layouts_CSS_e_Bootstrap.Data
{
    public class DbConteudoContext : DbContext
    {
        public DbConteudoContext(DbContextOptions<DbConteudoContext> options) : base(options)
        {
        }
        public DbSet<Conteudo> Conteudo { get; set; }
      
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Conteudo>().ToTable("Conteudo");
        }
    }
}
