using LendIT.Data;
using LendIT.DTOs;
using LendIT.Models.Entities;
using LendIT.Models.ValueObjects;
using Microsoft.EntityFrameworkCore;

namespace LendIT.Services;

public class SprzetService : ISprzetService
{
    private readonly LendITContext _context;

    public SprzetService(LendITContext context)
    {
        _context = context;
    }

    public async Task DodajAsync(SprzetCreateDto dto)
    {
        var administrator = new Administrator(); // można przekazać przez DI, jeśli potrzebne

        var kategorie = await _context.KategoriaSprzetu
            .Where(k => dto.KategorieIds.Contains(k.Id))
            .ToListAsync();

        var wymiary = new Wymiary
        {
            Wysokosc = dto.Wymiary.Wysokosc,
            Szerokosc = dto.Wymiary.Szerokosc,
            Glebokosc = dto.Wymiary.Glebokosc,
            Waga = dto.Wymiary.Waga
        };

        var sprzet = administrator.DodajSprzet(
            dto.Nazwa,
            dto.Opis,
            dto.Cena,
            dto.Kaucja,
            dto.Status,
            wymiary,
            kategorie,
            dto.ZdjeciaUrl
        );

        await _context.Sprzet.AddAsync(sprzet);
        await _context.SaveChangesAsync();
    }

    public async Task EdytujAsync(int id, SprzetUpdateDto dto)
    {
        var sprzet = await _context.Sprzet.FindAsync(id);
        if (sprzet == null) throw new Exception("Sprzęt nie znaleziony.");

        var administrator = new Administrator();
        administrator.EdytujSprzet(
            sprzet,
            dto.Nazwa,
            dto.Opis,
            dto.Cena,
            dto.Kaucja
        );

        await _context.SaveChangesAsync();
    }

    public async Task UsunAsync(int id)
    {
        var sprzet = await _context.Sprzet.FindAsync(id);
        if (sprzet == null) throw new Exception("Sprzęt nie znaleziony.");

        var administrator = new Administrator();
        administrator.UsunSprzet(sprzet);

        await _context.SaveChangesAsync();
    }
}
