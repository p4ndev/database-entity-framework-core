namespace CodeFirst.Models;

[Table("Product")]
public class Product{

    public Product() { }

    public Product(int brandId, string title, string description){
        Name = title;
        BrandId = brandId;
        Description = description;
    }

    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

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

}