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
            personQuery.Guid = Guid.Parse("{ddf3e819-3caa-46bd-95d8-0a20a1929600}");

            var personDto = await personHandler.Handle(personQuery, CancellationToken.None);

            personDto.ShouldNotBeNull();
            personDto.Guid.ShouldBe(Guid.Parse("{ddf3e819-3caa-46bd-95d8-0a20a1929600}"));
        }

        public ApplicationTests()
        {
            this.context = new ApplicationTestsBase().TestContext;
        }
    }
}
