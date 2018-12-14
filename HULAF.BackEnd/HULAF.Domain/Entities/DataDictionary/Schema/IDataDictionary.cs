using System;
using System.Collections.Generic;
using System.Text;

namespace HULAF.Domain.DataDictionary.Schema
{
    public interface IDataDictionary<T> where T : IDataDictionaryItem
    {
        List<T> DictionaryItems { get; set; }
    }
}
