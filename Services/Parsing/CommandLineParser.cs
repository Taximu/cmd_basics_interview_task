using System.Collections.Generic;
using SimpleCMDParser.Infra;
using SimpleCMDParser.Services.Printing;

namespace SimpleCMDParser.Services.Parsing
{
    internal class CommandLineParser : IParser
    {
        private const int MaxArgsNumber = 3;
        private const int EmptyNumberOfLines = 0;
        private readonly ICmdPrinter _printer;
        public CommandLineParser(ICmdPrinter printer)
        {
            _printer = printer;
        }

        public void ParseLine(Queue<string> line)
        {
            while (line.Count > EmptyNumberOfLines)
            {
                if (line.Count < MaxArgsNumber)
                {
                    _printer.PrintError(PromptConstants.NotEnoughArguments);
                    break;
                }

                string command = line.Dequeue();
                if (!Mapper.Actions.ContainsKey(command))
                {
                    _printer.PrintError(PromptConstants.UnknownParameter);
                    continue;
                }
                
                string[] args = { line.Dequeue(), line.Dequeue() };

                var operation = Mapper.GetOperation(command);
                string result = operation.Execute(args[0], args[1]);
                string message = operation.GetOutputMessage(command, args, result ?? PromptConstants.Unknown);
                _printer.PrintStatement(message);
            }
        }
    }
}
