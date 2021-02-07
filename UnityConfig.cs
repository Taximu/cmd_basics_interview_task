using Unity;

namespace SimpleCMDParser
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
