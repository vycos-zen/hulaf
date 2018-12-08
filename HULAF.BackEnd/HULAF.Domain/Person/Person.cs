using HULAF.Domain.Person.Characteristic;
using HULAF.Domain.Locator;
using HULAF.Domain.Person.Contact;
using System;
using System.Collections.Generic;
using System.Text;

namespace HULAF.Domain.Person
{
    public class Person
    {
        public Guid Guid { get; set; }

        public Location CurrentLocation { get; set; }

        public Location LastSeenLocation { get; set; }

        public Characteristics Characteristics { get; set; }

        public Characteristics SeekedCharacteristics { get; set; }

        public ContactInfo ContactInfo { get; set; }
    }
}
