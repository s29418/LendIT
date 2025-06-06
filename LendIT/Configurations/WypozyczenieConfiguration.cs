using LendIT.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LendIT.Configurations;

public class WypozyczenieConfiguration : IEntityTypeConfiguration<Wypozyczenie>
{
    public void Configure(EntityTypeBuilder<Wypozyczenie> builder)
    {
        builder.HasKey("Id");

        builder.Property<DateTime>("DataWypozyczenia").IsRequired();
        builder.Property<DateTime>("DataZakonczenia").IsRequired();
        builder.Property("Status")
            .HasConversion<int>()
            .IsRequired();


        builder.Ignore("CalkowityKoszt");

        builder.HasMany(typeof(PozycjaWypozyczenia), "Pozycje")
            .WithOne("Wypozyczenie")
            .HasForeignKey("WypozyczenieId")
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(typeof(Klient), "Klient")
            .WithMany()
            .HasForeignKey("KlientId")
            .OnDelete(DeleteBehavior.Restrict);

        // builder.HasOne(typeof(Platnosc), "Platnosc")
        //     .WithOne("Wypozyczenie")
        //     .HasForeignKey("WypozyczenieId")
        //     .OnDelete(DeleteBehavior.Cascade);
    }
}