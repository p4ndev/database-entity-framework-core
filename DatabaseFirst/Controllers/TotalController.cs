using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using DatabaseFirst.Provider;
using DatabaseFirst.Models;

namespace DatabaseFirst.Controllers;

[ApiController]
[Route("[controller]")]
public class TotalController : ControllerBase{

    [HttpGet("Product")]
    public async Task<long> GetProductCount([FromServices] PlainContext context)
        => await context.Products.LongCountAsync();

    [HttpGet("Brand")]
    public async Task<long> GetBrandCount([FromServices] PlainContext context)
        => await context.Brands.LongCountAsync();

    [HttpGet("Color")]
    public async Task<long> GetColorVariantCount([FromServices] PlainContext context)
        => await context.Variants.LongCountAsync(x => x.VariationType == "Color");

    [HttpGet("Size")]
    public async Task<long> GetSizeVariantCount([FromServices] PlainContext context)
        => await context.Variants.LongCountAsync(x => x.VariationType == "Size");

    [HttpGet("Stats")]
    public async Task<IList<VCharacteristic>> GetStats([FromServices] PlainContext context)
        => await context.VCharacteristics.ToListAsync();

}
