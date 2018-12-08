using System;
using System.Collections.Generic;
using System.Text;

namespace HULAF.Domain.DataDictionary.Schema
{
    public interface IDataDictionary
    {
        List<IDataDictionaryItem> DictionaryItems { get; set; }
    }
}
