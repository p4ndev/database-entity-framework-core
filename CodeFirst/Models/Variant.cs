namespace CodeFirst.Models;

[Table("Variant")]
public class Variant{

    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required]
    [Column("VariantType")]
    public EVariantType Type { get; set; }

    [Required]
    public string Value { get; set; } = null!;

    [InverseProperty("Variant")]
    public ICollection<ProductVariant>? Products { get; set; }

}