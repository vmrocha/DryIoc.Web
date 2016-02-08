using System.Reflection;
using System.Web.Http;
using DryIoc.Web.Extensions;

namespace DryIoc.Web.WebApi
{
    public static class DryIocExtensions
    {
        public static void SetupApi(this IContainer container, Assembly assembly)
        {
            GlobalConfiguration.Configuration.DependencyResolver = new DryIocDependencyResolver(container);
            container.RegisterInstancesOf<ApiController>(assembly);
        }
    }
}
