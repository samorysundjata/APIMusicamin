using Microsoft.EntityFrameworkCore;

namespace APIMusicamin.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Musica> Musicas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options) 
            => options.UseSqlite("DataSource=app.db;Cache=Shared");
    }
}
