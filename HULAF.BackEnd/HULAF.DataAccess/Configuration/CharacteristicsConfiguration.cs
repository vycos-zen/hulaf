using HULAF.Domain.DataDictionary.CharacteristicsDictionaryItems;
using HULAF.Domain.Personal.Characteristic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace HULAF.DataAccess.Configuration
{
    public class CharacteristicsConfiguration : IEntityTypeConfiguration<Characteristics>
    {
        public void Configure(EntityTypeBuilder<Characteristics> builder)
        {
            builder.HasKey(p => p.Guid);

            builder.Property(p => p.EyeColor)
                .ValueGeneratedNever();

            builder.Property(p => p.HairColor)
                .ValueGeneratedNever();

            builder.HasOne(p => p.EyeColor)
                .WithMany()
                .HasForeignKey(nameof(Characteristics.EyeColorGuid));

            builder.HasOne(p => p.EyeColor)
                .WithMany()
                .HasForeignKey(nameof(Characteristics.HairColorGuid));
        }
    }
}
