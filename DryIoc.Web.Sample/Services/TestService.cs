using System;

namespace DryIoc.Web.Sample.Services
{
    public class TestService : ITestService
    {
        public object Value
        {
            get
            {
                return DateTime.Now.Ticks;
            }
        }
    }
}