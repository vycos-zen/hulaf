using System;
using System.Collections.Generic;
using System.Text;

namespace HULAF.Application.Dto.Personal
{
    public class CharacteristicsDto
    {
        public string Guid { get; set; }

        public int ApproxHeightMin { get; set; }

        public int ApproxHeightMax { get; set; }

        //public HairColorDto HairColor { get; set; }

        //public EyeColorDto EyeColor { get; set; }

        public int ApproxAgeMin { get; set; }

        public int ApproxAgeMax { get; set; }

        public System.Collections.Generic.List<string> KnownNames { get; set; } = new System.Collections.Generic.List<string>();

    }
}
