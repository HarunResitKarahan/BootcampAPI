using Microsoft.EntityFrameworkCore;

namespace BootcampAPI.Models
{
    public class DBFullStackContext : DbContext
    {
        public DBFullStackContext() { }
        //public DBFullStackContext(DbContextOptions<DBFullStackContext> options) : base(options) { }

        public DbSet<Category> Categorys { get; set; }
        public DbSet<SubCategory> SubCategorys { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<FeaturedProduct> FeaturedProducts { get; set; }
        public DbSet<AdminUser> AdminUsers { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer("Server=DESKTOP-IBJHKAI;Database=EpeyClone;User Id=epeyadmin;Password=123;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
