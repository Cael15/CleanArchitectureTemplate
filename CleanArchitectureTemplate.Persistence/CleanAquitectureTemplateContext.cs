using CleanArchitectureTemplate.Domain.Entities;
using CleanArchitectureTemplate.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitectureTemplate.Persistence
{
    public class CleanAquitectureTemplateContext : DbContext
    {
        public CleanAquitectureTemplateContext(DbContextOptions<CleanAquitectureTemplateContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Entity>().ToTable("Entity");
        }
        public DbSet<Entity> Entities { get; set; }
    }
}
