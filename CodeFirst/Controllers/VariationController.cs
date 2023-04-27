using Microsoft.AspNetCore.Mvc;
using CodeFirst.Providers;

namespace CodeFirst.Controllers;

[ApiController]
[Route("variation")]
public class VariationController : BaseController {

    public VariationController(CDFContext context) : base(context) { }

    [HttpGet]
    public async Task<IList<Variant>> Get()
        => await _context.Variants.ToListAsync();

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] Variant model) {
        await _context.Variants.AddAsync(model);
        await _context.SaveChangesAsync();
        return Created(nameof(model), model.Id);
    }

}