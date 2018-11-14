using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using HULAF.Domain.Person;

namespace HULAF.DataAccess.Context
{
    public class HULAFContext : DbContext
    {
        public DbSet<MissingPerson> MissingPerson { get; set; }
    }
}