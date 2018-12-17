using HULAF.DataAccess.Context;
using System;

namespace HULAF.UnitTests
{
    public class ApplicationTestsBase : IDisposable
    {
        protected readonly HULAFContext context;

        public ApplicationTestsBase()
        {
            this.context = HULAFContextFactory.Create();
        }

        public void Dispose()
        {
            HULAFContextFactory.Destroy(this.context);
        }

        public HULAFContext TestContext
        {
            get
            {
                return this.context;
            }
        }
    }
}