using LendIT.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LendIT.Configurations;

public class PlatnoscConfiguration : IEntityTypeConfiguration<Platnosc>
{
    public void Configure(EntityTypeBuilder<Platnosc> builder)
    {
        builder.HasKey("Id");

        builder.Property<float>("Kwota").IsRequired();
        builder.Property("StatusPlatnosci")
            .HasConversion<int>()
            .IsRequired();

        builder.HasOne(typeof(Klient), "Klient")
            .WithMany()
            .HasForeignKey("KlientId")
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(typeof(Wypozyczenie), "Wypozyczenie")
            .WithOne("Platnosc")
            .HasForeignKey(typeof(Platnosc), "WypozyczenieId")
            .OnDelete(DeleteBehavior.Cascade);

        
    }
}