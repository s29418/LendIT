using LendIT.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LendIT.Configurations;

public class KategoriaSprzetuConfiguration : IEntityTypeConfiguration<KategoriaSprzetu>
{
    public void Configure(EntityTypeBuilder<KategoriaSprzetu> builder)
    {
        builder.HasKey("Id");

        builder.Property<string>("Nazwa").IsRequired();

        builder.HasMany(typeof(Sprzet), "Sprzety")
            .WithMany("Kategorie");
    }
}