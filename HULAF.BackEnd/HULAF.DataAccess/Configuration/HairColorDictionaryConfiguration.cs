using HULAF.Domain.DataDictionary.CharacteristicsDataDictionaries;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace HULAF.DataAccess.Configuration
{
    public class HairColorDictionaryConfiguration : IEntityTypeConfiguration<HairColorDictionary>
    {
        public void Configure(EntityTypeBuilder<HairColorDictionary> builder)
        {
            builder.HasKey(x => x.HairColorDictionaryGuid);
        }

    }
}
