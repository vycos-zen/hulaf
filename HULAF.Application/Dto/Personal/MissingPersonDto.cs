using System;
using System.Collections.Generic;
using HULAF.Application.Dto.Location;

namespace HULAF.Application.Dto.Personal
{
    public class MissingPersonDto
    {
        public Guid Guid { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public int ApproxHeightMin { get; set; }

        public int ApproxHeightMax { get; set; }

        //public HairColorDto HairColor { get; set; }

        //public EyeColorDto EyeColor { get; set; }

        public int ApproxAgeMin { get; set; }

        public int ApproxAgeMax { get; set; }

        public List<string> KnownNames { get; set; } = new List<string>();

        public List<LocationDto> LastSeenLocations { get; set; } = new List<LocationDto>();
    }
}
