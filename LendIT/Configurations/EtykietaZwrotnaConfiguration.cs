using LendIT.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LendIT.Configurations;

public class EtykietaZwrotnaConfiguration : IEntityTypeConfiguration<EtykietaZwrotna>
{
    public void Configure(EntityTypeBuilder<EtykietaZwrotna> builder)
    {
        builder.HasKey("Id");

        builder.Property<string>("Kod").IsRequired();

        builder.HasOne(typeof(Zwrot), "Zwrot")
            .WithOne("EtykietaZwrotna")
            .HasForeignKey(typeof(EtykietaZwrotna), "ZwrotId")
            .OnDelete(DeleteBehavior.Cascade);
    }
}