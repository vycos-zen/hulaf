using HULAF.Domain.DataDictionary.CharacteristicsDictionaryItems;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace HULAF.DataAccess.Configuration
{
    public class HairColorDictionaryItemConfiguration : IEntityTypeConfiguration<HairColorDictionaryItem>
    {
        public void Configure(EntityTypeBuilder<HairColorDictionaryItem> builder)
        {
            builder.HasKey(p => p.Guid);

        }
    }


}