using Microsoft.AspNetCore.Mvc;
using CodeFirst.Providers;

namespace CodeFirst.Controllers;

[ApiController]
[Route("report")]
public class ReportController : BaseController{

    public ReportController(CDFContext context) : base(context) { }

    [HttpGet]
    public async Task<IList<Product>> Get() => await _context
        .Products
            .Include(b => b.Brand)
            .Include(v => v.Variants!)
                .ThenInclude(e => e.Variant!)
                    .ToListAsync();
}
