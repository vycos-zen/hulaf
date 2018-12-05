using System;
using AutoMapper;
using HULAF.Domain.Person;
using HULAF.WebApi.Controllers;

namespace HULAF.WebApi.Mapping
{

    public class HulafControllerProfile : Profile
    {
        public HulafControllerProfile()
        {
            
            CreateMap<MissingPerson, MissingPersonDto>()
            .ReverseMap();

        }


    }
}