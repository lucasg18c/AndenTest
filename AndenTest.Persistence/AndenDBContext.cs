using AndenTest.Common.Entity;
using Microsoft.EntityFrameworkCore;

namespace AndenTest.Persistence
{
    public class AndenDBContext : DbContext
    {
        public AndenDBContext(DbContextOptions options) : base(options) { }

        public DbSet<FormA> FormsA { get; set; }
        public DbSet<FormB> FormsB { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Form>()
                .ToTable("Forms")
                .HasDiscriminator<string>("FormType")
                .HasValue<FormA>("A")
                .HasValue<FormB>("B");
        }
    }
}
