using LendIT.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace LendIT.Data

{
    public class LendITContext : DbContext
    {
        public LendITContext(DbContextOptions<LendITContext> options) : base(options) { }
        
        public DbSet<Sprzet> Sprzety { get; set; }
        // public DbSet<Klient> Klienci { get; set; }
        // public DbSet<Wypozyczenie> Wypozyczenia { get; set; }
        // public DbSet<Administrator> Administratorzy { get; set; }
        // public DbSet<RecenzjaSprzetu> Recenzje { get; set; }
        // public DbSet<PozycjaWypozyczenia> PozycjeWypozyczen { get; set; }
        // public DbSet<Zwrot> Zwroty { get; set; }
        // public DbSet<EtykietaZwrotna> EtykietyZwrotne { get; set; }
    }
}
