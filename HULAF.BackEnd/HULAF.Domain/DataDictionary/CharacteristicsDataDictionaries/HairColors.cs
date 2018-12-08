using HULAF.Domain.DataDictionary.CharacteristicsDictionaryItems;
using HULAF.Domain.DataDictionary.Schema;
using System;
using System.Collections.Generic;

namespace HULAF.Domain.DataDictionary.CharacteristicsDataDictionaries
{

    public class HairColors : IDataDictionary
    {
        public List<HairColor> DictionaryItems { get; set; }
    }
}