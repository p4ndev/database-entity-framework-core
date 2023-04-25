using Microsoft.EntityFrameworkCore;
using DatabaseFirst.Models;

namespace DatabaseFirst.Provider;

public partial class PlainContext : DbContext {

    public PlainContext() { }

    public PlainContext(DbContextOptions<PlainContext> options) : base(options) { }

    public virtual DbSet<Brand>             Brands              { get; set; }
    public virtual DbSet<Product>           Products            { get; set; }
    public virtual DbSet<Variant>           Variants            { get; set; }
    public virtual DbSet<VCharacteristic>   VCharacteristics    { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder){

        modelBuilder.Entity<Brand>(entity => {

            entity.ToTable("Brand");
            entity.HasIndex(e => e.Name, "UQ_Brand").IsUnique();
            entity.Property(e => e.Name).HasMaxLength(255);

        });

        modelBuilder.Entity<Product>(entity => {

            entity.ToTable("Product", tb => tb.HasTrigger("TSetupVariant"));
            entity.Property(e => e.Description).HasColumnType("text");
            entity.Property(e => e.Name).HasMaxLength(255);

            entity
                .HasOne(d => d.Brand).WithMany(p => p.Products)
                .HasForeignKey(d => d.BrandId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Product_Brand");

        });

        modelBuilder.Entity<Variant>(entity => {

            entity.HasNoKey().ToTable("Variant");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Value).HasMaxLength(255);
            entity.Property(e => e.VariationType).HasMaxLength(100);

        });

        modelBuilder.Entity<VCharacteristic>(entity => {

            entity.HasNoKey().ToView("VCharacteristics");
            entity.Property(e => e.Name).HasMaxLength(100);

        });

        OnModelCreatingPartial(modelBuilder);

    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

}
