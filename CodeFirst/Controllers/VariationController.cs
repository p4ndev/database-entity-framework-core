using Microsoft.AspNetCore.Mvc;
using CodeFirst.Providers;

namespace CodeFirst.Controllers;

[ApiController]
[Route("variation")]
public class VariationController : ControllerBase {

    private readonly CDFContext _context;

    public VariationController(CDFContext context) => _context = context;

    [HttpGet]
    public async Task<IList<Variant>> Get()
        => await _context.Variants.ToListAsync();

}