using AutoMapper;
using HULAF.Application.Dto.Location;
using HULAF.Domain.Locator;
using System;
using System.Collections.Generic;
using System.Text;

namespace HULAF.Application.Mapping
{
    class LocationConverter : ITypeConverter<Location, LocationDto>
    {
        public LocationDto Convert(Location source, LocationDto destination, ResolutionContext context)
        {
            destination = new LocationDto
            {
                City = source.City,
            };

            return destination;
        }
    }
}
