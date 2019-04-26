using System;

namespace DryIoc.Web.Sample.Services
{
    public class TestService : ITestService
    {
        public DateTime CurrentTime => DateTime.UtcNow;
    }
}