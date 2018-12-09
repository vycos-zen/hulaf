using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using HULAF.Domain.DataDictionary.CharacteristicsDictionaryItems;

namespace HULAF.Domain.Person.Characteristic
{
    public class Characteristics
    {
        public Guid Guid { get; set; }

        public int ApproxHeightMin { get; set; }

        public int ApproxHeightMax { get; set; }

        public int ApproxWeightMin { get; set; }

        public int ApproxWeightMax { get; set; }

        public int ApproxAgeMin { get; set; }

        public int ApproxAgeMax { get; set; }

        public HairColorDictionaryItem HairColor { get; set; }

        public EyeColorDictionaryItem EyeColor { get; set; }

        public List<string> KnownNames { get; set; }
    }
}

