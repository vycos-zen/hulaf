

using AutoMapper;
using HULAF.Application.Personal.Queries;
using HULAF.DataAccess.Context;
using NUnit.Framework;
using Shouldly;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace HULAF.UnitTests
{
    [TestFixture]
    public class ApplicationTests
    {
        private readonly HULAFContext context;

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public async Task MissingPerson_query_test()
        {
            var personHandler = new GetMissingPersonQueryHandler(this.context);
            var personQuery = new GetMissingPersonQuery();
            personQuery.Guid = Guid.Parse("D596BF2C-6DDB-4CCB-A71B-54F18ABE5EF5");

            var personDto = await personHandler.Handle(personQuery, CancellationToken.None);

            personDto.ShouldNotBeNull();
            personDto.Guid.ShouldBe(Guid.Parse("D596BF2C-6DDB-4CCB-A71B-54F18ABE5EF5"));
        }

        public ApplicationTests()
        {
            this.context = new ApplicationTestsBase().TestContext;
        }
    }
}
