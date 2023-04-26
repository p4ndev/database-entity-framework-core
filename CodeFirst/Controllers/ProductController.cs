using Microsoft.AspNetCore.Mvc;
using CodeFirst.Providers;

namespace CodeFirst.Controllers;

[ApiController]
[Route("product")]
public class ProductController : ControllerBase {

    private readonly CDFContext _context;

    public ProductController(CDFContext context) => _context = context;

    [HttpGet]
    public async Task<IList<Product>> Get()
        => await _context.Products.OrderBy(t => t.Id).ToListAsync();

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] Product model) {
        await _context.Products.AddAsync(model);
        await _context.SaveChangesAsync();
        return Created(nameof(model), model.Id);
    }

}