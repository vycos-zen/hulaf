using System;
using NUnit.Framework;
using AutoMapper;
using Shouldly;
using HULAF.WebApi.Controllers;
using HULAF.Domain.Person;
//using HULAF.WebApi.Mapping;
using HULAF.Domain.Person.Contact;
using HULAF.Application.Mapping;

namespace HULAF.UnitTests
{
    [TestFixture]
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
        public void MissingPerson_Mapping_Tests()
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
            var missingPerson = Mapper.Map<Person>(missingPersonDto);

            missingPerson.Characteristics.ApproxAgeMax.ShouldBe(30);
        }

        [Test]
        public void MissingPersonDto_Mapping()
        {
            var missingPerson = new Person
            {
                ContactInfo = new ContactInfo
                {
                    FirstName = "Géza"
                }
            };

            var mapps = Mapper.Configuration;


            var missingPersonDto = Mapper.Map<MissingPersonDto>(missingPerson);

            missingPersonDto.ShouldNotBeNull();
            missingPersonDto.ContactInfo.FirstName.ShouldBe("Géza");


        }


        public MappingTests()
        {
            Mapper.Initialize(HulafMapperConfiguration.GetConfiguration);
        }
    }
}