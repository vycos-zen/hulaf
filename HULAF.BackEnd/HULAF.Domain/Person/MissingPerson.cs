using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using Location;
using HULAF.Domain.PersonCharacteristic;

namespace HULAF.Domain.Person
{
    public class MissingPerson
    {
        public Guid Guid { get; set; }

        public SeenLocation LastSeenLocation { get; set; }

        public Characteristics Characteristics { get; set; }

    }

}