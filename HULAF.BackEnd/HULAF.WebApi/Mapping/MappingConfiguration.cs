using System;
using AutoMapper;
using AutoMapper.Configuration;

namespace HULAF.WebApi.Mapping
{
    public class MappingConfiguration
    {
        public MapperConfigurationExpression config { get; set; }

        public void Confiugre()
        {
            config = new MapperConfigurationExpression();
            config.AddProfile<PersonProfile>();
            

        }

        public MappingConfiguration()
        {
        }
    }
}