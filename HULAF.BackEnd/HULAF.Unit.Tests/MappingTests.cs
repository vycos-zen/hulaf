using System;
using NUnit.Framework;
using AutoMapper;
using Shouldly;
using HULAF.Domain.Personal;
using HULAF.Domain.Personal.Contact;
using HULAF.Application.Mapping;
using HULAF.Application.Dto.Personal;
using HULAF.Domain.Locator;
using System.Collections.Generic;

namespace HULAF.UnitTests
{
    [TestFixture]
    public class MappingTests
    {
        [SetUp]
        public void Setup()
        {
            Mapper.Initialize(HulafMapperConfiguration.Configuration);
            Mapper.Configuration.CompileMappings();
        }

        [Test]
        public void MappingCnfiguration_IsValid()
        {
            Mapper.Configuration.AssertConfigurationIsValid();
        }

        //[Test]
        //public void MissingPerson_Mapping_Tests()
        //{
        //    var missingPersonDto = new MissingPersonDto
        //    {
        //        Guid = Guid.NewGuid(),
        //        Characteristics = new CharacteristicsDto
        //        {
        //            ApproxAgeMax = 30,
        //            ApproxAgeMin = 20,
        //            ApproxHeightMax = 180,
        //            ApproxHeightMin = 170
        //        }
        //    };
        //    var missingPerson = Mapper.Map<Person>(missingPersonDto);

        //    missingPerson.Characteristics.ApproxAgeMax.ShouldBe(30);
        //}

        [Test]
        public void MissingPersonDto_Mapping()
        {
            var missingPerson = new Person
            {
                ContactInfo = new ContactInfo
                {
                    FirstName = "Géza"
                },
                LastSeenLocations = new List<Location>
                {
                    new Location
                    {
                        Coordinates = new Coordinates
                        {
                            Lat = 12.34m,
                        }
                    }
                }
                
            };


            var missingPersonDto = Mapper.Map<MissingPersonDto>(missingPerson);

            missingPersonDto.ShouldNotBeNull();
            missingPersonDto.FirstName.ShouldBe("Géza");
            missingPersonDto.LastSeenLocations[0].Lat.ShouldBe(12.34m);


        }


        public MappingTests()
        {

        }
    }
}