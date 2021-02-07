using System.Collections.Generic;

namespace SimpleCMDParser
{
    internal class CommandLineParser : IParser
    {
        private const int maxArgsNumber = 3;
        private const int emptyNumberOfLines = 0;
        private readonly ICmdPrinter _printer;
        public CommandLineParser(ICmdPrinter printer)
        {
            _printer = printer;
        }

        public void ParseLine(Queue<string> line)
        {
            while (line.Count > emptyNumberOfLines)
            {
                if (line.Count < maxArgsNumber)
                {
                    _printer.PrintError(Properties.Resources.NotEnoughArguments);
                    break;
                }

                string command = line.Dequeue();
                if (!Mapper.actions.ContainsKey(command))
                {
                    _printer.PrintError(Properties.Resources.UnknownParameter);
                    continue;
                }

                string arg1 = line.Dequeue();
                string arg2 = line.Dequeue();
                string[] args = new string[] { arg1, arg2 };

                var operation = Mapper.GetOperation(command);
                string result = operation.Execute(arg1, arg2);
                string message = operation.GetOutputMessage(command, args, result ?? Properties.Resources.Unkown);
                _printer.PrintStatement(message);
            }
        }
    }
}