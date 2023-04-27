namespace CodeFirst.Shared;

public class BaseModel{

    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

}
