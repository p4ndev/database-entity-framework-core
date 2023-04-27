using System.Text.Json.Serialization;

namespace CodeFirst.Models;

[Table("Variant")]
public class Variant : BaseModel {

    [Required]
    [Column("VariantType")]
    public VariantTypeEnum Type { get; set; }

    [Required]
    public string Value { get; set; } = null!;

    [JsonIgnore]
    [InverseProperty("Variant")]
    public ICollection<ProductVariant>? Products { get; set; }

    public Variant() { }

}