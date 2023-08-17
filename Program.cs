using System;
using SimpleCMDParser.Infra;
using SimpleCMDParser.Services.Parsing;
using SimpleCMDParser.Services.Printing;
using Unity;

namespace SimpleCMDParser
{
    internal static class Program
    {
        private static ICmdPrinter _printer;

        internal static void Main()
        {
            var container = UnityConfig.Register();
            _printer = container.Resolve<ICmdPrinter>();

            var cmdParser = new CommandLineParser(_printer);
            _printer.PrintStatement(PromptConstants.ExitPrompt);
            _printer.PrintStatementWithoutNewLine(PromptConstants.Arrow);

            string line;
            while ((line = Console.ReadLine()) != null)
            {
                cmdParser.ParseLine(line);
                _printer.PrintStatementWithoutNewLine(PromptConstants.Arrow);
            }
        }
    }
}
