using LendIT.Models.Entities;
using LendIT.Models.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LendIT.Configurations;

public class SprzetConfiguration : IEntityTypeConfiguration<Sprzet>
{
    public void Configure(EntityTypeBuilder<Sprzet> builder)
    {
        builder.HasKey("SerialNumber");
        
        builder.Property<string>("Nazwa").IsRequired();
        builder.Property<decimal>("Cena").IsRequired();
        builder.Property<decimal>("Kaucja").IsRequired();
        builder.Property<string>("Opis").IsRequired();
        builder.Property<int>("Status").IsRequired(); 
        

        builder.OwnsOne(typeof(Wymiary), "Wymiary", w =>
        {
            w.Property<double>("Wysokosc").IsRequired();
            w.Property<double>("Szerokosc").IsRequired();
            w.Property<double>("Glebokosc").IsRequired();
            w.Property<double>("Waga").IsRequired();
        });
        
        builder.HasMany(typeof(ZdjecieSprzetu), "Zdjecia")
            .WithOne("Sprzet")
            .HasForeignKey("SprzetId")
            .OnDelete(DeleteBehavior.Cascade);
        
        builder.HasMany(typeof(RecenzjaSprzetu), "Recenzje")
            .WithOne("Sprzet")
            .HasForeignKey("SprzetId")
            .OnDelete(DeleteBehavior.Cascade);
        
        builder.HasMany(typeof(PozycjaWypozyczenia), "PozycjeWypozyczenia")
            .WithOne("Sprzet")
            .HasForeignKey("SprzetId")
            .OnDelete(DeleteBehavior.Restrict);
        
        builder.HasMany(typeof(KategoriaSprzetu), "Kategorie")
            .WithMany();
    }
}
