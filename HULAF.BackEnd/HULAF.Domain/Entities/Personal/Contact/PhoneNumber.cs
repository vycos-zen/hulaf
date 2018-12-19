using System;
using System.Collections.Generic;
using System.Text;

namespace HULAF.Domain.Personal.Contact
{
    public class PhoneContact
    {
        public Guid PhoneContactGuid { get; set; }

        public string PhoneNumber { get; set; }

        public string Description { get; set; }
    }
}
