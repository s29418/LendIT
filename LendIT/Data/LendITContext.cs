using LendIT.Models.Entities;
using Microsoft.EntityFrameworkCore;
using LendIT.Configurations;

namespace LendIT.Data;

public class LendITContext : DbContext
{
    public LendITContext(DbContextOptions<LendITContext> options) : base(options)
    {
    }
    
    public DbSet<Sprzet> Sprzety => Set<Sprzet>();
    public DbSet<Klient> Klienci => Set<Klient>();
    public DbSet<Administrator> Administratorzy => Set<Administrator>();
    public DbSet<Adres> Adresy => Set<Adres>();
    public DbSet<KategoriaSprzetu> KategorieSprzetu => Set<KategoriaSprzetu>();
    public DbSet<ZdjecieSprzetu> ZdjeciaSprzetu => Set<ZdjecieSprzetu>();
    public DbSet<Wypozyczenie> Wypozyczenia => Set<Wypozyczenie>();
    public DbSet<PozycjaWypozyczenia> PozycjeWypozyczen => Set<PozycjaWypozyczenia>();
    public DbSet<Platnosc> Platnosci => Set<Platnosc>();
    public DbSet<Koszyk> Koszyki => Set<Koszyk>();
    public DbSet<PozycjaKoszyka> PozycjeKoszyka => Set<PozycjaKoszyka>();
    public DbSet<Zwrot> Zwroty => Set<Zwrot>();
    public DbSet<EtykietaZwrotna> EtykietyZwrotne => Set<EtykietaZwrotna>();
    public DbSet<RecenzjaSprzetu> RecenzjeSprzetu => Set<RecenzjaSprzetu>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new SprzetConfiguration());
        modelBuilder.ApplyConfiguration(new KlientConfiguration());
        modelBuilder.ApplyConfiguration(new AdministratorConfiguration());
        modelBuilder.ApplyConfiguration(new UzytkownikConfiguration());
        modelBuilder.ApplyConfiguration(new AdresConfiguration());
        modelBuilder.ApplyConfiguration(new KategoriaSprzetuConfiguration());
        modelBuilder.ApplyConfiguration(new ZdjecieSprzetuConfiguration());
        modelBuilder.ApplyConfiguration(new WypozyczenieConfiguration());
        modelBuilder.ApplyConfiguration(new PozycjaWypozyczeniaConfiguration());
        modelBuilder.ApplyConfiguration(new PlatnoscConfiguration());
        modelBuilder.ApplyConfiguration(new KoszykConfiguration());
        modelBuilder.ApplyConfiguration(new PozycjaKoszykaConfiguration());
        modelBuilder.ApplyConfiguration(new ZwrotConfiguration());
        modelBuilder.ApplyConfiguration(new EtykietaZwrotnaConfiguration());
        modelBuilder.ApplyConfiguration(new RecenzjaSprzetuConfiguration());
    }
}
