namespace CodeFirst.Models;

[Table("Brand")]
[Index(nameof(Name), IsUnique = true, Name = "UQ_Brand")]
public class Brand : BaseModel {

    public Brand(string name) => Name = name;

    [Required]
    public string Name { get; set; } = null!;

    public Brand() { }

}