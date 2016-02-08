using DryIoc.Web.Mvc;
using DryIoc.Web.Sample.App_Start;
using DryIoc.Web.Sample.Services;
using DryIoc.Web.WebApi;
using WebActivatorEx;

[assembly: PreApplicationStartMethod(typeof(DryIocConfig), "Start")]
[assembly: ApplicationShutdownMethod(typeof(DryIocConfig), "Shutdown")]

namespace DryIoc.Web.Sample.App_Start
{
    public static class DryIocConfig
    {
        private static IContainer container;

        static DryIocConfig()
        {
            container = new Container();
        }

        public static void Start()
        {
            container.SetupMvc(typeof(DryIocConfig).Assembly);
            container.SetupApi(typeof(DryIocConfig).Assembly);
            container.Register<ITestService, TestService>();
        }

        public static void Shutdown()
        {
        }
    }
}