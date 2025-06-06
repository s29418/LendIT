using LendIT.Data;
using LendIT.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace LendIT.Services;

public class KategoriaService : IKategoriaService
{
    private readonly LendITContext _context;

    public KategoriaService(LendITContext context)
    {
        _context = context;
    }

    public async Task DodajNowaAsync(string nazwa)
    {
        var istnieje = await _context.KategoriaSprzetu.AnyAsync(k => k.Nazwa == nazwa);
        if (istnieje)
            throw new Exception("Taka kategoria już istnieje.");

        var administrator = new Administrator();
        var kat = administrator.DodajNowaKategorie(nazwa);

        await _context.KategoriaSprzetu.AddAsync(kat);
        await _context.SaveChangesAsync();
    }
}