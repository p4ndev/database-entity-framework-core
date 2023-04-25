namespace DatabaseFirst.Models;

public partial class Variant{
    public int          Id              { get; set; }
    public string?      Value           { get; set; }
    public int?         ProductId       { get; set; }
    public string?      VariationType   { get; set; }
}
