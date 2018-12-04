using System;
using AutoMapper;

namespace HULAF.WebApi.Mapping
{
    public class MappingConfiguration
    {
        public MappingConfiguration()
        {
            Mapper.Initialize(cfg => cfg.AddProfile<PersonProfile>());

        }
    }
}