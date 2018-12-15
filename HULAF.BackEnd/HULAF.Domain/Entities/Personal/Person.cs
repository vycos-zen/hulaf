using HULAF.Domain.Personal.Characteristic;
using HULAF.Domain.Locator;
using HULAF.Domain.Personal.Contact;
using System;
using System.Collections.Generic;
using System.Text;

namespace HULAF.Domain.Personal
{
    public class Person
    {
        public Guid Guid { get; set; }

        public Location CurrentLocation { get; set; }

        public List<Location> LastSeenLocations { get; set; }

        public Characteristics Characteristics { get; set; }

        public Characteristics SeekedCharacteristics { get; set; }

        public ContactInfo ContactInfo { get; set; }
    }
}
