using System;
using System.Collections.Generic;
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
            
            const string arrowWithSpace = PromptConstants.Arrow;

            CommandLineParser cmdParser = new CommandLineParser(_printer);
            _printer.PrintStatement(PromptConstants.ExitPrompt);
            _printer.PrintStatementWithoutNewLine(arrowWithSpace);

            string line;
            while ((line = Console.ReadLine()) != null)
            {
                string[] cmdline = line.Split(PromptConstants.EmptySpace[0], (char)StringSplitOptions.None);
                cmdParser.ParseLine(new Queue<string>(cmdline));
                _printer.PrintStatementWithoutNewLine(arrowWithSpace);
            }
        }
    }
}
