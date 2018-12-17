using HULAF.Domain.DataDictionary.CharacteristicsDictionaryItems;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace HULAF.DataAccess.Configuration
{
    public class EyeColorDictionaryItemConfiguration : IEntityTypeConfiguration<EyeColorDictionaryItem>
    {
        public void Configure(EntityTypeBuilder<EyeColorDictionaryItem> builder)
        {
            builder.HasKey(p => p.Guid);
        }
    }
}
