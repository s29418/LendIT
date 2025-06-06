using LendIT.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LendIT.Configurations;

public class PozycjaKoszykaConfiguration : IEntityTypeConfiguration<PozycjaKoszyka>
{
    public void Configure(EntityTypeBuilder<PozycjaKoszyka> builder)
    {
        builder.HasKey("Id");

        builder.Property<int>("Ilosc").IsRequired();
        builder.Property<int>("SprzetId").IsRequired();
        builder.Property<int>("KoszykId").IsRequired();

        builder.HasOne(typeof(Sprzet), "Sprzet")
            .WithMany()
            .HasForeignKey("SprzetId")
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(typeof(Koszyk), "Koszyk")
            .WithMany("Pozycje")
            .HasForeignKey("KoszykId")
            .OnDelete(DeleteBehavior.Cascade);
    }
}