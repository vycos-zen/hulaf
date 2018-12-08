using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using HULAF.Domain.Person;

namespace HULAF.DataAccess.Context
{
    public class HULAFContext : DbContext
    {
        private readonly string connnectionString;
        public DbSet<Person> Person { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql(connnectionString);
            }
        }

        public HULAFContext(string connnectionString) : base()
        {
            this.connnectionString = connnectionString;
        }

        public HULAFContext(DbContextOptions<HULAFContext> options) : base(options)
        {
            
        }
    }
}
