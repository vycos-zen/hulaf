using System;
using System.Collections.Generic;
using System.Text;

namespace HULAF.Domain.Personal.Contact
{
    public class PhoneContact
    {
        public Guid Guid { get; set; }

        public string PhoneNumber { get; set; }

        public string Description { get; set; }
    }
}
