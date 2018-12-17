using HULAF.DataAccess.Context;
using HULAF.Domain.Personal;
using HULAF.Domain.Personal.Contact;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HULAF.UnitTests
{
    public class HULAFContextFactory
    {
        public static HULAFContext Create()
        {
            var options = new DbContextOptionsBuilder<HULAFContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;

            var context = new HULAFContext(options);

            context.Database.EnsureCreated();

            context.Person.AddRange(new[]
            {
                new Person {Guid = new Guid("D596BF2C-6DDB-4CCB-A71B-54F18ABE5EF5"), ContactInfo = new ContactInfo{ Guid = new Guid("BCAA02BC-2523-449D-BA5D-8F91DB1CBB0"), FirstName = "Béla" } }

            });

            context.SaveChanges();

            return context;
        }

        public static void Destroy(HULAFContext context)
        {
            context.Database.EnsureDeleted();

            context.Dispose();
        }
    }
}
