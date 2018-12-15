using AutoMapper;
using HULAF.Application.Dto.Location;
using HULAF.Domain.Locator;
using System;
using System.Collections.Generic;
using System.Text;

namespace HULAF.Application.Mapping
{
    public class LocationProfile : Profile
    {
        public LocationProfile()
        {
            CreateMap<Location, LocationDto>()
                .ForMember(dest => dest.Lat, opt => opt.MapFrom(x => x.Coordinates.Lat));
                //.ConvertUsing<LocationConverter>();
        }
    }
}
