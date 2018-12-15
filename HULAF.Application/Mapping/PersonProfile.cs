using System;
using System.Linq;
using AutoMapper;
using HULAF.Application.Dto.Location;
using HULAF.Application.Dto.Personal;
using HULAF.Domain.Personal;

namespace HULAF.Application.Mapping
{

    public class PersonProfile : Profile
    {
        public PersonProfile()
        {

            CreateMap<Person, MissingPersonDto>()
                .ForMember(dest => dest.Guid, opt => opt.MapFrom(src => src.Guid))
                .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.ContactInfo.FirstName))
                .ForMember(dest => dest.MiddleName, opt => opt.MapFrom(src => src.ContactInfo.MiddleName))
                .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.ContactInfo.LastName))
                .ForMember(dest => dest.ApproxAgeMin, opt => opt.MapFrom(src => src.Characteristics.ApproxAgeMin))
                .ForMember(dest => dest.ApproxAgeMax, opt => opt.MapFrom(src => src.Characteristics.ApproxAgeMax))
                .ForMember(dest => dest.ApproxHeightMin, opt => opt.MapFrom(src => src.Characteristics.ApproxHeightMin))
                .ForMember(dest => dest.ApproxHeightMax, opt => opt.MapFrom(src => src.Characteristics.ApproxHeightMax))
                .ForMember(dest => dest.LastSeenLocations, opt => opt.MapFrom(src => src.LastSeenLocations.Select(location => Mapper.Map<LocationDto>(location))));
            //.ConvertUsing<MissingPersonConverter>();

        }


    }
}