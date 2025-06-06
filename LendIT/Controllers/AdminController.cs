using LendIT.Data;
using LendIT.DTOs;
using LendIT.Models.Entities;
using LendIT.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LendIT.Controllers;

[ApiController]
[Route("api/admin")]
public class AdminController : ControllerBase
{
    private readonly ISprzetService _sprzetService;
    private readonly IKategoriaService _kategoriaService;
    private readonly LendITContext _context;
    
    public AdminController(
        ISprzetService sprzetService,
        IKategoriaService kategoriaService,
        LendITContext context)
    {
        _sprzetService = sprzetService;
        _kategoriaService = kategoriaService;
        _context = context;
    }

    [HttpPost("sprzet")]
    public async Task<IActionResult> DodajSprzet([FromBody] SprzetCreateDto dto)
    {
        var admin = await _context.Administrator
            .Include(a => a.Id) 
            .FirstOrDefaultAsync(a => a.Id == GetCurrentUserId());

        if (admin == null) return Unauthorized();

        await _sprzetService.DodajAsync(admin, dto);
        return Ok();
    }

    [HttpPut("sprzet/{id}")]
    public async Task<IActionResult> EdytujSprzet(int id, [FromBody] SprzetUpdateDto dto)
    {
        await _sprzetService.EdytujAsync(id, dto);
        return Ok();
    }

    [HttpDelete("sprzet/{id}")]
    public async Task<IActionResult> UsunSprzet(int id)
    {
        await _sprzetService.UsunAsync(id);
        return Ok();
    }

    [HttpPost("kategoria")]
    public async Task<IActionResult> DodajKategorie([FromBody] string nazwa)
    {
        await _kategoriaService.DodajNowaAsync(nazwa);
        return Ok();
    }
    
    private int GetCurrentUserId()
    {
        return int.Parse(User.Claims.First(c => c.Type == "id").Value);
    }
}
