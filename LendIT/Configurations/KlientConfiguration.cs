using LendIT.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LendIT.Configurations;

public class KlientConfiguration : IEntityTypeConfiguration<Klient>
{
    public void Configure(EntityTypeBuilder<Klient> builder)
    {
        builder.HasKey("Id");

        builder.Property<string>("Imie").IsRequired();
        builder.Property<string>("Nazwisko").IsRequired();
        builder.Property<string>("Email").IsRequired();
        builder.Property<string>("Haslo").IsRequired();
        builder.Property<string>("NrTelefonu").IsRequired();
        
        builder.HasOne(typeof(Koszyk), "Koszyk")
            .WithOne("Klient")
            .HasForeignKey("KlientId")
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(typeof(Adres), "Adresy")
            .WithOne("Klient")
            .HasForeignKey("KlientId")
            .OnDelete(DeleteBehavior.Cascade);
    }
}