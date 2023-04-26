using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using DatabaseFirst.Providers;
using DatabaseFirst.Models;

namespace DatabaseFirst.Controllers;

[ApiController]
[Route("[controller]")]
public class TotalController : ControllerBase{

    private readonly DBFContext _context;

    public TotalController(DBFContext context) => _context = context;

    [HttpGet("Product")]
    public async Task<long> GetProductCount()
        => await _context.Products.LongCountAsync();

    [HttpGet("Brand")]
    public async Task<long> GetBrandCount()
        => await _context.Brands.LongCountAsync();

    [HttpGet("Color")]
    public async Task<long> GetColorVariantCount()
        => await _context.Variants.LongCountAsync(x => x.VariationType == "Color");

    [HttpGet("Size")]
    public async Task<long> GetSizeVariantCount()
        => await _context.Variants.LongCountAsync(x => x.VariationType == "Size");

    [HttpGet("Stats")]
    public async Task<IList<VCharacteristic>> GetStats()
        => await _context.VCharacteristics.ToListAsync();

    [HttpGet("Product-Sizes")]
    public IActionResult GetProductSizeVariations() 
        => Ok(
            (from items in _context.Variants
                where items.VariationType == "Size"
                group items by items.Value into temp
            select new {
                Total = temp.Count(),
                Sizes = temp.Key,
                Type = "Size"
            }).OrderByDescending(o => o.Total)
        );

}
