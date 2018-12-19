using AutoMapper;
using HULAF.Application.Mapping;
using NUnit.Framework;
using Shouldly;
using System;

namespace HULAF.UnitTests
{
    [TestFixture]
    public class MapperTests
    {

        [Test]
        public void MappingCnfiguration_IsValid()
        {
            Mapper.Initialize(HulafMapperConfig.HulafMapper)
            Mapper.Configuration.AssertConfigurationIsValid();
        }

        public MapperTests()
        {

        }
    }
}
