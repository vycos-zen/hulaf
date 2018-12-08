using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace HULAF.Domain.Locator
{
    public class Location
    {
        public Guid Guid { get; set; }

        public string City { get; set; }

        public string Country { get; set; }

        public Coordinates Coordinates { get; set; }
    }
}