using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace ReadData
{

    public class AppVentaCursosContext : DbContext
    {
        private const string connectionString = @"Data Source=127.0.0.1,1433;Initial Catalog=MyTest;User ID=sa;Password=MyPassword123__;TrustServerCertificate=True";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(connectionString);

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Curso>(entity =>
            {
                // Set the table name to "Curso"
                entity.ToTable("Curso");

                // Define the primary key for the table as the "CursoId" property
                entity.HasKey(c => c.CursoId);
            });
        }

        public DbSet<Cursos> Cursos { get; set; }
        public DbSet<Precio> Precio { get; set; }

    }

}