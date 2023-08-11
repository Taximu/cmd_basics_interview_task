using SimpleCMDParser.Services.Printing;
using Unity;

namespace SimpleCMDParser.Infra
{
    internal static class UnityConfig
    {
        public static UnityContainer Register()
        {
            var container = new UnityContainer();
            container.RegisterType<ICmdPrinter, CommandLinePrinter>();
            return container;
        }
    }
}
