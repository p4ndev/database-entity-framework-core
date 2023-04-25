using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using DatabaseFirst.Provider;
using DatabaseFirst.Models;

namespace DatabaseFirst.Controllers;

[ApiController]
[Route("[controller]")]
public class BrandController : ControllerBase {

    private readonly PlainContext _context;

    public BrandController(PlainContext context) => _context = context;

    [HttpGet]
    public async Task<IList<Brand>> Get()
        => await _context.Brands.OrderBy(t => t.Id).ToListAsync();

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] Brand model) {
        await _context.Brands.AddAsync(model);
        return StatusCode(await _context.SaveChangesAsync() > 0 ? 200 : 400);
    }

    [HttpPut]
    public async Task<IActionResult> Put([FromBody] Brand model) {
        
        var entity = await _context.Brands.SingleOrDefaultAsync(t => t.Id == model.Id);        
        if (entity is null) return NotFound();

        entity.Name = model.Name;
        _context.Update(entity);

        return StatusCode(await _context.SaveChangesAsync() > 0 ? 200 : 400);

    }

    [HttpDelete("{bid}")]
    public async Task<IActionResult> Delete([FromRoute] int bid) {
        var entity = await _context.Brands.SingleOrDefaultAsync(t => t.Id.Equals(bid));
        if (entity is null) return NotFound();
        _context.Remove(entity);
        return StatusCode(await _context.SaveChangesAsync() > 0 ? 200 : 400);
    }

}