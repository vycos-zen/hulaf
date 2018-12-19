using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using HULAF.Domain.Personal;
using HULAF.Domain.DataDictionary.CharacteristicsDictionaryItems;
using HULAF.Domain.DataDictionary.Schema.CharacteristicsDataDictionaries;
using HULAF.Domain.DataDictionary.CharacteristicsDataDictionaries;

namespace HULAF.DataAccess.Context
{
    public class HULAFContext : DbContext
    {
        private readonly string connnectionString;

        public DbSet<Person> Person { get; set; }
        
        public DbSet<EyeColorDictionary> EyeColorDictionary { get; set; }

        public DbSet<HairColorDictionary> HairColorDictionary { get; set; }

        public DbSet<EyeColorDictionaryItem> EyeColorDictionaryItem { get; set; }

        public DbSet<HairColorDictionaryItem> HairColorDictionaryItem { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(HULAFContext).Assembly);
        } 

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
