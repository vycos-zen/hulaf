using System;
using AutoMapper;
using HULAF.Domain.Person;
using HULAF.WebApi.Controllers;

namespace HULAF.WebApi.Mapping
{

    public class PersonProfile : Profile
    {
        public PersonProfile()
        {
            CreateMap<MissingPerson, MissingPersonDto>();

        }


    }
}