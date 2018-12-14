using System;
using System.Collections.Generic;
using System.Text;

namespace HULAF.Application.Person.Models
{
    public class MissingPersonDto
    {
        public Guid Guid { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }
    }
}
