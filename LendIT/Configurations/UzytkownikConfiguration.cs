using LendIT.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LendIT.Configurations;

public class UzytkownikConfiguration : IEntityTypeConfiguration<Uzytkownik>
{
    public void Configure(EntityTypeBuilder<Uzytkownik> builder)
    {
        builder.HasKey("Id");

        builder.Property<string>("Imie").IsRequired();
        builder.Property<string>("Nazwisko").IsRequired();
        builder.Property<string>("Email").IsRequired();
        builder.Property<string>("Haslo").IsRequired();

        builder.HasDiscriminator<string>("TypUzytkownika")
            .HasValue<Klient>("Klient")
            .HasValue<Administrator>("Administrator");
    }
}