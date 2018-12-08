using System;

namespace HULAF.Domain.DataDictionary.Schema
{
    public interface IDataDictionaryItem
    {
        Guid Guild { get; set; }

        int SequenceId { get; set; }

        string Title { get; set; }

        string Value { get; set; }

        string Description { get; set; }

        string Language { get; set; }

    }
}