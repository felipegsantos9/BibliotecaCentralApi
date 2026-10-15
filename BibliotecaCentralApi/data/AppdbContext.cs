
using Microsoft.EntityFrameworkCore;
using BibliotecaCentralApi.models;

namespace BibliotecaCentralApi.data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Livro> Livros { get; set; }
    }
}
