using HULAF.Domain.DataDictionary.Schema.CharacteristicsDataDictionaries;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace HULAF.DataAccess.Configuration
{
    class EyeColorDictionaryConfiguration : IEntityTypeConfiguration<EyeColorDictionary>
    {
        public void Configure(EntityTypeBuilder<EyeColorDictionary> builder)
        {
            builder.HasKey(x => x.EyeColorDictionaryGuid);
        }
    }
}
