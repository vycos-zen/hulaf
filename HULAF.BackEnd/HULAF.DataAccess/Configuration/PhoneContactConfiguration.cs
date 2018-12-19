using HULAF.Domain.Personal.Contact;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace HULAF.DataAccess.Configuration
{
    public class PhoneContactConfiguration : IEntityTypeConfiguration<PhoneContact>
    {
        public void Configure(EntityTypeBuilder<PhoneContact> builder)
        {
            builder.HasKey(x => x.PhoneContactGuid);
        }
    }
}
