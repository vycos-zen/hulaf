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
                new Person {PersonGuid = Guid.Parse("{ddf3e819-3caa-46bd-95d8-0a20a1929600}"), ContactInfo = new ContactInfo{ ContactInfoGuid = Guid.Parse("{b8296c3e-fd11-421d-961e-1a8de7b4c3b0}"), FirstName = "Béla" } }

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
