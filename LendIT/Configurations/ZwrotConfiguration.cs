using LendIT.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LendIT.Configurations;

public class ZwrotConfiguration : IEntityTypeConfiguration<Zwrot>
{
    public void Configure(EntityTypeBuilder<Zwrot> builder)
    {
        builder.HasKey("Id");

        builder.Property<DateTime>("DataZgloszenia").IsRequired();
        builder.Property<DateTime?>("DataOdbioru");
        builder.Property<string>("KomentarzAdministratora");

        builder.HasOne(typeof(Wypozyczenie), "Wypozyczenie")
            .WithOne()
            .HasForeignKey(typeof(Zwrot), "WypozyczenieId")
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(typeof(Adres), "Adres")
            .WithMany()
            .HasForeignKey("AdresId")
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(typeof(EtykietaZwrotna), "EtykietaZwrotna")
            .WithOne("Zwrot")
            .HasForeignKey(typeof(Zwrot),"ZwrotId")
            .OnDelete(DeleteBehavior.Cascade);
    }
}