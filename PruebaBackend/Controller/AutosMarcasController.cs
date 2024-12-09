namespace PruebaBackend{

using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

[ApiController]
[Route("api/[controller]")]
public class MarcasAutosController : ControllerBase
{
    private readonly AppDbContext _context;

    public MarcasAutosController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public ActionResult<IEnumerable<AutoMarca>> Get()
    {
        return Ok(_context.AutosMarca.ToList());
    }
}


}