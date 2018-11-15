using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using HULAF.Domain.Person;

namespace HULAF.DataAccess.Context
{
    public class HULAFContext : DbContext
    {
        public DbSet<MissingPerson> MissingPerson { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("User ID=hulafdbagentpoc;Password=hulafpoc123;Host=localhost;Port=5432;Database=hulaf;Pooling=true;");
        }
    }
}

//local poc db login
// CREATE USER hulafdbagentpoc WITH
//  PASSWORD 'hulafpoc123'

//  SELECT pg_terminate_backend(pg_stat_activity.pid)
// FROM pg_stat_activity
// WHERE pg_stat_activity.datname = 'hulaf'
//   AND pid <> pg_backend_pid();