namespace CodeFirst.Models;

public class ProductVariant {

    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    
    public int Id           { get; set; }
    public int ProductId    { get; set; }
    public int VariantId    { get; set; }

    [ForeignKey("ProductId")]
    public Product? Product { get; set; }

    [ForeignKey("VariantId")]
    public Variant? Variant { get; set; }

}