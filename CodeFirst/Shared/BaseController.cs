using Microsoft.AspNetCore.Mvc;
using CodeFirst.Providers;

namespace CodeFirst.Shared;

public class BaseController : ControllerBase{
    protected readonly CDFContext _context;
    public BaseController(CDFContext context) => _context = context;
}
