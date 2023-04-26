namespace CodeFirst.Providers;

public class CDFContext : DbContext{

    public CDFContext(DbContextOptions<CDFContext> o) : base(o){ }

    public DbSet<Brand>             Brands            { get; set; }
    public DbSet<Product>           Products          { get; set; }
    public DbSet<Variant>           Variants          { get; set; }
    public DbSet<ProductVariant>    ProductVariant    { get; set; }

}