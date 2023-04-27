namespace CodeFirst.Models;

[Table("Product")]
public class Product : BaseModel {

    public Product(int brandId, string title, string description){
        Name = title;
        BrandId = brandId;
        Description = description;
    }

    [Required]
    public int BrandId { get; set; }

    [Required]
    public string Name { get; set; } = null!;

    [Column(TypeName = "text")]
    public string? Description { get; set; }

    [ForeignKey("BrandId")]
    public Brand? Brand { get; set; }

    [InverseProperty("Product")]
    public ICollection<ProductVariant>? Variants { get; set; }

    public Product() { }

}