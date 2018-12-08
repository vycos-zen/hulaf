using HULAF.Domain.DataDictionary.Schema;
using System;
using System.Collections.Generic;
using System.Text;

namespace HULAF.Domain.DataDictionary.CharacteristicsDictionaryItems
{
    public class HairColor : IDataDictionaryItem
    {
        public Guid Guild { get; set; }
        public int SequenceId { get; set; }
        public string Title { get; set; }
        public string Value { get; set; }
        public string Description { get; set; }
        public string Language { get; set; }
    }
}
