using System;
using System.Collections.Generic;
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

            char[] space = Properties.Resources.SPACE.ToCharArray();
            var arrowWithSpace = Properties.Resources.ArrowWithSpace;

            CommandLineParser cmdParser = new CommandLineParser(_printer);
            _printer.PrintStatement(Properties.Resources.PROMPT);
            _printer.PrintStatementWithoutNewLine(arrowWithSpace);

            string line;
            while ((line = Console.ReadLine()) != null)
            {
                string[] cmdline = line.Split(space[0], (char)StringSplitOptions.None);
                cmdParser.ParseLine(new Queue<string>(cmdline));
                _printer.PrintStatementWithoutNewLine(arrowWithSpace);
            }
        }
    }
}
