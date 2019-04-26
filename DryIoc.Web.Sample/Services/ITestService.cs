using System;

namespace DryIoc.Web.Sample.Services
{
    public interface ITestService
    {
        DateTime CurrentTime { get; }
    }
}