using System;
using NUnit.Framework;
using HULAF.WebApi.Controllers;
// using HULAF.W
using HULAF.Domain.Person;

namespace HULAF.UnitTests
{
    public class MappingTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void MissingPerson_Mapping()
        {
            var missingPersonDto = new MissingPersonDto(){
                Guid = Guid.NewGuid(),
            };
            var missingPerson = new MissingPerson();
            // MappingConfiguration.Mapper.Mapp


        }
    }
}