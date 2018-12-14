using HULAF.Domain.DataDictionary.CharacteristicsDictionaryItems;
using System;
using System.Collections.Generic;

namespace HULAF.Domain.DataDictionary.Schema.CharacteristicsDataDictionaries
{
    public class EyeColorDictionary : IDataDictionary<EyeColorDictionaryItem>
    {
       public List<EyeColorDictionaryItem> DictionaryItems { get; set; }
}
}