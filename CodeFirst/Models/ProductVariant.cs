namespace CodeFirst.Models;

public class ProductVariant : BaseModel {

    public int ProductId    { get; set; }
    public int VariantId    { get; set; }

    [ForeignKey("ProductId")]
    public Product? Product { get; set; }

    [ForeignKey("VariantId")]
    public Variant? Variant { get; set; }

    public ProductVariant() { }

}