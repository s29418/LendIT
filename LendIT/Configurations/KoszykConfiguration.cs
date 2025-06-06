using LendIT.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LendIT.Configurations;

public class KoszykConfiguration : IEntityTypeConfiguration<Koszyk>
{
    public void Configure(EntityTypeBuilder<Koszyk> builder)
    {
        builder.HasKey("Id");

        builder.Property<int>("KlientId").IsRequired();
        
        builder.HasMany(typeof(PozycjaKoszyka), "Pozycje")
            .WithOne("Koszyk")
            .HasForeignKey("KoszykId")
            .OnDelete(DeleteBehavior.Cascade);
        
        builder.HasOne(typeof(Klient), "Klient")
            .WithOne("Koszyk")
            .HasForeignKey(typeof(Koszyk), "KlientId")
            .OnDelete(DeleteBehavior.Cascade);
    }
}