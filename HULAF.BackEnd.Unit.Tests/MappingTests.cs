using System;
using NUnit.Framework;
using HULAF.WebApi.Controllers;
using HULAF.Domain.Person;
using HULAF.WebApi.Mapping;
using AutoMapper;
using Shouldly;
using Microsoft.Extensions.DependencyInjection;

namespace HULAF.UnitTests
{
    public class MappingTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void MappingCnfiguration_IsValid()
        {
            Mapper.Configuration.AssertConfigurationIsValid();
        }

        [Test]
        public void MissingPerson_Mapping()
        {
            var missingPersonDto = new MissingPersonDto
            {
                Guid = Guid.NewGuid(),
                Characteristics = new CharacteristicsDto
                {
                    ApproxAgeMax = 30,
                    ApproxAgeMin = 20,
                    ApproxHeightMax = 180,
                    ApproxHeightMin = 170
                }
            };
            var missingPerson = Mapper.Map<MissingPerson>(missingPersonDto);

            missingPerson.Characteristics.ApproxAgeMax.ShouldBe(30);
        }


        public MappingTests()
        {
            Mapper.Initialize(HulafMapperConfiguration.GetConfiguration);
        }
    }
}