using LendIT.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LendIT.Configurations;

public class ZdjecieSprzetuConfiguration : IEntityTypeConfiguration<ZdjecieSprzetu>
{
    public void Configure(EntityTypeBuilder<ZdjecieSprzetu> builder)
    {
        builder.HasKey("Id");

        builder.Property<string>("Url").IsRequired();

        builder.Property<int>("SprzetId").IsRequired();

        builder.HasOne(typeof(Sprzet), "Sprzet")
            .WithMany("Zdjecia")
            .HasForeignKey("SprzetId")
            .OnDelete(DeleteBehavior.Cascade);
    }
}