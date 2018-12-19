using System;
using System.Collections.Generic;
using System.Text;

namespace HULAF.Domain.Locator
{
    public class Coordinates
    {
        public Guid CoordinatesGuid { get; set; }

        public decimal Lat { get; set; }

        public decimal Lng { get; set; }

        public decimal Accuracy { get; set; }

        public DateTime TimeStampUtc { get; set; }

    }
}
