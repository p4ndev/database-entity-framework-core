namespace DatabaseFirst.Models;

public partial class Product{
    public int              Id              { get; set; }
    public int              BrandId         { get; set; }
    public string?          Description     { get; set; }
    public string           Name            { get; set; } = null!;
    public virtual Brand    Brand           { get; set; } = null!;
}
