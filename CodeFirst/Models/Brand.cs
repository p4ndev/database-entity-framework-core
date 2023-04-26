namespace CodeFirst.Models;

[Table("Brand")]
[Index(nameof(Name), IsUnique = true, Name = "UQ_Brand")]
public class Brand {

    public Brand() { }

    public Brand(string name) => Name = name;

    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required]
    public string Name { get; set; } = null!;

}