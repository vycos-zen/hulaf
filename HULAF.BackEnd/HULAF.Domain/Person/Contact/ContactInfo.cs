using HULAF.Domain.Locator;
using System;
using System.Collections.Generic;
using System.Text;

namespace HULAF.Domain.Person.Contact
{
    public class ContactInfo
    {
        public Guid Guid { get; set; }

        public string Email { get; set; }

        public List<PhoneContact> ContactNumbers { get; set; }

        public Location Address { get; set; }
    }
}
