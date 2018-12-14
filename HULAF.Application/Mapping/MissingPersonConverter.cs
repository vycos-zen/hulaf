using AutoMapper;
using HULAF.Application.Person.Models;
using HULAF.Domain.Person;
using System;
using System.Collections.Generic;
using System.Text;

namespace HULAF.Application.Mapping
{
    public class MissingPersonConverter : ITypeConverter<Domain.Person.Person, MissingPersonDto>
    {
        public MissingPersonDto Convert(Domain.Person.Person source, MissingPersonDto destination, ResolutionContext context)
        {
            destination = new MissingPersonDto()
            {
                Guid = source.Guid,
                FirstName = source.ContactInfo.FirstName

            };

            return destination;
        }
    }
}
