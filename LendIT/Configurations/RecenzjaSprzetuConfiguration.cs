using LendIT.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LendIT.Configurations;

public class RecenzjaSprzetuConfiguration : IEntityTypeConfiguration<RecenzjaSprzetu>
{
    public void Configure(EntityTypeBuilder<RecenzjaSprzetu> builder)
    {
        builder.HasKey("Id");

        builder.Property<int>("Ocena").IsRequired();
        builder.Property<string>("Komentarz");
        builder.Property<DateTime>("DataDodania").IsRequired();

        builder.HasOne(typeof(Sprzet), "Sprzet")
            .WithMany("Recenzje")
            .HasForeignKey("SprzetId")
            .OnDelete(DeleteBehavior.Cascade);
    }
}