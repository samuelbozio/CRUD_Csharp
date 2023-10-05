using BasicCrud.Models;
using Microsoft.EntityFrameworkCore;

namespace BasicCrud.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :base (options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("ConnectionStrings");
            }
        }

        public DbSet<UsuarioModel> UsuarioModel { get; set; }  



    }
}
