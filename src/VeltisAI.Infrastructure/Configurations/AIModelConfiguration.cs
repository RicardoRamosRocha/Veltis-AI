using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VeltisAI.Domain.Entities;

namespace VeltisAI.Infrastructure.Configurations;

public class AIModelConfiguration : IEntityTypeConfiguration<AIModel>
{
    public void Configure(EntityTypeBuilder<AIModel> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Name)
            .IsRequired()
            .HasMaxLength(120);

        builder.Property(x => x.Identifier)
            .IsRequired()
            .HasMaxLength(120);

        builder.Property(x => x.InputTokenPricePerMillion)
            .HasPrecision(18, 6);

        builder.Property(x => x.OutputTokenPricePerMillion)
            .HasPrecision(18, 6);

        builder.HasIndex(x => x.AIProviderId);
        builder.HasIndex(x => x.Identifier);
        builder.HasIndex(x => x.Active);
    }
}