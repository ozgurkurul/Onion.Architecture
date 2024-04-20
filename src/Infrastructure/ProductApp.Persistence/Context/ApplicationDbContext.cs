using Microsoft.EntityFrameworkCore;
using ProductApp.Domain.Entities;

namespace ProductApp.Persistence.Context
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> dbContextOptions) : base(dbContextOptions)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .HasData(
                    new Product() { Id = Guid.NewGuid(), CreateDate = DateTime.Now, Name = "Book", Price = 15, Quantity = 10 },
                    new Product() { Id = Guid.NewGuid(), CreateDate = DateTime.Now, Name = "Notebook", Price = 20, Quantity = 1000 },
                    new Product() { Id = Guid.NewGuid(), CreateDate = DateTime.Now, Name = "Pencil", Price = 3, Quantity = 100 },
                    new Product() { Id = Guid.NewGuid(), CreateDate = DateTime.Now, Name = "Paper", Price = 50, Quantity = 350 }
                );
            base.OnModelCreating(modelBuilder);
        }
    }
}
