using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Despesa> Despesas { get; set; }
        public DbSet<Lucro> Lucros { get; set; }
        public DbSet<TipoDespesa> TiposDespesa { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Password=admin;Persist Security Info=True;User ID=admin;Initial Catalog=SistemaFinanceiro;Data Source=DESKTOP-2DOFC66\\SQLEXPRESS");
        }
    }
}
