using System;
using AutoMapper;
using HULAF.Application.Person.Models;
using HULAF.Domain.Person;

namespace HULAF.Application.Mapping
{

    public class PersonProfile : Profile
    {
        public PersonProfile()
        {

            CreateMap<Domain.Person.Person, MissingPersonDto>()
                .ConvertUsing<MissingPersonConverter>();

        }


    }
}