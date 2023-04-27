using Microsoft.AspNetCore.Mvc;
using CodeFirst.Providers;

namespace CodeFirst.Controllers;

[ApiController]
[Route("brand")]
public class BrandController : BaseController {

    public BrandController(CDFContext context) : base(context) { }

    [HttpGet]
    public async Task<IList<Brand>> Get()
        => await _context.Brands.ToListAsync();

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] Brand model) {
        await _context.Brands.AddAsync(model);
        await _context.SaveChangesAsync();
        return Created(nameof(model), model.Id);
    }

}