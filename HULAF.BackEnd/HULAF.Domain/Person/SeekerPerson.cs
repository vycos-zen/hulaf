using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using HULAF.Domain.PersonCharacteristic;

namespace HULAF.Domain.Person
{

    public class SeekerPerson
    {
        public Guid Id { get; set; }

        public Characteristics SeekedCharacteristics { get; set; }
    }
}

