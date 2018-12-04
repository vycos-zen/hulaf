using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace HULAF.Domain.PersonCharacteristic
{
    public class Characteristics
    {
        public Guid Guid { get; set; }

        public int ApproxHeight { get; set; }

        public int ApproxWeight { get; set; }

        public HairColor HairColor { get; set; }

        public EyeColor EyeColor { get; set; }

        public int ApproxAgeMin { get; set; }

        public int ApproxAgeMax { get; set; }

        public List<string> KnownNames { get; set; }
    }
}

