using HULAF.Domain.Person.Characteristic;
using HULAF.Domain.Locator;
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
    }
}
