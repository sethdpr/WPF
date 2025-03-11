using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using WPF.Models;

namespace WPF
{
    public class WPFContext : DbContext
    {
        public WPFContext(DbContextOptions<WPFContext> options) : base(options) { }

        public DbSet<Klant> Klanten { get; set; }
        public DbSet<Bestelling> Bestellingen { get; set; }
        public DbSet<Product> Producten { get; set; }
        public DbSet<BestellingProduct> BestellingProducten { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("Data Source=WPFApp.db");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<BestellingProduct>()
                .HasKey(bp => bp.BestellingProductId);

            modelBuilder.Entity<BestellingProduct>()
                .HasOne(bp => bp.Bestelling)
                .WithMany(b => b.BestellingProducten)
                .HasForeignKey(bp => bp.BestellingId);

            modelBuilder.Entity<BestellingProduct>()
                .HasOne(bp => bp.Product)
                .WithMany(p => p.BestellingProducten)
                .HasForeignKey(bp => bp.ProductId);
        }
    }

    public class WPFContextFactory : IDesignTimeDbContextFactory<WPFContext>
    {
        public WPFContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<WPFContext>();

            optionsBuilder.UseSqlite("Data Source=WPFApp.db");

            return new WPFContext(optionsBuilder.Options);
        }
    }
}