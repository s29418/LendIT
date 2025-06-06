using LendIT.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LendIT.Configurations;

public class AdresConfiguration : IEntityTypeConfiguration<Adres>
{
    public void Configure(EntityTypeBuilder<Adres> builder)
    {
        builder.HasKey("Id");

        builder.Property<string>("Ulica").IsRequired();
        builder.Property<string>("NumerDomu").IsRequired();
        builder.Property<string>("Miasto").IsRequired();
        builder.Property<string>("KodPocztowy").IsRequired();

        builder.Property<int>("KlientId").IsRequired();

        builder.HasOne(typeof(Klient), "Klient")
            .WithMany("Adresy")
            .HasForeignKey("KlientId")
            .OnDelete(DeleteBehavior.Cascade);
        
        builder.HasMany(typeof(Zwrot), "Zwroty")
            .WithOne("Adres")
            .HasForeignKey("AdresId")
            .OnDelete(DeleteBehavior.Restrict);
    }
}