using Microsoft.AspNetCore.Mvc;
using CodeFirst.Providers;

namespace CodeFirst.Controllers;

[ApiController]
[Route("product")]
public class ProductController : BaseController {

    public ProductController(CDFContext context) : base(context) { }

    [HttpGet]
    public async Task<IList<Product>> Get()
        => await _context.Products.ToListAsync();

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] Product model) {

        await _context.Products.AddAsync(model);

        await _context.SaveChangesAsync();

        await _context.ProductVariant.AddAsync(new() {
            ProductId = model.Id,
            VariantId = 1
        });

        await _context.ProductVariant.AddAsync(new(){
            ProductId = model.Id,
            VariantId = 2
        });

        await _context.SaveChangesAsync();
        
        return Created(nameof(model), model.Id);

    }

}