using System;
using NUnit.Framework;
using HULAF.WebApi.Controllers;
using HULAF.Domain.Person;
using HULAF.WebApi.Mapping;
using AutoMapper;
using Shouldly;

namespace HULAF.UnitTests
{
    public class MappingTests
    {
        private IMapper mapper;

        [SetUp]
        public void Setup()
        {
             var mappingConfig = new MappingConfiguration();
             mappingConfig.Confiugre();
            // var mapperConfig = new MapperConfiguration(mappingConfig.config);

            mapper = new Mapper(mappingConfig.config);

            // Mapper.Initialize(cfg => cfg.AddProfile<PersonProfile>());

            // var mappingConfig = new MappingConfiguration();
        }

        [Test]
        public void MappingCnfiguration_IsValid(){

            Mapper.AssertConfigurationIsValid();
        }

        [Test]
        public void MissingPerson_Mapping()
        {
            var missingPersonDto = new MissingPersonDto{
                Guid = Guid.NewGuid(),
                Characteristics = new CharacteristicsDto{
                    ApproxAgeMax = 30,
                    ApproxAgeMin = 20,
                    ApproxHeightMax = 180,
                    ApproxHeightMin = 170
                }
            };
            var missingPerson = Mapper.Map<MissingPerson>(missingPersonDto);

            missingPerson.Characteristics.ApproxAgeMax.ShouldBe(30);


        }
    }
}