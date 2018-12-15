using AutoMapper;
using HULAF.Application.Dto.Location;
using HULAF.Application.Dto.Personal;
using HULAF.Domain.Personal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HULAF.Application.Mapping
{
    public class MissingPersonConverter : ITypeConverter<Person, MissingPersonDto>
    {
        public MissingPersonDto Convert(Person source, MissingPersonDto destination, ResolutionContext context)
        {
            destination = new MissingPersonDto()
            {
                Guid = source.Guid,
                FirstName = source.ContactInfo.FirstName,
            };

            destination.LastSeenLocations = source.LastSeenLocations.Select(location => Mapper.Map<LocationDto>(location)).ToList();

            return destination;
        }
    }
}
