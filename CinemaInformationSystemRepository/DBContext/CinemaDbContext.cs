using CinemaInformationSystemRepository.Entities;
using Microsoft.EntityFrameworkCore;

namespace CinemaInformationSystemRepository.DBContext
{
    public class CinemaDbContext: DbContext
    {
        public DbSet<Auditorium> Auditoriums { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Client> Clients { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer(@"Server=localhost;Database=master;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>()
                .HasOne(i => i.Movie)
                .WithMany(i => i.Clients)
                .IsRequired()
                .OnDelete(DeleteBehavior.ClientCascade);
        }
    }
}
