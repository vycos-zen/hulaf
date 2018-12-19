using HULAF.Domain.DataDictionary.CharacteristicsDictionaryItems;
using HULAF.Domain.DataDictionary.Schema;
using System;
using System.Collections.Generic;

namespace HULAF.Domain.DataDictionary.CharacteristicsDataDictionaries
{

    public class HairColorDictionary : IDataDictionary<HairColorDictionaryItem>
    {
        public Guid HairColorDictionaryGuid { get; set; }

        public List<HairColorDictionaryItem> DictionaryItems { get; set; }
    }
}