using System;
using System.Collections.Generic;
using System.Text;

namespace HULAF.Application.Dto.Location
{
    public class LocationDto
    {
        public Guid Guid { get; set; }

        public string City { get; set; }

        public string Country { get; set; }

        public decimal Lat { get; set; }

        public decimal Lng { get; set; }

        public decimal Accuracy { get; set; }

        public DateTime TimeStampUtc { get; set; }
    }
}
