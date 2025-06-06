using LendIT.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LendIT.Configurations;

public class PozycjaWypozyczeniaConfiguration : IEntityTypeConfiguration<PozycjaWypozyczenia>
{
    public void Configure(EntityTypeBuilder<PozycjaWypozyczenia> builder)
    {
        builder.HasKey("Id");

        builder.Property<int>("Ilosc").IsRequired();

        builder.HasOne(typeof(Sprzet), "Sprzet")
            .WithMany("PozycjeWypozyczenia")
            .HasForeignKey("SprzetId")
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(typeof(Wypozyczenie), "Wypozyczenie")
            .WithMany("Pozycje")
            .HasForeignKey("WypozyczenieId")
            .OnDelete(DeleteBehavior.Cascade);
    }
}