using System.Linq;
using System.Reflection;

namespace DryIoc.Web.Extensions
{
    public static class DryIocExtensions
    {
        public static void RegisterInstancesOf<T>(this IContainer container, Assembly assembly) where T : class
        {
            var type = typeof(T);

            var typesToRegister = assembly.GetTypes()
                   .Where(p => type.IsAssignableFrom(p) && !p.IsAbstract && !p.IsInterface);

            foreach (var controllerType in typesToRegister)
            {
                container.Register(controllerType, Reuse.InResolutionScope);
            }
        }
    }
}
