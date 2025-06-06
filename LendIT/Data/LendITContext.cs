using LendIT.Models.Entities;
using Microsoft.EntityFrameworkCore;
using LendIT.Configurations;

namespace LendIT.Data;

public class LendITContext : DbContext
{
    public LendITContext(DbContextOptions<LendITContext> options) : base(options)
    {
    }
    
    public DbSet<Sprzet> Sprzet => Set<Sprzet>();
    public DbSet<Klient> Klient => Set<Klient>();
    public DbSet<Administrator> Administrator => Set<Administrator>();
    public DbSet<Adres> Adres => Set<Adres>();
    public DbSet<KategoriaSprzetu> KategoriaSprzetu => Set<KategoriaSprzetu>();
    public DbSet<ZdjecieSprzetu> ZdjecieSprzetu => Set<ZdjecieSprzetu>();
    public DbSet<Wypozyczenie> Wypozyczenia => Set<Wypozyczenie>();
    public DbSet<PozycjaWypozyczenia> PozycjaWypozyczenia => Set<PozycjaWypozyczenia>();
    public DbSet<Platnosc> Platnosc => Set<Platnosc>();
    public DbSet<Koszyk> Koszyk => Set<Koszyk>();
    public DbSet<PozycjaKoszyka> PozycjaKoszyka => Set<PozycjaKoszyka>();
    public DbSet<Zwrot> Zwrot => Set<Zwrot>();
    public DbSet<EtykietaZwrotna> EtykietaZwrotna => Set<EtykietaZwrotna>();
    public DbSet<RecenzjaSprzetu> RecenzjaSprzetu => Set<RecenzjaSprzetu>();

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
