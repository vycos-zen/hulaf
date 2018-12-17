using HULAF.Domain.Personal.Contact;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace HULAF.DataAccess.Configuration
{
    public class ContactInfoConfiguration : IEntityTypeConfiguration<ContactInfo>
    {
        public void Configure(EntityTypeBuilder<ContactInfo> builder)
        {
            builder.Property(e => e.OtherKnownNames)
                .HasConversion(
                v => string.Join(";", v),
                v => v.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries));
        }
    }
}
